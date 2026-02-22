using PlannerShop.Data;
using PlannerShop.Forms.Agenda.Forms.Cruds;
using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    public partial class AgendaDgvForm : Form
    {
        // ============================================================
        // STATO
        // ============================================================

        private List<TimeSlotRow> TSRows = [];
        private DateTime weekStart;
        private readonly CultureInfo culture = new("it-IT");

        // Solo slot di INIZIO: (data, slotArrotondato) → lista appuntamenti
        private readonly Dictionary<(DateTime date, TimeSpan time), List<Appointment>> appointments = [];

        private System.Windows.Forms.Timer _clickTimer = null!;
        private DataGridViewCellMouseEventArgs? _lastClick;
        private bool _doubleClick;

        private const int RowH = 50; // altezza fissa di ogni riga in px


        // ============================================================
        // COSTRUTTORE
        // ============================================================

        public AgendaDgvForm()
        {
            InitializeComponent();
            weekStart = GetStartOfWeek(DateTime.Today);
            BuildDefaultRows();
            SetupGrid();
            UpdateWeekUI();
            HookGridEvents();
        }

        private void HookGridEvents()
        {
            dgvData.SelectionChanged += dgvData_SelectionChanged;
            dgvData.CellPainting += dgvData_CellPainting;
            dgvData.CellMouseDown += dgvData_CellMouseDown;

            _clickTimer = new System.Windows.Forms.Timer();
            _clickTimer.Interval = 250;
            _clickTimer.Tick += ClickTimer_Tick;
        }


        // ============================================================
        // LOGICA TEMPORALE
        // ============================================================

        private static DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-diff).Date;
        }

        private void BuildDefaultRows()
        {
            TSRows.Clear();
            for (int hour = 8; hour <= 21; hour++)
            {
                TSRows.Add(new TimeSlotRow { Start = new(hour, 0, 0), End = new(hour, 15, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 15, 0), End = new(hour, 30, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 30, 0), End = new(hour, 45, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 45, 0), End = new(hour + 1, 0, 0), HourGroup = hour });
            }
        }


        // ============================================================
        // SETUP GRIGLIA
        // ============================================================

        private void SetupGrid()
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ReadOnly = true;
            dgvData.MultiSelect = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvData.RowHeadersVisible = false;
            dgvData.AutoGenerateColumns = false;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvData.GridColor = Color.FromArgb(210, 210, 210);
            dgvData.Font = new Font("Segoe UI", 10f);
            dgvData.RowTemplate.Height = RowH;
            dgvData.RowTemplate.MinimumHeight = RowH;
            dgvData.ColumnHeadersHeight = 50;
            dgvData.DefaultCellStyle.BackColor = Color.White;
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230);

            dgvData.Columns.Clear();
            dgvData.Columns.Add(CreateOraColumn());
            for (int i = 0; i < 7; i++)
                dgvData.Columns.Add(CreateDayColumn());

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;
            }
        }

        private static DataGridViewTextBoxColumn CreateOraColumn()
        {
            var col = new DataGridViewTextBoxColumn { Name = "Ora", HeaderText = "", Width = 80 };
            col.DefaultCellStyle.BackColor = SystemColors.Control;
            col.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
            col.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            col.HeaderCell.Style.BackColor = SystemColors.Control;
            col.HeaderCell.Style.SelectionBackColor = SystemColors.Control;
            return col;
        }

        private static DataGridViewTextBoxColumn CreateDayColumn() =>
            new() { AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };


        // ============================================================
        // AGGIORNAMENTO UI
        // ============================================================

        private void UpdateWeekUI()
        {
            UpdateWeekLabelText();
            UpdateGridHeaders();
            LoadAppuntamentiFromDB();
            RebuildGrid();
        }

        private void UpdateWeekLabelText()
        {
            DateTime end = weekStart.AddDays(6);
            string text = weekStart.Month == end.Month
                ? $"{weekStart.Day} – {end.Day} {weekStart:MMMM yyyy}"
                : $"{weekStart:dd MMM} – {end:dd MMM yyyy}";
            lblTimeSlot.Text = culture.TextInfo.ToTitleCase(text);
        }

        private void UpdateGridHeaders()
        {
            for (int i = 0; i < 7; i++)
            {
                DateTime day = weekStart.AddDays(i);
                var col = dgvData.Columns[i + 1];
                col.Name = day.ToString("yyyyMMdd");
                col.HeaderText = $"{culture.TextInfo.ToTitleCase(day.ToString("dddd"))}\n" +
                                 $"{culture.TextInfo.ToTitleCase(day.ToString("d MMMM", culture))}";
            }
        }


        // ============================================================
        // CARICAMENTO DB  (solo slot di inizio)
        // ============================================================

        private void LoadAppuntamentiFromDB()
        {
            appointments.Clear();
            try
            {
                var dt = ModelAppuntamenti.GetAppuntamentiBySettimana(weekStart);
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    var app = ModelAppuntamenti.RowToAppointment(row);
                    var key = (app.Start.Date, RoundToSlot(app.Start.TimeOfDay));
                    if (!appointments.TryGetValue(key, out var list))
                        appointments[key] = list = [];
                    list.Add(app);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Agenda] {ex.Message}");
            }
        }

        private static TimeSpan RoundToSlot(TimeSpan t) =>
            new(t.Hours, (t.Minutes / 15) * 15, 0);

        private bool HasAppointmentsOnDay(int colIndex)
        {
            if (!DateTime.TryParseExact(dgvData.Columns[colIndex].Name, "yyyyMMdd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var d)) return false;
            return appointments.Keys.Any(k => k.date == d.Date);
        }


        // ============================================================
        // RICOSTRUZIONE RIGHE  (tutte fisse a RowH)
        // ============================================================

        private void RebuildGrid()
        {
            int scroll = dgvData.FirstDisplayedScrollingRowIndex;

            dgvData.SuspendLayout();
            dgvData.Rows.Clear();

            foreach (var slot in TSRows.OrderBy(r => r.Start))
            {
                int ri = dgvData.Rows.Add();
                var row = dgvData.Rows[ri];
                row.Cells["Ora"].Value = slot.Start.ToString(@"hh\:mm");
                row.Height = RowH;
                row.MinimumHeight = RowH;
                bool isHour = slot.Start.Minutes == 0;
                row.DefaultCellStyle.Font = isHour ? new Font(dgvData.Font, FontStyle.Bold) : dgvData.Font;
                row.DefaultCellStyle.Alignment = isHour
                    ? DataGridViewContentAlignment.MiddleLeft
                    : DataGridViewContentAlignment.MiddleRight;

                // Tag = lista appuntamenti che iniziano in questo slot (per tutti i giorni)
                // Il CellPainting non usa il Tag per i blocchi lunghi, ma lo usiamo per i click
                for (int d = 0; d < 7; d++)
                {
                    DateTime day = weekStart.AddDays(d);
                    var key = (day, slot.Start);
                    if (appointments.TryGetValue(key, out var list))
                        row.Cells[d + 1].Tag = list;
                }
            }

            dgvData.ResumeLayout();

            if (scroll >= 0 && scroll < dgvData.Rows.Count)
                dgvData.FirstDisplayedScrollingRowIndex = scroll;

            dgvData.Invalidate();
        }


        // ============================================================
        // HELPER COORDINATE
        // ============================================================

        /// <summary>
        /// Dato un colIndex e un orario, restituisce la Y assoluta
        /// (relativa all'area di disegno della DGV, escluso header)
        /// del bordo superiore della riga corrispondente a slotTime.
        /// </summary>
        private int GetRowTop(TimeSpan slotTime)
        {
            int y = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (TimeSpan.TryParse(row.Cells["Ora"].Value?.ToString(), out var t) && t == slotTime)
                    return y;
                y += row.Height;
            }
            return y;
        }

        /// <summary>
        /// Indice di riga corrispondente a slotTime, -1 se non trovato.
        /// </summary>
        private int GetRowIndex(TimeSpan slotTime)
        {
            for (int r = 0; r < dgvData.Rows.Count; r++)
                if (TimeSpan.TryParse(dgvData.Rows[r].Cells["Ora"].Value?.ToString(), out var t) && t == slotTime)
                    return r;
            return -1;
        }

        /// <summary>
        /// Converte pixel-Y (relativa alla cella, non alla form) in appuntamento
        /// del blocco corrispondente, tenendo conto di più appuntamenti sovrapposti in colonna.
        /// colX è la X del click dentro la cella, usata per disambiguare colonne affiancate.
        /// </summary>
        private Appointment? HitTestAppointment(int rowIndex, int colIndex, int localY)
        {
            if (!TimeSpan.TryParse(dgvData.Rows[rowIndex].Cells["Ora"].Value?.ToString(), out var slotTime))
                return null;

            DateTime day = GetDateFromColumn(colIndex);
            var key = (day, slotTime);
            if (!appointments.TryGetValue(key, out var list) || list.Count == 0)
                return null;

            // Calcola le colonne affiancate come nel rendering
            int colCount = list.Count;
            int cellW = dgvData.Columns[colIndex].Width;
            int blockW = colCount > 0 ? (cellW - 4) / colCount : cellW - 4;

            int col = Math.Min(localY < 0 ? 0 : localY / Math.Max(1, blockW), colCount - 1);
            // localY qui è Y nella cella, non X — per l'hit test verticale usiamo solo l'indice
            // di colonna basato sulla X del click (passato come localY per semplicità)
            // Reinterpretazione corretta: localX viene passato come localY dal chiamante
            int appointmentIndex = Math.Min(col, colCount - 1);
            return list.Count > appointmentIndex ? list[appointmentIndex] : null;
        }


        // ============================================================
        // CELL PAINTING
        // ============================================================

        private void dgvData_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            // ── HEADER ROW ───────────────────────────────────────────
            if (e.RowIndex == -1)
            {
                PaintHeader(e);
                return;
            }

            // ── COLONNA ORA ──────────────────────────────────────────
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Handled = true;
                return;
            }

            // ── CELLE GIORNO ─────────────────────────────────────────
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                // Sfondo + griglia normali
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background |
                                      DataGridViewPaintParts.Border |
                                      DataGridViewPaintParts.SelectionBackground);
                e.Handled = true;

                // Bordo sinistro spesso per sabato
                if (IsSaturdayColumn(e.ColumnIndex))
                {
                    using var sp = new Pen(Color.FromArgb(100, 100, 100), 1);
                    e.Graphics!.DrawLine(sp, e.CellBounds.Left, e.CellBounds.Top,
                                            e.CellBounds.Left, e.CellBounds.Bottom);
                }

                // Disegna gli appuntamenti che INIZIANO in questo slot
                if (!TimeSpan.TryParse(dgvData.Rows[e.RowIndex].Cells["Ora"].Value?.ToString(),
                        out var slotTime)) return;

                DateTime day = GetDateFromColumn(e.ColumnIndex);
                var key = (day, slotTime);
                if (!appointments.TryGetValue(key, out var list) || list.Count == 0) return;

                // Clip al solo rettangolo della cella corrente per evitare
                // che il blocco sforante invada celle di altre colonne
                var clip = e.Graphics!.Clip;
                e.Graphics.SetClip(new Rectangle(
                    e.CellBounds.Left,
                    e.CellBounds.Top,
                    e.CellBounds.Width,
                    dgvData.Height   // lascia sforare verso il basso liberamente
                ));

                int cellLeft = e.CellBounds.Left;
                int cellW = e.CellBounds.Width;
                int padding = 2;
                int spacing = 2;
                int count = list.Count;

                // Appuntamenti affiancati se più di uno nello stesso slot (stile Google Cal)
                int blockW = (cellW - padding * 2 - spacing * (count - 1)) / count;

                for (int i = 0; i < count; i++)
                {
                    var app = list[i];

                    // Altezza del blocco = durata in minuti / 15 * RowH
                    int durationMin = (int)(app.End - app.Start).TotalMinutes;
                    int blockH = (int)Math.Ceiling(durationMin / 15.0) * RowH - 2;
                    blockH = Math.Max(blockH, RowH - 2); // minimo una riga

                    int blockLeft = cellLeft + padding + i * (blockW + spacing);
                    int blockTop = e.CellBounds.Top + 1;

                    var rect = new Rectangle(blockLeft, blockTop, blockW, blockH);
                    DrawAppointmentBlock(e.Graphics, app, rect);
                }

                e.Graphics.Clip = clip;
            }
        }

        private void PaintHeader(DataGridViewCellPaintingEventArgs e)
        {
            using var backBrush = new SolidBrush(SystemColors.Control);
            e.Graphics!.FillRectangle(backBrush, e.CellBounds);

            using var pen = new Pen(Color.FromArgb(210, 210, 210));
            e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top);
            e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);

            if (e.ColumnIndex == 0) { e.Handled = true; return; }

            string? text = e.FormattedValue?.ToString();
            if (!string.IsNullOrEmpty(text))
            {
                var lines = text.Split('\n');
                string dayName = lines[0];
                string dayDate = lines.Length > 1 ? lines[1] : "";
                int lh = e.CellBounds.Height / 2;

                DayOfWeek? dow = null;
                if (DateTime.TryParseExact(dgvData.Columns[e.ColumnIndex].Name, "yyyyMMdd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var colDate))
                    dow = colDate.DayOfWeek;

                bool isWeekend = dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday;
                Color textColor = isWeekend ? Color.Red : Color.Black;

                Font dayFont = new Font(e.CellStyle?.Font ?? dgvData.Font, FontStyle.Bold);
                Font dateFont = new Font(e.CellStyle?.Font ?? dgvData.Font,
                    isWeekend || IsTodayColumn(e.ColumnIndex)
                        ? FontStyle.Regular | FontStyle.Italic
                        : FontStyle.Regular);

                int dotArea = 16;
                int textW = e.CellBounds.Width - 8 - dotArea;

                TextRenderer.DrawText(e.Graphics, dayName, dayFont,
                    new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top, textW, lh),
                    textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                TextRenderer.DrawText(e.Graphics, dayDate, dateFont,
                    new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top + lh, textW, lh),
                    textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                // Pallino se ci sono appuntamenti
                if (HasAppointmentsOnDay(e.ColumnIndex))
                {
                    int dotD = 8;
                    int dotX = e.CellBounds.Right - dotArea + 3;
                    int dotY = e.CellBounds.Top + (e.CellBounds.Height - dotD) / 2;
                    using var dotBrush = new SolidBrush(Color.FromArgb(60, 120, 215));
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(dotBrush, dotX, dotY, dotD, dotD);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                }
            }

            if (IsTodayColumn(e.ColumnIndex))
            {
                using var todayPen = new Pen(Color.FromArgb(60, 120, 215), 5);
                e.Graphics.DrawLine(todayPen,
                    e.CellBounds.Left, e.CellBounds.Bottom,
                    e.CellBounds.Right, e.CellBounds.Bottom);
            }

            e.Handled = true;
        }

        /// <summary>
        /// Disegna un blocco appuntamento stile Google Calendar.
        /// Layout su tre livelli (se altezza sufficiente):
        ///   Riga 1 — Titolo (grassetto, bianco)
        ///   Riga 2 — Operatore (semi-grassetto, bianco pieno)
        ///   Riga 3 — Orari (regular, bianco 85%)
        /// </summary>
        private void DrawAppointmentBlock(Graphics g, Appointment app, Rectangle rect)
        {
            using var brush = new SolidBrush(app.Color);
            using var border = new Pen(Color.FromArgb(
                Math.Max(0, app.Color.R - 40),
                Math.Max(0, app.Color.G - 40),
                Math.Max(0, app.Color.B - 40)));
            g.FillRectangle(brush, rect);
            g.DrawRectangle(border, rect);

            bool hasOperator = !string.IsNullOrWhiteSpace(app.OperatorName);
            string timeRange = $"{app.Start:HH:mm} – {app.End:HH:mm}";

            var inner = new Rectangle(rect.Left + 5, rect.Top + 3, rect.Width - 10, rect.Height - 6);

            if (inner.Height < 22)
            {
                // Blocco minimo: solo titolo compresso
                TextRenderer.DrawText(g, $"{app.Start:HH:mm}  {app.Title}",
                    new Font(dgvData.Font.FontFamily, 8f, FontStyle.Bold),
                    inner, Color.White,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                return;
            }

            if (inner.Height < 48 || !hasOperator)
            {
                // Due righe: titolo + orari (o titolo + operatore se c'è)
                int h1 = inner.Height / 2;
                int h2 = inner.Height - h1;

                TextRenderer.DrawText(g, app.Title,
                    new Font(dgvData.Font.FontFamily, 8.5f, FontStyle.Bold),
                    new Rectangle(inner.Left, inner.Top, inner.Width, h1),
                    Color.White,
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

                string line2 = hasOperator ? app.OperatorName : timeRange;
                TextRenderer.DrawText(g, line2,
                    new Font(dgvData.Font.FontFamily, 7.5f, FontStyle.Regular),
                    new Rectangle(inner.Left, inner.Top + h1, inner.Width, h2),
                    Color.FromArgb(220, 255, 255, 255),
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
                return;
            }

            // Tre righe: titolo / operatore (in evidenza) / orari
            int titleH = (int)(inner.Height * 0.42);
            int operatorH = (int)(inner.Height * 0.32);
            int timeH = inner.Height - titleH - operatorH;

            TextRenderer.DrawText(g, app.Title,
                new Font(dgvData.Font.FontFamily, 8.5f, FontStyle.Bold),
                new Rectangle(inner.Left, inner.Top, inner.Width, titleH),
                Color.White,
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

            // Operatore: nome in maiuscolo, semi-grassetto, bianco pieno — riga più visibile
            TextRenderer.DrawText(g, app.OperatorName,
                new Font(dgvData.Font.FontFamily, 8f, FontStyle.Bold),
                new Rectangle(inner.Left, inner.Top + titleH, inner.Width, operatorH),
                Color.White,
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);

            // Orari: più piccoli e leggermente trasparenti
            TextRenderer.DrawText(g, timeRange,
                new Font(dgvData.Font.FontFamily, 7f, FontStyle.Regular),
                new Rectangle(inner.Left, inner.Top + titleH + operatorH, inner.Width, timeH),
                Color.FromArgb(200, 255, 255, 255),
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
        }


        // ============================================================
        // HELPER COLONNE/RIGHE
        // ============================================================

        private bool IsSaturdayColumn(int i)
        {
            if (i <= 0) return false;
            return DateTime.TryParseExact(dgvData.Columns[i].Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var d)
                && d.DayOfWeek == DayOfWeek.Saturday;
        }

        private bool IsTodayColumn(int i)
        {
            if (i <= 0) return false;
            return DateTime.TryParseExact(dgvData.Columns[i].Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var d)
                && d.Date == DateTime.Today;
        }

        private DateTime GetDateFromColumn(int i)
        {
            DateTime.TryParseExact(dgvData.Columns[i].Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var d);
            return d;
        }

        private TimeSpan GetTimeFromRow(int r)
        {
            TimeSpan.TryParse(dgvData.Rows[r].Cells["Ora"].Value?.ToString(), out var t);
            return t;
        }

        private void dgvData_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvData.CurrentCell?.OwningColumn.Name == "Ora")
                dgvData.ClearSelection();
        }


        // ============================================================
        // CLICK
        // ============================================================

        private void dgvData_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0) return;

            // Se il click è negli ultimi 4px del bordo inferiore della riga,
            // l'utente sta probabilmente ridimensionando → non avviare il timer
            const int resizeTolerance = 4;
            int rowH = dgvData.Rows[e.RowIndex].Height;
            if (e.Location.Y >= rowH - resizeTolerance)
                return;

            _doubleClick = e.Clicks >= 2;
            _lastClick = e;
            _clickTimer.Stop();
            _clickTimer.Start();
        }

        private void ClickTimer_Tick(object? sender, EventArgs args)
        {
            _clickTimer.Stop();
            if (_lastClick == null) return;

            var e = _lastClick;
            var slotTime = GetTimeFromRow(e.RowIndex);
            DateTime day = GetDateFromColumn(e.ColumnIndex);
            var key = (day, slotTime);

            appointments.TryGetValue(key, out var list);

            // ── DOPPIO CLICK → inserisci ──────────────────────────────
            if (_doubleClick)
            {
                var form = new AppointmentInsertForm(day, slotTime);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAppuntamentiFromDB();
                    RebuildGrid();
                }
                return;
            }

            // ── CLICK SINGOLO → modifica ──────────────────────────────
            if (list == null || list.Count == 0) return;

            // Determina quale appuntamento affiancato è stato cliccato in base alla X
            Appointment? appointment = null;
            if (list.Count == 1)
            {
                appointment = list[0];
            }
            else
            {
                var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int cellW = dgvData.Columns[e.ColumnIndex].Width;
                int blockW = (cellW - 4) / list.Count;
                int idx = Math.Min(e.Location.X / Math.Max(1, blockW), list.Count - 1);
                appointment = list[idx];
            }

            if (appointment == null) return;

            var originalKey = (appointment.Start.Date, RoundToSlot(appointment.Start.TimeOfDay));
            var editForm = new AppointmentEditForm(appointment);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadAppuntamentiFromDB();
                RebuildGrid();
            }
        }

        private void timerTime_Tick(object sender, EventArgs e) =>
            btnWeek.Text = "OGGI: " + DateTime.Now.ToString("HH:mm:ss");


        // ============================================================
        // NAVIGAZIONE
        // ============================================================

        private void btnPrevWeek_Click(object sender, EventArgs e) { weekStart = weekStart.AddDays(-7); UpdateWeekUI(); }
        private void btnNextWeek_Click(object sender, EventArgs e) { weekStart = weekStart.AddDays(7); UpdateWeekUI(); }
        private void btnWeek_Click(object sender, EventArgs e) { weekStart = GetStartOfWeek(DateTime.Today); UpdateWeekUI(); }
    }
}