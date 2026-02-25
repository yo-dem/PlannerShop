using PlannerShop.Data;
using PlannerShop.Forms.Agenda.Forms.Cruds;
using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    // ============================================================
    // PANEL DOPPIO BUFFER (usato per header, timebar, canvas)
    // ============================================================
    internal class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            UpdateStyles();
        }
        protected override void OnPaintBackground(PaintEventArgs e) { }
    }


    // ============================================================
    // CANVAS PRINCIPALE AGENDA
    // Architettura:
    //   _header  : strip fissa in cima (nomi giorni)
    //   _timebar : strip fissa a sinistra (ore)
    //   _canvas  : area centrale con griglia + appuntamenti disegnati via GDI+
    //   _vscroll : scrollbar verticale esplicita
    // Lo scroll è gestito da _scrollY; la rotella viene intercettata
    // sia qui che da tutti i figli tramite override WndProc.
    // ============================================================
    internal class AgendaCanvasPanel : UserControl
    {
        // ── Layout ──────────────────────────────────────────────
        private const int TimeColW = 68;
        private const int HeaderH = 60;
        private const int SlotH = 50;
        private const int DayCount = 7;
        private const int SlotCount = 14 * 4;   // 08:00–22:00 = 56 slot
        private static readonly TimeSpan FirstSlot = new(8, 0, 0);

        // ── Colori ──────────────────────────────────────────────
        private static readonly Color CGridFaint = Color.FromArgb(225, 225, 225);
        private static readonly Color CGridHour = Color.FromArgb(180, 180, 180);
        private static readonly Color CSideBg = Color.FromArgb(250, 250, 250);
        private static readonly Color CTodayBg = Color.FromArgb(240, 246, 255);
        private static readonly Color CTodayLine = Color.FromArgb(60, 120, 215);
        private static readonly Color CWeekendBg = Color.FromArgb(255, 248, 248);
        private static readonly Color CText = Color.FromArgb(40, 40, 40);
        private static readonly Color CSubText = Color.FromArgb(120, 120, 120);
        private static readonly Color CWeekend = Color.FromArgb(185, 40, 40);
        private static readonly Color CNowLine = Color.FromArgb(220, 50, 50);

        // ── Stato ───────────────────────────────────────────────
        private readonly CultureInfo _it = new("it-IT");
        private DateTime _weekStart;
        private List<Appointment> _allApps = [];
        private int _scrollY = 0;

        // ── Drag & Drop ─────────────────────────────────────────
        private Appointment? _dragApp = null;   // app in corso di drag
        private Point _dragStartPt;             // punto mousedown sul canvas
        private int _dragOffsetY;             // offset Y dentro il blocco al momento del click
        private bool _isDragging = false;   // soglia superata
        private int _dragCurrentY = 0;       // Y corrente del ghost (content coords)
        private int _dragCurrentD = 0;       // colonna giorno del ghost
        private readonly BufferedPanel _tipPanel = new() { Visible = false, BackColor = Color.FromArgb(255, 255, 225), Padding = new Padding(6) };
        private Appointment? _tooltipApp = null;
        private string _tooltipText = "";

        // ── Controlli ───────────────────────────────────────────
        private readonly BufferedPanel _header;
        private readonly BufferedPanel _timebar;
        private readonly BufferedPanel _canvas;
        private readonly VScrollBar _vscroll;
        private readonly System.Windows.Forms.Timer _nowTimer;

        // ── Callback ────────────────────────────────────────────
        public event Action<DateTime, TimeSpan>? RequestNewAppointment;
        public event Action<Appointment>? RequestEditAppointment;


        // ============================================================
        // COSTRUTTORE
        // ============================================================
        public AgendaCanvasPanel()
        {
            _weekStart = GetStartOfWeek(DateTime.Today);

            _header = new BufferedPanel { BackColor = Color.White };
            _header.Paint += OnHeaderPaint;

            _timebar = new BufferedPanel { BackColor = CSideBg };
            _timebar.Paint += OnTimebarPaint;

            _canvas = new BufferedPanel { BackColor = Color.White };
            _canvas.Paint += OnCanvasPaint;
            _canvas.MouseDown += OnCanvasMouseDown;
            _canvas.MouseDoubleClick += OnCanvasDoubleClick;
            _canvas.MouseMove += OnCanvasMouseMove;
            _canvas.MouseLeave += OnCanvasMouseLeave;
            _canvas.MouseUp += OnCanvasMouseUp;

            _vscroll = new VScrollBar { SmallChange = SlotH / 2, LargeChange = SlotH * 4 };
            _vscroll.Scroll += (_, e) => SetScroll(e.NewValue);

            _tipPanel.Paint += OnTipPaint;

            Controls.Add(_canvas);
            Controls.Add(_vscroll);
            Controls.Add(_header);
            Controls.Add(_timebar);
            Controls.Add(_tipPanel);
            _header.BringToFront();
            _timebar.BringToFront();
            _tipPanel.BringToFront();

            // Propaga la rotella da tutti i controlli figli al canvas
            foreach (Control c in new Control[] { _header, _timebar, _vscroll })
                c.MouseWheel += (_, e) => HandleWheel(e.Delta);

            _nowTimer = new System.Windows.Forms.Timer { Interval = 30_000 };
            _nowTimer.Tick += (_, _) => _canvas.Invalidate();
            _nowTimer.Start();

            Resize += (_, _) => DoLayout();
            HandleCreated += (_, _) => DoLayout();
        }


        // ============================================================
        // API
        // ============================================================
        public void SetWeek(DateTime weekStart)
        {
            _weekStart = GetStartOfWeek(weekStart);
            _header.Invalidate();
            _canvas.Invalidate();
        }

        public void LoadAppointments(List<Appointment> apps)
        {
            _allApps = apps;
            _header.Invalidate();
            _canvas.Invalidate();
        }

        public void ScrollToCurrentTime()
        {
            int target = TimeToY(DateTime.Now.TimeOfDay) - _canvas.Height / 3;
            SetScroll(Math.Max(0, target));
        }


        // ============================================================
        // SCROLL
        // ============================================================
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            HandleWheel(e.Delta);
        }

        private void HandleWheel(int delta)
        {
            SetScroll(_scrollY - delta / 120 * SlotH);
        }

        private void SetScroll(int newY)
        {
            int maxScroll = Math.Max(0, SlotCount * SlotH - _canvas.Height);
            _scrollY = Math.Clamp(newY, 0, maxScroll);
            _vscroll.Value = Math.Min(_scrollY, Math.Max(0, _vscroll.Maximum - _vscroll.LargeChange + 1));
            _canvas.Invalidate();
            _timebar.Invalidate();
        }

        // Intercetta WM_MOUSEWHEEL anche quando il focus è su controlli figli
        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEWHEEL = 0x020A;
            if (m.Msg == WM_MOUSEWHEEL)
            {
                int delta = (int)m.WParam >> 16;
                HandleWheel(delta);
                return;
            }
            base.WndProc(ref m);
        }


        // ============================================================
        // LAYOUT
        // ============================================================
        private void DoLayout()
        {
            if (Width <= 0 || Height <= 0) return;

            int sbW = SystemInformation.VerticalScrollBarWidth;
            int canvasW = Width - sbW;

            _header.SetBounds(0, 0, canvasW, HeaderH);
            _canvas.SetBounds(0, HeaderH, canvasW, Height - HeaderH);
            _timebar.SetBounds(0, HeaderH, TimeColW, Height - HeaderH);
            _vscroll.SetBounds(canvasW, HeaderH, sbW, Height - HeaderH);

            int totalH = SlotCount * SlotH;
            int maxScroll = Math.Max(0, totalH - _canvas.Height);
            _vscroll.Maximum = totalH;
            _vscroll.LargeChange = Math.Max(1, _canvas.Height);
            _scrollY = Math.Clamp(_scrollY, 0, maxScroll);

            _header.BringToFront();
            _timebar.BringToFront();

            Invalidate(true);
        }

        private int DayColW => Math.Max(1, (_canvas.Width - TimeColW) / DayCount);
        private int DayLeft(int d) => TimeColW + d * DayColW;
        private int TotalH => SlotCount * SlotH;

        private int TimeToY(TimeSpan t) =>
            (int)((t - FirstSlot).TotalMinutes / 15.0 * SlotH);

        private TimeSpan YToSlot(int contentY)
        {
            int slot = Math.Clamp(contentY / SlotH, 0, SlotCount - 1);
            return FirstSlot.Add(TimeSpan.FromMinutes(slot * 15));
        }


        // ============================================================
        // HIT TEST appuntamenti (coordinate relative al canvas)
        // ============================================================
        private Appointment? HitTest(int canvasX, int canvasY)
        {
            int contentY = canvasY + _scrollY;
            if (canvasX < TimeColW) return null;

            int d = (canvasX - TimeColW) / DayColW;
            if (d < 0 || d >= DayCount) return null;

            DateTime day = _weekStart.AddDays(d);
            var dayApps = _allApps.Where(a => a.Start.Date == day.Date).OrderBy(a => a.Start).ToList();
            if (dayApps.Count == 0) return null;

            var columns = ResolveColumns(dayApps);
            int maxCols = columns.Max(x => x.col) + 1;
            int colW = (DayColW - 6) / maxCols;
            const int LeftMargin = 20; // deve coincidere con il valore usato nel disegno

            foreach (var (app, col) in columns)
            {
                // Calcola esattamente il rettangolo disegnato per questo appuntamento
                int xLeft = DayLeft(d) + LeftMargin + col * colW;
                int xRight = xLeft + colW - 22;
                int yTop = TimeToY(app.Start.TimeOfDay);
                int yBot = TimeToY(app.End.TimeOfDay);

                if (canvasX >= xLeft && canvasX <= xRight &&
                    contentY >= yTop && contentY <= yBot)
                    return app;
            }
            return null;
        }


        // ============================================================
        // PAINT — HEADER GIORNI
        // ============================================================
        private void OnHeaderPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            g.FillRectangle(new SolidBrush(CSideBg), 0, 0, TimeColW, HeaderH);

            using var sidePen = new Pen(CGridHour);
            using var sepPen = new Pen(Color.Black, 2);
            using var colPen = new Pen(Color.FromArgb(200, 200, 200));
            using var todayPen = new Pen(CTodayLine, 3);
            using var dotBrush = new SolidBrush(CTodayLine);
            using var bf = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            g.DrawLine(sidePen, TimeColW - 1, 0, TimeColW - 1, HeaderH);

            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                bool isToday = day.Date == DateTime.Today;
                bool isWeekend = day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
                bool isSat = day.DayOfWeek == DayOfWeek.Saturday;
                int x = DayLeft(d), w = DayColW;

                if (isToday) g.FillRectangle(new SolidBrush(CTodayBg), x, 0, w, HeaderH);
                else if (isWeekend) g.FillRectangle(new SolidBrush(CWeekendBg), x, 0, w, HeaderH);

                Color tc = isWeekend ? CWeekend : CText;
                Color dc = isWeekend ? CWeekend : CText;   // data sempre scura e bold
                int half = HeaderH / 2;

                TextRenderer.DrawText(g,
                    _it.TextInfo.ToTitleCase(day.ToString("dddd", _it)), bf,
                    new Rectangle(x + 5, 2, w - 22, half),
                    tc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // Data in bold
                using var datFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                TextRenderer.DrawText(g,
                    day.ToString("d MMM", _it), datFont,
                    new Rectangle(x + 5, half, w - 10, half - 4),
                    dc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                if (_allApps.Any(a => a.Start.Date == day.Date))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(dotBrush, x + w - 13, 5, 8, 8);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                }

                if (isToday) g.DrawLine(todayPen, x, HeaderH - 2, x + w - 1, HeaderH - 2);
                bool isSun = day.DayOfWeek == DayOfWeek.Sunday;
                if (isSat) g.DrawLine(sepPen, x, 0, x, HeaderH);        // nero ven→sab
                else if (isSun) g.DrawLine(colPen, x, 0, x, HeaderH);        // grigio sab→dom
                else g.DrawLine(colPen, x + w - 1, 0, x + w - 1, HeaderH);
            }

            using var hbPen = new Pen(CGridHour);
            g.DrawLine(hbPen, 0, HeaderH - 1, _header.Width, HeaderH - 1);
        }


        // ============================================================
        // PAINT — COLONNA ORE
        // ============================================================
        private void OnTimebarPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(CSideBg);

            using var borderPen = new Pen(CGridHour);
            using var fontHour = new Font("Segoe UI", 10f, FontStyle.Bold);
            using var fontSub = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            using var linePenH = new Pen(CGridHour);
            using var linePenS = new Pen(CGridFaint);

            g.DrawLine(borderPen, TimeColW - 1, 0, TimeColW - 1, _timebar.Height);

            for (int s = 0; s < SlotCount; s++)
            {
                int yPanel = s * SlotH - _scrollY;
                if (yPanel + SlotH < 0 || yPanel > _timebar.Height) continue;

                TimeSpan t = FirstSlot.Add(TimeSpan.FromMinutes(s * 15));
                bool isHour = t.Minutes == 0;

                if (isHour)
                {
                    // Ora intera: testo allineato a destra, font bold
                    TextRenderer.DrawText(g, $"{t.Hours:D2}:{t.Minutes:D2}", fontHour,
                        new Rectangle(0, yPanel, TimeColW - 6, SlotH),
                        CText,
                        TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

                    // Lineetta più lunga per le ore
                    g.DrawLine(linePenH, 4, yPanel, TimeColW - 8, yPanel);
                }
                else
                {
                    // Quarto d'ora: testo più piccolo, spostato a sinistra (right margin maggiore)
                    TextRenderer.DrawText(g, $":{t.Minutes:D2}", fontSub,
                        new Rectangle(0, yPanel, TimeColW - 14, SlotH),
                        CSubText,
                        TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

                    // Lineetta corta
                    g.DrawLine(linePenS, TimeColW - 20, yPanel, TimeColW - 8, yPanel);
                }
            }
        }


        // ============================================================
        // PAINT — GRIGLIA + APPUNTAMENTI
        // ============================================================
        private void OnCanvasPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            // Tutto viene disegnato nello spazio "contenuto" (0..TotalH),
            // poi traslato di -_scrollY per mostrare la porzione corretta
            g.TranslateTransform(0, -_scrollY);

            int w = _canvas.Width;

            // ── Sfondi ────────────────────────────────────────────
            g.FillRectangle(new SolidBrush(CSideBg), 0, 0, TimeColW, TotalH);

            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                if (day.Date == DateTime.Today)
                    g.FillRectangle(new SolidBrush(CTodayBg), DayLeft(d), 0, DayColW, TotalH);
                else if (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(12, 200, 50, 50)),
                        DayLeft(d), 0, DayColW, TotalH);
            }

            // ── Righe orizzontali ─────────────────────────────────
            for (int s = 0; s <= SlotCount; s++)
            {
                int y = s * SlotH;
                bool isHour = s % 4 == 0;
                using var lp = new Pen(isHour ? CGridHour : CGridFaint, isHour ? 1f : 0.5f);
                g.DrawLine(lp, TimeColW, y, w, y);
            }

            // ── Colonne verticali ─────────────────────────────────
            using var vp = new Pen(CGridFaint);
            using var sep = new Pen(Color.Black, 2);
            g.DrawLine(new Pen(CGridHour), TimeColW - 1, 0, TimeColW - 1, TotalH);
            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                bool isSat = day.DayOfWeek == DayOfWeek.Saturday;
                bool isSun = day.DayOfWeek == DayOfWeek.Sunday;

                // Sab/Dom: linea grigia normale a sinistra (uguale agli altri giorni)
                // Solo il confine feriali→sab mantiene il pen scuro (sep) già disegnato
                // su DayLeft(sabato) nel loop precedente.
                // Qui usiamo vp per tutti: la separazione feriali/weekend è data
                // dalla linea a sinistra del sabato (primo weekend).
                if (isSat)
                    g.DrawLine(sep, DayLeft(d), 0, DayLeft(d), TotalH);        // confine ven→sab: nero
                else if (isSun)
                    g.DrawLine(vp, DayLeft(d), 0, DayLeft(d), TotalH);         // confine sab→dom: grigio
                else
                    g.DrawLine(vp, DayLeft(d) + DayColW - 1, 0, DayLeft(d) + DayColW - 1, TotalH);
            }

            // ── Linea ora corrente ────────────────────────────────
            DateTime now = DateTime.Now;
            if (now.Date >= _weekStart && now.Date < _weekStart.AddDays(7))
            {
                int d = (int)(now.Date - _weekStart).TotalDays;
                int nowY = TimeToY(now.TimeOfDay);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(new SolidBrush(CNowLine), DayLeft(d) - 5, nowY - 4, 8, 8);
                using var np = new Pen(CNowLine, 2);
                g.DrawLine(np, DayLeft(d), nowY, DayLeft(d) + DayColW, nowY);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }

            // ── Appuntamenti ──────────────────────────────────────
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                var dayApps = _allApps.Where(a => a.Start.Date == day.Date)
                                          .OrderBy(a => a.Start).ToList();
                if (dayApps.Count == 0) continue;

                var columns = ResolveColumns(dayApps);
                int maxCols = columns.Max(x => x.col) + 1;

                foreach (var (app, col) in columns)
                {
                    int yTop = TimeToY(app.Start.TimeOfDay) + 2;
                    int yBot = TimeToY(app.End.TimeOfDay) - 2;
                    int hPx = Math.Max(SlotH - 4, yBot - yTop);
                    int colW = (DayColW - 6) / maxCols;
                    int xPx = DayLeft(d) + 20 + col * colW;

                    DrawAppointment(g, app, new Rectangle(xPx, yTop, colW - 22, hPx), _scrollY, maxCols > 1);
                }
            }
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            // ── Ghost drag ────────────────────────────────────────
            if (_isDragging && _dragApp != null)
            {
                int dur = (int)(_dragApp.End - _dragApp.Start).TotalMinutes;
                int ghostH = Math.Max(SlotH - 4, dur / 15 * SlotH - 4);
                int ghostX = DayLeft(_dragCurrentD) + 20;
                int ghostW = DayColW - 30;

                // Blocco ghost semitrasparente
                using var ghostBg = new SolidBrush(Color.FromArgb(160, _dragApp.Color));
                g.FillRectangle(ghostBg, ghostX, _dragCurrentY + 2, ghostW, ghostH);
                using var ghostBorder = new Pen(Color.FromArgb(200, _dragApp.Color), 2);
                g.DrawRectangle(ghostBorder, ghostX, _dragCurrentY + 2, ghostW, ghostH);

                // Ora snappata
                TimeSpan snapped = FirstSlot.Add(TimeSpan.FromMinutes(_dragCurrentY / SlotH * 15));
                using var ghostFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                TextRenderer.DrawText(g,
                    $"{_weekStart.AddDays(_dragCurrentD):ddd}  {snapped.Hours:D2}:{snapped.Minutes:D2}",
                    ghostFont,
                    new Rectangle(ghostX + 6, _dragCurrentY + 2 - _scrollY, ghostW - 8, 20),
                    Color.White,
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

                // Linea orizzontale di destinazione
                using var snapLine = new Pen(Color.FromArgb(200, _dragApp.Color), 2);
                g.DrawLine(snapLine, DayLeft(_dragCurrentD), _dragCurrentY,
                    DayLeft(_dragCurrentD) + DayColW, _dragCurrentY);
            }

            g.ResetTransform();
        }

        private void DrawAppointment(Graphics g, Appointment app, Rectangle r, int scrollY, bool compact = false)
        {
            using var bg = new SolidBrush(app.Color);
            g.FillRectangle(bg, r);

            Color dark = Color.FromArgb(
                Math.Max(0, app.Color.R - 55),
                Math.Max(0, app.Color.G - 55),
                Math.Max(0, app.Color.B - 55));
            g.FillRectangle(new SolidBrush(dark), r.Left, r.Top, 4, r.Height);
            using var border = new Pen(dark);
            g.DrawRectangle(border, r);

            const int PadTop = 4;
            var ti = new Rectangle(r.Left + 8, r.Top + PadTop - scrollY, r.Width - 12, r.Height - PadTop);
            if (ti.Height < 8) return;

            string timeStr = $"{app.Start:HH:mm}–{app.End:HH:mm}";
            bool hasOp = !string.IsNullOrWhiteSpace(app.OperatorName);

            if (compact)
            {
                // Modalità sovrapposto: ora di partenza + operatore su 2 righe compatte
                const int Row1H = 20;
                const int Row2H = 17;
                using var tf = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                using var of = new Font("Segoe UI", 8.5f, FontStyle.Bold);

                if (ti.Height < Row1H)
                {
                    TextRenderer.DrawText(g, $"{app.Start:HH:mm}", tf,
                        new Rectangle(ti.Left, ti.Top, ti.Width, ti.Height),
                        Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                    return;
                }

                TextRenderer.DrawText(g, $"{app.Start:HH:mm}", tf,
                    new Rectangle(ti.Left, ti.Top, ti.Width, Row1H),
                    Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

                if (hasOp && ti.Height >= Row1H + Row2H)
                    TextRenderer.DrawText(g, app.OperatorName, of,
                        new Rectangle(ti.Left, ti.Top + Row1H, ti.Width, Row2H),
                        Color.FromArgb(220, 255, 255, 255), TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
            else
            {
                // Modalità normale: titolo + operatore/orario
                const int Row1H = 22;
                const int Row2H = 18;
                string row2 = hasOp ? $"{app.OperatorName}  {timeStr}" : timeStr;

                using var titleFont = new Font("Segoe UI", 10f, FontStyle.Bold);
                using var row2Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);

                if (ti.Height < Row1H)
                {
                    TextRenderer.DrawText(g, $"{app.Title}  {timeStr}", titleFont,
                        new Rectangle(ti.Left, ti.Top, ti.Width, ti.Height),
                        Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                    return;
                }

                TextRenderer.DrawText(g, app.Title, titleFont,
                    new Rectangle(ti.Left, ti.Top, ti.Width, Row1H),
                    Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

                if (ti.Height >= Row1H + Row2H)
                    TextRenderer.DrawText(g, row2, row2Font,
                        new Rectangle(ti.Left, ti.Top + Row1H, ti.Width, Row2H),
                        Color.FromArgb(220, 255, 255, 255), TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
        }


        // ============================================================
        // MOUSE sul canvas — solo doppio click
        // ============================================================
        private void OnCanvasMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            var app = HitTest(e.X, e.Y);
            if (app == null) return;

            _dragApp = app;
            _dragStartPt = new Point(e.X, e.Y);
            _dragOffsetY = (e.Y + _scrollY) - TimeToY(app.Start.TimeOfDay);
            _isDragging = false;
        }

        private void OnCanvasDoubleClick(object? sender, MouseEventArgs e)
        {
            if (e.X < TimeColW) return;
            int d = (e.X - TimeColW) / Math.Max(1, DayColW);
            if (d < 0 || d >= DayCount) return;

            // Se il doppio click cade su un appuntamento → modifica
            var app = HitTest(e.X, e.Y);
            if (app != null)
            {
                RequestEditAppointment?.Invoke(app);
                return;
            }

            // Altrimenti → nuovo appuntamento
            RequestNewAppointment?.Invoke(_weekStart.AddDays(d), YToSlot(e.Y + _scrollY));
        }


        // ============================================================
        // TOOLTIP CUSTOM (overlay panel, niente flickering)
        // ============================================================
        private void OnTipPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(_tipPanel.BackColor);

            // Bordo
            using var pen = new Pen(Color.FromArgb(180, 180, 120));
            g.DrawRectangle(pen, 0, 0, _tipPanel.Width - 1, _tipPanel.Height - 1);

            // Testo
            using var font = new Font("Segoe UI", 8.5f);
            TextRenderer.DrawText(g, _tooltipText, font,
                new Rectangle(6, 5, _tipPanel.Width - 12, _tipPanel.Height - 10),
                Color.FromArgb(30, 30, 30),
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.WordBreak);
        }

        private void ShowTip(string text, Point canvasPos)
        {
            bool textChanged = text != _tooltipText;
            _tooltipText = text;

            if (textChanged)
            {
                // Calcola dimensione necessaria
                using var font = new Font("Segoe UI", 8.5f);
                var size = TextRenderer.MeasureText(text, font,
                    new Size(260, 400),
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.WordBreak);
                _tipPanel.Size = new Size(size.Width + 16, size.Height + 14);
            }

            // Posiziona rispetto al canvas (coordinate del parent = questo UserControl)
            int px = _canvas.Left + canvasPos.X + 18;
            int py = _canvas.Top + canvasPos.Y + 14;

            // Evita uscita dai bordi
            if (px + _tipPanel.Width > Width) px = _canvas.Left + canvasPos.X - _tipPanel.Width - 4;
            if (py + _tipPanel.Height > Height) py = _canvas.Top + canvasPos.Y - _tipPanel.Height - 4;

            _tipPanel.Location = new Point(px, py);

            if (!_tipPanel.Visible)
            {
                _tipPanel.Visible = true;
                _tipPanel.BringToFront();
            }

            if (textChanged) _tipPanel.Invalidate();
        }

        private void HideTip()
        {
            if (_tipPanel.Visible)
                _tipPanel.Visible = false;
        }

        private void OnCanvasMouseMove(object? sender, MouseEventArgs e)
        {
            // ── Drag in corso ────────────────────────────────────
            if (_dragApp != null && e.Button == MouseButtons.Left)
            {
                int dx = Math.Abs(e.X - _dragStartPt.X);
                int dy = Math.Abs(e.Y - _dragStartPt.Y);

                if (!_isDragging && (dx > 5 || dy > 5))
                {
                    _isDragging = true;
                    _canvas.Cursor = Cursors.SizeAll;
                    HideTip();
                }

                if (_isDragging)
                {
                    // Calcola la nuova posizione arrotondata al quarto d'ora
                    int contentY = e.Y + _scrollY - _dragOffsetY;
                    int slot = Math.Clamp(contentY / SlotH, 0, SlotCount - 1);
                    _dragCurrentY = slot * SlotH;

                    int d = (e.X - TimeColW) / Math.Max(1, DayColW);
                    _dragCurrentD = Math.Clamp(d, 0, DayCount - 1);

                    _canvas.Invalidate();
                }
                return;
            }

            // ── Tooltip normale ──────────────────────────────────
            var app = HitTest(e.X, e.Y);

            if (app == null)
            {
                if (_tooltipApp != null) { _tooltipApp = null; HideTip(); }
                return;
            }

            string text;
            if (app != _tooltipApp)
            {
                _tooltipApp = app;
                string operatore = string.IsNullOrWhiteSpace(app.OperatorName) ? "–" : app.OperatorName;
                string servizio = string.IsNullOrWhiteSpace(app.ServiceName) ? "–" : app.ServiceName;
                string note = string.IsNullOrWhiteSpace(app.Notes) ? "" : $"\n    {app.Notes}";
                text =
                    $"{app.Title}\n" +
                    $"    {app.Start:HH:mm} – {app.End:HH:mm}  ({app.DurataMinuti} min)\n" +
                    $"    {app.ClientName}\n" +
                    $"OP: {operatore}\n" +
                    $"    {servizio}\n" +
                    $"    {app.Status}" +
                    note;
            }
            else
            {
                text = _tooltipText;
            }

            ShowTip(text, new Point(e.X, e.Y));
        }

        private void OnCanvasMouseLeave(object? sender, EventArgs e)
        {
            _tooltipApp = null;
            HideTip();
        }

        private void OnCanvasMouseUp(object? sender, MouseEventArgs e)
        {
            if (_dragApp == null) return;

            var app = _dragApp;
            bool wasDrag = _isDragging;

            // Reset stato drag
            _dragApp = null;
            _isDragging = false;
            _canvas.Cursor = Cursors.Default;
            _canvas.Invalidate();

            if (!wasDrag) return;

            // Calcola nuovi orari
            TimeSpan newStart = FirstSlot.Add(TimeSpan.FromMinutes(_dragCurrentY / SlotH * 15));
            TimeSpan dur = app.End - app.Start;
            TimeSpan newEnd = newStart + dur;
            DateTime newDay = _weekStart.AddDays(_dragCurrentD);

            DateTime newStartDt = newDay.Date + newStart;
            DateTime newEndDt = newDay.Date + newEnd;

            // Nessun cambiamento?
            if (newStartDt == app.Start) return;

            try
            {
                // Aggiorna nel DB tramite ModelAppuntamenti
                var updated = new Appointment
                {
                    Id = app.Id,
                    Title = app.Title,
                    ClientName = app.ClientName,
                    OperatorName = app.OperatorName,
                    ServiceId = app.ServiceId,
                    ServiceName = app.ServiceName,
                    Start = newStartDt,
                    End = newEndDt,
                    Status = app.Status,
                    Notes = app.Notes,
                    Color = app.Color,
                    Timestamp = app.Timestamp   // preserva il timestamp originale
                };

                ModelAppuntamenti.EditAppuntamento(updated.Id, updated);

                // Aggiorna la lista locale senza ricaricare dal DB
                int idx = _allApps.FindIndex(a => a.Id == app.Id);
                if (idx >= 0) _allApps[idx] = updated;

                _header.Invalidate();
                _canvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel salvataggio:\n{ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // LAYOUT HELPERS
        // ============================================================
        private static List<(Appointment app, int col)> ResolveColumns(List<Appointment> apps)
        {
            var result = new List<(Appointment, int)>();
            var colEnd = new List<DateTime>();
            foreach (var app in apps)
            {
                int col = colEnd.FindIndex(e => e <= app.Start);
                if (col < 0) { col = colEnd.Count; colEnd.Add(app.End); }
                else colEnd[col] = app.End;
                result.Add((app, col));
            }
            return result;
        }

        private static DateTime GetStartOfWeek(DateTime d)
        {
            int diff = (7 + (d.DayOfWeek - DayOfWeek.Monday)) % 7;
            return d.AddDays(-diff).Date;
        }

        protected override void OnResize(EventArgs e) { base.OnResize(e); DoLayout(); }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _nowTimer.Dispose();
            base.Dispose(disposing);
        }
    }
}