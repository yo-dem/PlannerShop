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

            _vscroll = new VScrollBar { SmallChange = SlotH / 2, LargeChange = SlotH * 4 };
            _vscroll.Scroll += (_, e) => SetScroll(e.NewValue);

            Controls.Add(_canvas);
            Controls.Add(_vscroll);
            Controls.Add(_header);
            Controls.Add(_timebar);
            _header.BringToFront();
            _timebar.BringToFront();

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
            int colIdx = (canvasX - DayLeft(d) - 3) / Math.Max(1, colW);

            foreach (var (app, col) in columns)
            {
                if (col != colIdx) continue;
                int yTop = TimeToY(app.Start.TimeOfDay);
                int yBot = TimeToY(app.End.TimeOfDay);
                if (contentY >= yTop && contentY <= yBot)
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
            using var sfNorm = new Font("Segoe UI", 8f);
            using var sfWknd = new Font("Segoe UI", 8f, FontStyle.Italic);

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
                Color dc = isWeekend ? CWeekend : CSubText;
                int half = HeaderH / 2;

                TextRenderer.DrawText(g,
                    _it.TextInfo.ToTitleCase(day.ToString("dddd", _it)), bf,
                    new Rectangle(x + 5, 2, w - 22, half),
                    tc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                TextRenderer.DrawText(g,
                    day.ToString("d MMM", _it), isWeekend ? sfWknd : sfNorm,
                    new Rectangle(x + 5, half, w - 10, half - 4),
                    dc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                if (_allApps.Any(a => a.Start.Date == day.Date))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(dotBrush, x + w - 13, 5, 8, 8);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                }

                if (isToday) g.DrawLine(todayPen, x, HeaderH - 2, x + w - 1, HeaderH - 2);
                if (isSat) g.DrawLine(sepPen, x, 0, x, HeaderH);
                else if (d < DayCount - 1)
                    g.DrawLine(colPen, x + w - 1, 0, x + w - 1, HeaderH);
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
            using var font = new Font("Segoe UI", 8f, FontStyle.Bold);
            using var linePen = new Pen(CGridHour);

            g.DrawLine(borderPen, TimeColW - 1, 0, TimeColW - 1, _timebar.Height);

            for (int s = 0; s < SlotCount; s += 4)
            {
                int yPanel = s * SlotH - _scrollY;
                if (yPanel + SlotH < 0 || yPanel > _timebar.Height) continue;

                TimeSpan t = FirstSlot.Add(TimeSpan.FromMinutes(s * 15));
                TextRenderer.DrawText(g, $"{t.Hours:D2}:{t.Minutes:D2}", font,
                    new Rectangle(0, yPanel, TimeColW - 6, SlotH),
                    CText,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

                g.DrawLine(linePen, 4, yPanel, TimeColW - 8, yPanel);
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
                if (day.DayOfWeek == DayOfWeek.Saturday)
                    g.DrawLine(sep, DayLeft(d), 0, DayLeft(d), TotalH);
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
                    int xPx = DayLeft(d) + 3 + col * colW;

                    DrawAppointment(g, app, new Rectangle(xPx, yTop, colW - 2, hPx), _scrollY);
                }
            }
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            g.ResetTransform();
        }

        private void DrawAppointment(Graphics g, Appointment app, Rectangle r, int scrollY)
        {
            // Sfondo
            using var bg = new SolidBrush(app.Color);
            g.FillRectangle(bg, r);

            // Bordo sinistro spesso
            Color dark = Color.FromArgb(
                Math.Max(0, app.Color.R - 55),
                Math.Max(0, app.Color.G - 55),
                Math.Max(0, app.Color.B - 55));
            g.FillRectangle(new SolidBrush(dark), r.Left, r.Top, 4, r.Height);
            using var border = new Pen(dark);
            g.DrawRectangle(border, r);

            var inner = new Rectangle(r.Left + 8, r.Top + 4, r.Width - 12, r.Height - 8);
            if (inner.Height < 10) return;

            // TextRenderer.DrawText usa GDI e ignora TranslateTransform di GDI+.
            // Compensiamo sottraendo scrollY dalle coordinate Y del rettangolo testo,
            // così il testo appare esattamente sopra il rettangolo colorato.
            var ti = new Rectangle(inner.Left, inner.Top - scrollY, inner.Width, inner.Height);

            bool hasOp = !string.IsNullOrWhiteSpace(app.OperatorName);
            string timeStr = $"{app.Start:HH:mm} – {app.End:HH:mm}";

            if (ti.Height < 28)
            {
                using var f = new Font("Segoe UI", 7.5f, FontStyle.Bold);
                TextRenderer.DrawText(g, $"{app.Start:HH:mm}  {app.Title}", f,
                    new Rectangle(ti.Left, ti.Top, ti.Width, ti.Height),
                    Color.White, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                return;
            }

            int titleH = Math.Min(22, (int)(ti.Height * 0.42));
            int operH = hasOp ? Math.Min(18, (int)(ti.Height * 0.30)) : 0;
            int timeH = Math.Min(16, ti.Height - titleH - operH);

            using var tf = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            TextRenderer.DrawText(g, app.Title, tf,
                new Rectangle(ti.Left, ti.Top, ti.Width, titleH),
                Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

            if (hasOp && operH > 0)
            {
                using var of2 = new Font("Segoe UI", 7.5f, FontStyle.Bold);
                TextRenderer.DrawText(g, app.OperatorName, of2,
                    new Rectangle(ti.Left, ti.Top + titleH, ti.Width, operH),
                    Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }

            if (timeH >= 10)
            {
                using var tmf = new Font("Segoe UI", 7f);
                TextRenderer.DrawText(g, timeStr, tmf,
                    new Rectangle(ti.Left, ti.Top + titleH + operH, ti.Width, timeH),
                    Color.FromArgb(210, 255, 255, 255),
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
        }


        // ============================================================
        // MOUSE sul canvas
        // ============================================================
        private void OnCanvasMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                var app = HitTest(e.X, e.Y);
                if (app != null) RequestEditAppointment?.Invoke(app);
            }
        }

        private void OnCanvasDoubleClick(object? sender, MouseEventArgs e)
        {
            var app = HitTest(e.X, e.Y);
            if (app != null) { RequestEditAppointment?.Invoke(app); return; }

            if (e.X < TimeColW) return;
            int d = (e.X - TimeColW) / Math.Max(1, DayColW);
            if (d < 0 || d >= DayCount) return;
            RequestNewAppointment?.Invoke(_weekStart.AddDays(d), YToSlot(e.Y + _scrollY));
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