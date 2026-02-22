using PlannerShop.Data;
using PlannerShop.Forms.Agenda.Forms.Cruds;
using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    public partial class AgendaDgvForm : Form
    {
        // ============================================================
        // STATO APPLICATIVO
        // ============================================================

        private List<TimeSlotRow> TSRows;
        private DateTime weekStart;
        private readonly CultureInfo culture = new("it-IT");
        private readonly Dictionary<(DateTime date, TimeSpan time), List<Appointment>> appointments = [];

        private System.Windows.Forms.Timer _clickTimer;
        private DataGridViewCellMouseEventArgs? _lastClick;
        private bool _doubleClick;


        // ============================================================
        // COSTRUTTORE E INIZIALIZZAZIONE
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
            TSRows = new List<TimeSlotRow>();

            for (int hour = 8; hour <= 21; hour++)
            {
                TSRows.Add(new TimeSlotRow { Start = new(hour, 0, 0), End = new(hour, 15, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 15, 0), End = new(hour, 30, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 30, 0), End = new(hour, 45, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new(hour, 45, 0), End = new(hour + 1, 0, 0), HourGroup = hour });
            }
        }


        // ============================================================
        // CONFIGURAZIONE DATA GRID VIEW
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

            // ── RIGHE DIMEZZATE rispetto alla versione precedente ────
            dgvData.RowTemplate.Height = 50;
            dgvData.RowTemplate.MinimumHeight = 50;
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
            var col = new DataGridViewTextBoxColumn
            {
                Name = "Ora",
                HeaderText = "",
                Width = 80,
                ReadOnly = true
            };

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
        // AGGIORNAMENTO UI SETTIMANALE
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

                string dayName = culture.TextInfo.ToTitleCase(day.ToString("dddd"));
                string dayDate = culture.TextInfo.ToTitleCase(day.ToString("d MMMM", culture));

                col.Name = day.ToString("yyyyMMdd");
                col.HeaderText = $"{dayName}\n{dayDate}";
            }
        }


        // ============================================================
        // CARICAMENTO APPUNTAMENTI DA DB
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
                    {
                        list = new List<Appointment>();
                        appointments[key] = list;
                    }

                    list.Add(app);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Agenda] Errore caricamento DB: {ex.Message}");
            }
        }

        private static TimeSpan RoundToSlot(TimeSpan time)
        {
            int minutes = (time.Minutes / 15) * 15;
            return new TimeSpan(time.Hours, minutes, 0);
        }


        // ============================================================
        // RICOSTRUZIONE RIGHE
        // ============================================================

        private void RebuildGrid()
        {
            int scroll = dgvData.FirstDisplayedScrollingRowIndex;

            dgvData.SuspendLayout();
            dgvData.Rows.Clear();

            foreach (var slot in TSRows.OrderBy(r => r.Start))
            {
                int rowIndex = dgvData.Rows.Add();
                var row = dgvData.Rows[rowIndex];

                row.Cells["Ora"].Value = slot.Start.ToString(@"hh\:mm");

                bool hourStart = slot.Start.Minutes == 0;

                row.DefaultCellStyle.Font = hourStart
                    ? new Font(dgvData.Font, FontStyle.Bold)
                    : dgvData.Font;

                row.DefaultCellStyle.Alignment = hourStart
                    ? DataGridViewContentAlignment.MiddleLeft
                    : DataGridViewContentAlignment.MiddleRight;
            }

            dgvData.ResumeLayout();

            if (scroll >= 0 && scroll < dgvData.Rows.Count)
                dgvData.FirstDisplayedScrollingRowIndex = scroll;

            RestoreAppointmentsOnGrid();
        }

        private void RestoreAppointmentsOnGrid()
        {
            foreach (var kv in appointments)
            {
                var (date, time) = kv.Key;
                RepaintAppointmentCell(date, time);
            }
        }

        private void RepaintAppointmentCell(DateTime date, TimeSpan startTime)
        {
            string colName = date.ToString("yyyyMMdd");
            int colIndex = dgvData.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.Name == colName)?
                .Index ?? -1;

            if (colIndex == -1) return;

            for (int r = 0; r < dgvData.Rows.Count; r++)
            {
                if (TimeSpan.TryParse(
                        dgvData.Rows[r].Cells["Ora"].Value?.ToString(),
                        out var rowTime)
                    && rowTime == startTime)
                {
                    var cell = dgvData.Rows[r].Cells[colIndex];
                    var key = (date.Date, startTime);

                    cell.Tag = appointments.TryGetValue(key, out var list) ? list : null;
                    dgvData.InvalidateCell(cell);
                    break;
                }
            }
        }


        // ============================================================
        // EVENTI DATA GRID VIEW
        // ============================================================

        private void dgvData_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvData.CurrentCell?.OwningColumn.Name == "Ora")
                dgvData.ClearSelection();
        }

        private bool IsSaturdayColumn(int columnIndex)
        {
            if (columnIndex <= 0) return false;
            var col = dgvData.Columns[columnIndex];
            return DateTime.TryParseExact(col.Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)
                && date.DayOfWeek == DayOfWeek.Saturday;
        }

        private bool IsTodayColumn(int columnIndex)
        {
            if (columnIndex <= 0) return false;
            var col = dgvData.Columns[columnIndex];
            return DateTime.TryParseExact(col.Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var date)
                && date.Date == DateTime.Today;
        }

        /// <summary>
        /// Ricava la data dalla colonna cliccata.
        /// </summary>
        private DateTime GetDateFromColumn(int columnIndex)
        {
            var col = dgvData.Columns[columnIndex];
            DateTime.TryParseExact(col.Name, "yyyyMMdd",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);
            return date;
        }

        /// <summary>
        /// Ricava l'ora dallo slot di riga cliccato.
        /// </summary>
        private TimeSpan GetTimeFromRow(int rowIndex)
        {
            TimeSpan.TryParse(
                dgvData.Rows[rowIndex].Cells["Ora"].Value?.ToString(),
                out var time);
            return time;
        }

        private void dgvData_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) // HEADER
            {
                using var backBrush = new SolidBrush(SystemColors.Control);
                e.Graphics?.FillRectangle(backBrush, e.CellBounds);

                using var pen = new Pen(Color.FromArgb(210, 210, 210));
                e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);
                e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics?.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                e.Graphics?.DrawLine(pen, e.CellBounds.Left - 1, e.CellBounds.Top, e.CellBounds.Left - 1, e.CellBounds.Bottom);

                if (e.ColumnIndex == 0)
                {
                    e.Graphics?.FillRectangle(backBrush, e.CellBounds);
                    e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }
                else
                {
                    string? text = e.FormattedValue?.ToString();
                    if (!string.IsNullOrEmpty(text))
                    {
                        var lines = text.Split('\n');
                        var dayName = lines[0];
                        var dayDate = lines.Length > 1 ? lines[1] : "";
                        int lh = e.CellBounds.Height / 2;

                        DayOfWeek? dow = null;
                        if (DateTime.TryParseExact(dgvData.Columns[e.ColumnIndex].Name, "yyyyMMdd",
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime colDate))
                            dow = colDate.DayOfWeek;

                        Font dayFont = e.CellStyle?.Font ?? dgvData.Font;
                        Font dateFont = e.CellStyle?.Font ?? dgvData.Font;
                        Color dayColor = Color.Black;

                        if (dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday)
                        {
                            dayFont = new Font(dayFont, FontStyle.Bold);
                            dayColor = Color.Red;
                            dateFont = new Font(dateFont, FontStyle.Regular | FontStyle.Italic);
                        }
                        else
                        {
                            dayFont = new Font(dayFont, FontStyle.Bold);
                            dateFont = new Font(dateFont, FontStyle.Regular);
                        }

                        if (IsTodayColumn(e.ColumnIndex))
                            dateFont = new Font(dateFont, FontStyle.Regular | FontStyle.Italic);

                        TextRenderer.DrawText(e.Graphics!, dayDate, dateFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top + lh, e.CellBounds.Width - 8, lh),
                            dayColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                        TextRenderer.DrawText(e.Graphics!, dayName, dayFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top, e.CellBounds.Width - 8, lh),
                            dayColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                    }
                }

                if (IsTodayColumn(e.ColumnIndex))
                {
                    using var todayPen = new Pen(Color.FromArgb(60, 120, 215), 5);
                    e.Graphics!.DrawLine(todayPen,
                        e.CellBounds.Left, e.CellBounds.Bottom,
                        e.CellBounds.Right, e.CellBounds.Bottom);
                }

                e.Handled = true;
            }

            if (e.RowIndex >= 0 && IsSaturdayColumn(e.ColumnIndex))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);
                e.Graphics!.DrawLine(thickPen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom);
                e.Handled = true;
            }

            if (e.RowIndex <= 0 && IsSaturdayColumn(e.ColumnIndex))
            {
                using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);
                e.Graphics!.DrawLine(thickPen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom);
                e.Handled = true;
            }

            // ── CELLE CON APPUNTAMENTI ───────────────────────────────
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isSaturday = IsSaturdayColumn(e.ColumnIndex);

                if (cell.Tag is List<Appointment> apps && apps.Count > 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
                    e.Handled = true;

                    int padding = 0;
                    int spacing = 2;
                    int maxVisible = 3;

                    int visibleCount = Math.Min(apps.Count, maxVisible);
                    int blockHeight = (e.CellBounds.Height - padding * 2 - spacing * (visibleCount - 1)) / visibleCount;

                    for (int i = 0; i < visibleCount; i++)
                    {
                        var app = apps[i];
                        var rect = new Rectangle(
                            e.CellBounds.Left + padding + 10,
                            e.CellBounds.Top + padding + i * (blockHeight + spacing),
                            e.CellBounds.Width - padding * 2,
                            blockHeight);

                        using var appBrush = new SolidBrush(app.Color);
                        using var borderPen = new Pen(Color.FromArgb(80, 80, 80));
                        e.Graphics.FillRectangle(appBrush, rect);
                        e.Graphics.DrawRectangle(borderPen, rect);

                        TextRenderer.DrawText(e.Graphics, app.Title,
                            new Font(dgvData.Font.FontFamily, 8.5f, FontStyle.Bold),
                            rect, Color.White,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                    }

                    if (apps.Count > maxVisible)
                    {
                        string moreText = $"+{apps.Count - maxVisible}";
                        var moreRect = new Rectangle(e.CellBounds.Right - 28, e.CellBounds.Bottom - 18, 28, 17);

                        using var moreBrush = new SolidBrush(Color.FromArgb(200, Color.Black));
                        e.Graphics.FillRectangle(moreBrush, moreRect);
                        TextRenderer.DrawText(e.Graphics, moreText, dgvData.Font, moreRect, Color.White,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }

                    if (isSaturday)
                    {
                        using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);
                        e.Graphics!.DrawLine(thickPen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom);
                    }
                }
            }
        }


        // ============================================================
        // CLICK E INTERAZIONI
        // ============================================================

        private void dgvData_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0) return;

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
            var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // ── DOPPIO CLICK → inserisci nuovo appuntamento ──────────
            if (_doubleClick)
            {
                if (cell.Tag is List<Appointment> apps && apps.Count >= 2)
                {
                    MessageBox.Show("Troppi appuntamenti in questo slot.");
                    return;
                }

                // Passa data e ora della cella cliccata
                DateTime clickedDate = GetDateFromColumn(e.ColumnIndex);
                TimeSpan clickedTime = GetTimeFromRow(e.RowIndex);

                var insertForm = new AppointmentInsertForm(clickedDate, clickedTime);
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAppuntamentiFromDB();
                    RestoreAppointmentsOnGrid();
                }
                return;
            }

            // ── CLICK SINGOLO → apri modifica ────────────────────────
            if (cell.Tag is not List<Appointment> list || list.Count == 0)
                return;

            // Determina quale appuntamento è stato cliccato in base alla Y
            int padding = 0;
            int spacing = 2;
            int maxVisible = 3;
            int visible = Math.Min(list.Count, maxVisible);
            int blockHeight = (dgvData.Rows[e.RowIndex].Height - padding * 2 - spacing * (visible - 1)) / visible;

            int relativeY = e.Location.Y - padding;
            if (relativeY < 0) return;

            int index = relativeY / (blockHeight + spacing);

            if (index >= 0 && index < visible)
            {
                var app = list[index];
                var editForm = new AppointmentEditForm(app);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAppuntamentiFromDB();
                    RestoreAppointmentsOnGrid();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            btnWeek.Text = "OGGI: " + DateTime.Now.ToString("HH:mm:ss");
        }

        // ============================================================
        // NAVIGAZIONE SETTIMANA
        // ============================================================

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            weekStart = weekStart.AddDays(-7);
            UpdateWeekUI();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            weekStart = weekStart.AddDays(7);
            UpdateWeekUI();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            weekStart = GetStartOfWeek(DateTime.Today);
            UpdateWeekUI();
        }
    }
}