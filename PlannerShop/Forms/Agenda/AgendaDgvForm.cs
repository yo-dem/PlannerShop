using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    /// <summary>
    /// Form che implementa un'agenda settimanale stile calendario.
    /// 
    /// STRUTTURA CONCETTUALE:
    /// - Righe  : slot temporali da 15 minuti
    /// - Colonne: giorni della settimana
    /// - Celle  : contenitori grafici di appuntamenti
    /// 
    /// La DataGridView viene usata solo come "canvas":
    /// tutta la logica temporale è mantenuta separata.
    /// </summary>
    public partial class AgendaDgvForm : Form
    {
        // ============================================================
        // STATO APPLICATIVO
        // ============================================================

        /// <summary>
        /// Lista degli slot temporali della giornata.
        /// È la rappresentazione logica del tempo (non della UI).
        /// </summary>
        private List<TimeSlotRow> TSRows;

        /// <summary>
        /// Lunedì della settimana attualmente visualizzata.
        /// </summary>
        private DateTime weekStart;

        /// <summary>
        /// Cultura italiana per nomi di giorni e mesi.
        /// </summary>
        private readonly CultureInfo culture = new("it-IT");

        private readonly Dictionary<(DateTime date, TimeSpan time), List<Appointment>> appointments = [];


        // ============================================================
        // COSTRUTTORE E INIZIALIZZAZIONE
        // ============================================================

        public AgendaDgvForm()
        {
            InitializeComponent();

            // Calcolo del lunedì della settimana corrente
            weekStart = GetStartOfWeek(DateTime.Today);

            // Costruzione della struttura temporale (una sola volta)
            BuildDefaultRows();

            // Configurazione grafica e strutturale della griglia
            SetupGrid();

            // Popolamento UI iniziale
            UpdateWeekUI();

            // Registrazione eventi
            HookGridEvents();

            // Dati mock (solo sviluppo)
            AddMockAppointment(new DateTime(2026, 1, 29), new TimeSpan(8, 30, 0), new Appointment
            {
                Id = 1,
                Titolo = "Appuntamento Patrizia",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 31), new TimeSpan(8, 15, 0), new Appointment
            {
                Id = 2,
                Titolo = "Appuntamento Lucilla",
                Colore = Color.MediumSlateBlue
            });
        }

        private void HookGridEvents()
        {
            dgvData.SelectionChanged += dgvData_SelectionChanged;
            dgvData.CellPainting += dgvData_CellPainting;
            dgvData.CellMouseClick += dgvData_CellMouseClick;
        }


        // ============================================================
        // LOGICA TEMPORALE
        // ============================================================

        /// <summary>
        /// Restituisce il lunedì della settimana contenente la data fornita.
        /// </summary>
        private static DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-diff).Date;
        }

        /// <summary>
        /// Costruisce gli slot temporali giornalieri (08:00 → 21:00),
        /// suddivisi in intervalli da 15 minuti.
        /// </summary>
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

        /// <summary>
        /// Configura la DataGridView:
        /// - comportamento
        /// - stile
        /// - colonne
        /// 
        /// Viene chiamata una sola volta.
        /// </summary>
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
            dgvData.RowTemplate.Height = 100;
            dgvData.RowTemplate.MinimumHeight = 100;
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

        /// <summary>
        /// Aggiorna completamente l'interfaccia per la settimana corrente.
        /// </summary>
        private void UpdateWeekUI()
        {
            UpdateWeekLabelText();
            UpdateGridHeaders();

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
        // RICOSTRUZIONE RIGHE
        // ============================================================

        /// <summary>
        /// Ricostruisce fisicamente le righe visibili della griglia
        /// in base allo stato degli slot temporali.
        /// </summary>
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

        // ============================================================
        // EVENTI DATA GRID VIEW
        // ============================================================

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.CurrentCell?.OwningColumn.Name == "Ora")
                dgvData.ClearSelection();
        }

        private bool IsSaturdayColumn(int columnIndex)
        {
            if (columnIndex <= 0) return false; // salta "Ora"

            var col = dgvData.Columns[columnIndex];

            return DateTime.TryParseExact(
                col.Name,
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var date)
                && (date.DayOfWeek == DayOfWeek.Saturday);
        }

        private bool IsTodayColumn(int columnIndex)
        {
            if (columnIndex <= 0) return false;

            var col = dgvData.Columns[columnIndex];

            return DateTime.TryParseExact(
                col.Name,
                "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var date)
                && date.Date == DateTime.Today;
        }

        /// <summary>
        /// Personalizza il rendering dell'header ORA
        /// </summary>
        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) // HEADER
            {
                Color backColor = SystemColors.Control;

                using var backBrush = new SolidBrush(SystemColors.Control);
                e.Graphics?.FillRectangle(backBrush, e.CellBounds);

                using var pen = new Pen(Color.FromArgb(210, 210, 210));

                // Bordi
                e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);
                e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics?.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                e.Graphics?.DrawLine(pen, e.CellBounds.Left - 1, e.CellBounds.Top, e.CellBounds.Left - 1, e.CellBounds.Bottom);

                if (e.ColumnIndex == 0) // ORA
                {
                    e.Graphics?.FillRectangle(backBrush, e.CellBounds);
                    e.Graphics?.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1); // Bottom
                }
                else // GIORNI
                {
                    string? text = e.FormattedValue?.ToString();
                    if (!string.IsNullOrEmpty(text))
                    {
                        var lines = text.Split('\n');
                        var dayName = lines[0];
                        var dayDate = lines.Length > 1 ? lines[1] : "";

                        int lineHeight = e.CellBounds.Height / 2;

                        // Determiniamo il giorno della settimana dalla colonna
                        DayOfWeek? dow = null;
                        if (DateTime.TryParseExact(dgvData.Columns[e.ColumnIndex].Name, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime colDate))
                        {
                            dow = colDate.DayOfWeek;
                        }

                        Font dayFont = e.CellStyle?.Font ?? dgvData.Font;
                        Color dayColor = Color.Black;

                        Font dateFont = e.CellStyle?.Font ?? dgvData.Font;
                        Color dateColor = Color.Black;

                        // Se weekend, cambiamo font
                        if (dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday)
                        {
                            dayFont = new Font(dayFont, FontStyle.Bold);
                            dayColor = Color.Red;
                            dateFont = new Font(dateFont, FontStyle.Regular | FontStyle.Italic);
                        }
                        else
                        {
                            dayFont = new Font(dayFont, FontStyle.Bold);
                            dayColor = Color.Black;
                            dateFont = new Font(dateFont, FontStyle.Regular);
                        }

                        if (IsTodayColumn(e.ColumnIndex))
                        {
                            dateFont = new Font(dateFont, FontStyle.Regular | FontStyle.Italic);
                            dayFont = new Font(dayFont, FontStyle.Bold);
                        }
                        //else
                        //{
                        //    dateFont = new Font(dateFont, FontStyle.Regular);
                        //    dayFont = new Font(dayFont, FontStyle.Bold);
                        //}

                        // Riga data (normale)
                        TextRenderer.DrawText(
                            e.Graphics!,
                            dayDate,
                            dateFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top + lineHeight, e.CellBounds.Width - 8, lineHeight),
                            dateColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                        );

                        // Riga giorno
                        TextRenderer.DrawText(
                            e.Graphics!,
                            dayName,
                            dayFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top, e.CellBounds.Width - 8, lineHeight),
                            dayColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                        );
                    }
                }

                // ===== ENFASI COLONNA "OGGI" =====
                if (IsTodayColumn(e.ColumnIndex))
                {
                    using var todayPen = new Pen(Color.FromArgb(60, 120, 215), 5);

                    // Bordo superiore spesso
                    e.Graphics!.DrawLine(
                        todayPen,
                        e.CellBounds.Left,
                        e.CellBounds.Bottom,
                        e.CellBounds.Right,
                        e.CellBounds.Bottom
                    );
                }
                e.Handled = true;
            }

            // CELLE DATI (non header)
            if (e.RowIndex >= 0 && IsSaturdayColumn(e.ColumnIndex))
            {
                // Lascia disegnare tutto normalmente
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);

                // Bordo verticale sinistro
                e.Graphics!.DrawLine(
                    thickPen,
                    e.CellBounds.Left,
                    e.CellBounds.Top,
                    e.CellBounds.Left,
                    e.CellBounds.Bottom
                );

                e.Handled = true;
            }

            if (e.RowIndex <= 0 && IsSaturdayColumn(e.ColumnIndex))
            {
                using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);

                // Bordo verticale sinistro
                e.Graphics!.DrawLine(
                    thickPen,
                    e.CellBounds.Left,
                    e.CellBounds.Top,
                    e.CellBounds.Left,
                    e.CellBounds.Bottom
                );

                e.Handled = true;
            }

            // ===============================
            // CELLE DATI CON APPUNTAMENTI
            // ===============================
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isSaturday = IsSaturdayColumn(e.ColumnIndex);

                if (cell.Tag is List<Appointment> apps && apps.Count > 0)
                {
                    // Lascia disegnare background + bordi standard
                    e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                    e.Handled = true;

                    int padding = 0;
                    int spacing = 3;
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
                            blockHeight
                        );

                        // Sfondo appuntamento
                        using var appBrush = new SolidBrush(app.Colore);
                        e.Graphics.FillRectangle(appBrush, rect);

                        // Bordo
                        using var borderPen = new Pen(Color.FromArgb(80, 80, 80));
                        e.Graphics.DrawRectangle(borderPen, rect);

                        // Titolo
                        TextRenderer.DrawText(
                            e.Graphics,
                            app.Titolo,
                            new Font(dgvData.Font.FontFamily, 8.5f, FontStyle.Bold),
                            rect,
                            Color.White,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
                        );
                    }

                    // Indicatore "altri"
                    if (apps.Count > maxVisible)
                    {
                        string moreText = $"+{apps.Count - maxVisible}";
                        var moreRect = new Rectangle(
                            e.CellBounds.Right - 28,
                            e.CellBounds.Bottom - 18,
                            28,
                            17
                        );

                        using var moreBrush = new SolidBrush(Color.FromArgb(200, Color.Black));
                        e.Graphics.FillRectangle(moreBrush, moreRect);

                        TextRenderer.DrawText(
                            e.Graphics,
                            moreText,
                            dgvData.Font,
                            moreRect,
                            Color.White,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                        );
                    }

                    if (isSaturday)
                    {
                        using var thickPen = new Pen(Color.FromArgb(100, 100, 100), 1);
                        e.Graphics!.DrawLine(
                            thickPen,
                            e.CellBounds.Left,
                            e.CellBounds.Top,
                            e.CellBounds.Left,
                            e.CellBounds.Bottom
                        );
                    }

                    return;
                }
            }

        }


        // ============================================================
        // CLICK E INTERAZIONI
        // ============================================================

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
                return;

            var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Tag is not List<Appointment> apps || apps.Count == 0)
                return;

            int padding = 4;
            int spacing = 3;
            int maxVisible = 3;

            int visible = Math.Min(apps.Count, maxVisible);
            int blockHeight = (dgvData.Rows[e.RowIndex].Height - padding * 2 - spacing * (visible - 1)) / visible;

            int relativeY = e.Location.Y - padding;
            if (relativeY < 0) return;

            int index = relativeY / (blockHeight + spacing);

            if (index >= 0 && index < visible)
            {
                var app = apps[index];

                MessageBox.Show(
                    $"Hai cliccato l'appuntamento con ID = {app.Id}",
                    "Click appuntamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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


        // ============================================================
        // MOCK DATA (SVILUPPO)
        // ============================================================

        private void AddMockAppointment(DateTime date, TimeSpan startTime, Appointment app)
        {
            var key = (date.Date, startTime);

            if (!appointments.TryGetValue(key, out var list))
            {
                list = new List<Appointment>();
                appointments[key] = list;
            }

            list.Add(app);

            RepaintAppointmentCell(date, startTime);
        }

        private void RepaintAppointmentCell(DateTime date, TimeSpan startTime)
        {
            string colName = date.ToString("yyyyMMdd");

            int colIndex = dgvData.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.Name == colName)?
                .Index ?? -1;

            if (colIndex == -1)
                return;

            for (int r = 0; r < dgvData.Rows.Count; r++)
            {
                if (TimeSpan.TryParse(
                        dgvData.Rows[r].Cells["Ora"].Value?.ToString(),
                        out var rowTime)
                    && rowTime == startTime)
                {
                    var cell = dgvData.Rows[r].Cells[colIndex];

                    var key = (date.Date, startTime);
                    cell.Tag = appointments.TryGetValue(key, out var list)
                        ? list
                        : null;

                    dgvData.InvalidateCell(cell);
                    break;
                }
            }
        }

    }
}
