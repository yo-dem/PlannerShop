using PlannerShop.Data;
using PlannerShop.Forms.Agenda.Forms.Cruds;
using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    // ============================================================
    // PANEL DOPPIO BUFFER
    // ============================================================
    internal class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            UpdateStyles();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Previene flicker / accumulo
        }
    }

    // ============================================================
    // BLOCCO SINGOLO APPUNTAMENTO
    // ============================================================
    internal class AppointmentBlock : Panel
    {
        public readonly Appointment App;
        public int AbsoluteTop;   // Y nell'area di contenuto (senza scroll)

        public AppointmentBlock(Appointment app)
        {
            App = app;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint, true);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Sfondo
            using var bgBrush = new SolidBrush(App.Color);
            g.FillRectangle(bgBrush, rect);

            // Bordo sinistro spesso stile Google Calendar
            Color dark = Color.FromArgb(
                Math.Max(0, App.Color.R - 55),
                Math.Max(0, App.Color.G - 55),
                Math.Max(0, App.Color.B - 55));
            g.FillRectangle(new SolidBrush(dark), 0, 0, 4, Height);
            using var bp = new Pen(dark);
            g.DrawRectangle(bp, rect);

            // Testo
            var inner = new Rectangle(8, 4, Width - 12, Height - 8);
            if (inner.Height < 10) return;

            bool hasOp = !string.IsNullOrWhiteSpace(App.OperatorName);
            string timeStr = $"{App.Start:HH:mm} – {App.End:HH:mm}";

            if (inner.Height < 28)
            {
                using var f = new Font("Segoe UI", 7.5f, FontStyle.Bold);
                TextRenderer.DrawText(g, $"{App.Start:HH:mm}  {App.Title}", f, inner,
                    Color.White,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                return;
            }

            int titleH = Math.Min(22, (int)(inner.Height * 0.42));
            int operH = hasOp ? Math.Min(18, (int)(inner.Height * 0.30)) : 0;
            int timeH = Math.Min(16, inner.Height - titleH - operH);
            int y0 = inner.Top + 1;

            using var tf = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            TextRenderer.DrawText(g, App.Title, tf,
                new Rectangle(inner.Left, y0, inner.Width, titleH),
                Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

            if (hasOp && operH > 0)
            {
                using var of2 = new Font("Segoe UI", 7.5f, FontStyle.Bold);
                TextRenderer.DrawText(g, App.OperatorName, of2,
                    new Rectangle(inner.Left, y0 + titleH, inner.Width, operH),
                    Color.White, TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }

            if (timeH >= 10 && y0 + titleH + operH + timeH <= inner.Bottom + 4)
            {
                using var tmf = new Font("Segoe UI", 7f);
                TextRenderer.DrawText(g, timeStr, tmf,
                    new Rectangle(inner.Left, y0 + titleH + operH, inner.Width, timeH),
                    Color.FromArgb(210, 255, 255, 255),
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
            g.ResetTransform();
        }
    }


    // ============================================================
    // CANVAS PRINCIPALE AGENDA
    // ============================================================
    internal class AgendaCanvasPanel : UserControl
    {
        // ── Costanti layout ──────────────────────────────────────
        private const int TimeColW = 68;   // larghezza colonna orari
        private const int HeaderH = 60;   // altezza header giorni
        private const int SlotH = 50;   // altezza slot 15 min
        private const int DayCount = 7;
        private const int SlotCount = 14 * 4; // 08:00-22:00 = 56 slot

        private static readonly TimeSpan FirstSlot = new(8, 0, 0);

        // ── Colori ──────────────────────────────────────────────
        private static readonly Color CGridFaint = Color.FromArgb(225, 225, 225);
        private static readonly Color CGridHour = Color.FromArgb(180, 180, 180);
        private static readonly Color CSideBg = Color.FromArgb(250, 250, 250);
        private static readonly Color CHeaderBg = Color.White;
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
        private readonly List<AppointmentBlock> _blocks = [];

        // ── Pannelli interni ─────────────────────────────────────
        private readonly BufferedPanel _header;   // header fisso in cima
        private readonly BufferedPanel _content;  // area scroll con griglia
        private readonly BufferedPanel _timebar;  // overlay colonna ore a sinistra

        private readonly System.Windows.Forms.Timer _nowTimer;

        // ── Callback ─────────────────────────────────────────────
        public event Action<DateTime, TimeSpan>? RequestNewAppointment;
        public event Action<Appointment>? RequestEditAppointment;

        // ============================================================
        // COSTRUTTORE
        // ============================================================
        public AgendaCanvasPanel()
        {
            _weekStart = GetStartOfWeek(DateTime.Today);

            _header = new BufferedPanel { Height = HeaderH, BackColor = CHeaderBg };
            _header.Paint += OnHeaderPaint;

            _content = new BufferedPanel
            {
                AutoScroll = true,
                BackColor = Color.White
            };
            _content.Paint += OnContentPaint;
            _content.MouseDoubleClick += OnContentDoubleClick;
            _content.Scroll += (_, _) =>
            {
                _content.Invalidate();
                _timebar.Invalidate();
            };

            _timebar = new BufferedPanel { Width = TimeColW, BackColor = CSideBg };
            _timebar.Paint += OnTimebarPaint;

            // Ordine di aggiunta: content (fondo) → header → timebar (sopra)
            Controls.Add(_content);
            Controls.Add(_header);
            Controls.Add(_timebar);

            _nowTimer = new System.Windows.Forms.Timer { Interval = 60_000 };
            _nowTimer.Tick += (_, _) => { _content.Invalidate(); };
            _nowTimer.Start();

            Resize += (_, _) => DoLayout();
        }


        // ============================================================
        // API
        // ============================================================
        public void SetWeek(DateTime weekStart)
        {
            _weekStart = GetStartOfWeek(weekStart);
            RebuildBlocks();
            Invalidate(true);
        }

        public void LoadAppointments(List<Appointment> apps)
        {
            _allApps = apps;
            RebuildBlocks();
            _header.Invalidate();
            _content.Invalidate();
        }

        public void ScrollToCurrentTime()
        {
            int y = TimeToY(DateTime.Now.TimeOfDay) - _content.ClientSize.Height / 3;
            _content.AutoScrollPosition = new Point(0, Math.Max(0, y));
            SyncOverlays();
        }


        // ============================================================
        // LAYOUT
        // ============================================================
        private void DoLayout()
        {
            _header.SetBounds(0, 0, Width, HeaderH);
            _content.SetBounds(0, HeaderH, Width, Height - HeaderH);
            _content.AutoScrollMinSize = new Size(1, SlotCount * SlotH + 20);
            SyncOverlays();
            RebuildBlocks();
        }

        // Il timebar è un overlay fisso sopra la colonna sinistra del _content
        // Si aggiorna verticalmente in sync con lo scroll
        private void SyncOverlays()
        {
            _timebar.SetBounds(0, HeaderH, TimeColW, Height - HeaderH);
            _timebar.Invalidate();
        }

        private int DayColW => Math.Max(1, (_content.ClientSize.Width - TimeColW) / DayCount);
        private int DayLeft(int d) => TimeColW + d * DayColW;

        private int TimeToY(TimeSpan t) =>
            (int)((t - FirstSlot).TotalMinutes / 15.0 * SlotH);

        private TimeSpan YToSlot(int y)
        {
            int slot = Math.Max(0, Math.Min(y / SlotH, SlotCount - 1));
            return FirstSlot.Add(TimeSpan.FromMinutes(slot * 15));
        }


        // ============================================================
        // BLOCCHI APPUNTAMENTO
        // ============================================================
        private void RebuildBlocks()
        {
            foreach (var b in _blocks) { _content.Controls.Remove(b); b.Dispose(); }
            _blocks.Clear();

            if (_content.ClientSize.Width <= TimeColW || DayColW <= 0) return;

            int scrollY = -_content.AutoScrollPosition.Y;

            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                var dayApps = _allApps
                    .Where(a => a.Start.Date == day.Date)
                    .OrderBy(a => a.Start)
                    .ToList();
                if (dayApps.Count == 0) continue;

                var columns = ResolveColumns(dayApps);
                int maxCols = columns.Count > 0 ? columns.Max(x => x.col) + 1 : 1;

                foreach (var (app, col) in columns)
                {
                    int yAbs = TimeToY(app.Start.TimeOfDay);
                    int hPx = Math.Max(SlotH - 4,
                                   TimeToY(app.End.TimeOfDay) - yAbs - 4);
                    int colW = (DayColW - 6) / maxCols;
                    int xPx = DayLeft(d) + 3 + col * colW;

                    var block = new AppointmentBlock(app)
                    {
                        AbsoluteTop = yAbs,
                        Left = xPx,
                        Top = yAbs - scrollY,
                        Width = colW - 2,
                        Height = hPx
                    };
                    block.Click += (_, _) => RequestEditAppointment?.Invoke(app);
                    block.DoubleClick += (_, _) => RequestEditAppointment?.Invoke(app);

                    _content.Controls.Add(block);
                    block.BringToFront();
                    _blocks.Add(block);
                }
            }
        }

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


        // ============================================================
        // PAINT — HEADER
        // ============================================================
        private void OnHeaderPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(CHeaderBg);

            // Cella colonna orari
            g.FillRectangle(new SolidBrush(CSideBg), 0, 0, TimeColW, HeaderH);
            using var sidePen = new Pen(CGridHour);
            using var sepPen = new Pen(Color.Black, 2);          // separatore feriali/festivi
            using var colPen = new Pen(Color.FromArgb(200, 200, 200));
            using var todayPen = new Pen(CTodayLine, 3);
            using var dotBrush = new SolidBrush(CTodayLine);
            using var bf = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            using var sfNorm = new Font("Segoe UI", 8f, FontStyle.Regular);
            using var sfWknd = new Font("Segoe UI", 8f, FontStyle.Italic);

            g.DrawLine(sidePen, TimeColW - 1, 0, TimeColW - 1, HeaderH);

            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                bool isToday = day.Date == DateTime.Today;
                bool isWeekend = day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
                bool isSaturday = day.DayOfWeek == DayOfWeek.Saturday;
                int x = DayLeft(d), w = DayColW;

                // Sfondo cella
                if (isToday)
                    g.FillRectangle(new SolidBrush(CTodayBg), x, 0, w, HeaderH);
                else if (isWeekend)
                    g.FillRectangle(new SolidBrush(CWeekendBg), x, 0, w, HeaderH);

                Color tc = isWeekend ? CWeekend : CText;
                Color dc = isWeekend ? CWeekend : CSubText;
                string name = _it.TextInfo.ToTitleCase(day.ToString("dddd", _it));
                string date = day.ToString("d MMM", _it);
                int half = HeaderH / 2;

                TextRenderer.DrawText(g, name, bf,
                    new Rectangle(x + 5, 2, w - 22, half),
                    tc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                TextRenderer.DrawText(g, date, isWeekend ? sfWknd : sfNorm,
                    new Rectangle(x + 5, half, w - 10, half - 4),
                    dc, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // Pallino appuntamenti
                if (_allApps.Any(a => a.Start.Date == day.Date))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(dotBrush, x + w - 13, 5, 8, 8);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                }

                // Sottolineatura oggi
                if (isToday)
                    g.DrawLine(todayPen, x, HeaderH - 2, x + w - 1, HeaderH - 2);

                // Separatore: linea NERA spessa prima del sabato, grigia per gli altri
                if (isSaturday)
                    g.DrawLine(sepPen, x, 0, x, HeaderH);          // bordo sinistro sabato
                else if (d < DayCount - 1)
                    g.DrawLine(colPen, x + w - 1, 0, x + w - 1, HeaderH); // bordo destro normali
            }

            // Bordo inferiore
            using var hbPen = new Pen(CGridHour);
            g.DrawLine(hbPen, 0, HeaderH - 1, _header.Width, HeaderH - 1);
        }


        // ============================================================
        // PAINT — GRIGLIA CONTENUTO
        // ============================================================
        private void OnContentPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            // Scroll reale
            int scrollY = -_content.AutoScrollPosition.Y;

            // Trasla tutto il mondo
            g.TranslateTransform(0, -scrollY);

            int totalH = SlotCount * SlotH;

            g.Clear(Color.White);

            // Sfondo colonna orari (sotto il timebar overlay)
            g.FillRectangle(new SolidBrush(CSideBg), 0, 0, TimeColW, totalH);

            // Sfondi colonne
            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                if (day.Date == DateTime.Today)
                    g.FillRectangle(new SolidBrush(CTodayBg), DayLeft(d), 0, DayColW, totalH);
                else if (day.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(12, 200, 50, 50)),
                        DayLeft(d), 0, DayColW, totalH);
            }

            // Linee orizzontali
            for (int s = 0; s <= SlotCount; s++)
            {
                int y = s * SlotH;
                bool isHour = s % 4 == 0;
                using var lp = new Pen(isHour ? CGridHour : CGridFaint, isHour ? 1f : 0.5f);
                g.DrawLine(lp, TimeColW, y, _content.ClientSize.Width, y);
            }

            // Linee verticali + separatore feriali/festivi
            using var vp = new Pen(CGridFaint);
            using var sep = new Pen(Color.Black, 2);

            g.DrawLine(new Pen(CGridHour), TimeColW - 1, 0, TimeColW - 1, totalH);

            for (int d = 0; d < DayCount; d++)
            {
                DateTime day = _weekStart.AddDays(d);
                if (day.DayOfWeek == DayOfWeek.Saturday)
                    g.DrawLine(sep, DayLeft(d), 0, DayLeft(d), totalH);
                else
                    g.DrawLine(vp, DayLeft(d) + DayColW - 1, 0, DayLeft(d) + DayColW - 1, totalH);
            }

            // Linea ora corrente
            DateTime now = DateTime.Now;
            if (now.Date >= _weekStart && now.Date < _weekStart.AddDays(7))
            {
                int d = (int)(now.Date - _weekStart).TotalDays;
                int nowY = TimeToY(now.TimeOfDay);
                int x1 = DayLeft(d), x2 = x1 + DayColW;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(new SolidBrush(CNowLine), x1 - 5, nowY - 4, 8, 8);
                using var np = new Pen(CNowLine, 2);
                g.DrawLine(np, x1, nowY, x2, nowY);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }
            g.ResetTransform();
        }


        // ============================================================
        // PAINT — COLONNA ORE (overlay fisso a sinistra)
        // ============================================================
        private void OnTimebarPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            int scrollY = -_content.AutoScrollPosition.Y;

            g.TranslateTransform(0, -scrollY);

            g.Clear(CSideBg);

            using var borderPen = new Pen(CGridHour);
            g.DrawLine(borderPen, TimeColW - 1, scrollY, TimeColW - 1, scrollY + _timebar.Height);

            using var font = new Font("Segoe UI", 8f, FontStyle.Bold);

            for (int s = 0; s < SlotCount; s += 4)
            {
                int y = s * SlotH;

                TimeSpan time = FirstSlot.Add(TimeSpan.FromMinutes(s * 15));
                string label = time.ToString(@"HH\:mm");

                TextRenderer.DrawText(
                    g,
                    label,
                    font,
                    new Rectangle(0, y, TimeColW - 6, SlotH),
                    CText,
                    TextFormatFlags.Right |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.NoPadding
                );

                using var pen = new Pen(CGridHour);
                g.DrawLine(pen, 6, y, TimeColW - 10, y);
            }

            g.ResetTransform();
        }


        // ============================================================
        // DOPPIO CLICK → nuovo appuntamento
        // ============================================================
        private void OnContentDoubleClick(object? sender, MouseEventArgs e)
        {
            if (e.X < TimeColW) return;
            int d = (e.X - TimeColW) / Math.Max(1, DayColW);
            if (d < 0 || d >= DayCount) return;
            int contentY = e.Y - _content.AutoScrollPosition.Y;
            RequestNewAppointment?.Invoke(_weekStart.AddDays(d), YToSlot(contentY));
        }

        // ============================================================
        // HELPER
        // ============================================================
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