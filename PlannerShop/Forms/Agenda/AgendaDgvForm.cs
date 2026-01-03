using System.Globalization;

namespace PlannerShop.Forms.Agenda
{
    public partial class AgendaDgvForm : Form
    {
        // ===============================
        // STATO
        // ===============================

        // Righe logiche della giornata (slot temporali)
        private List<TimeSlotRow> TSRows;

        // Lunedì della settimana visualizzata
        private DateTime _weekStart;

        // Cultura italiana per giorni e mesi
        private readonly CultureInfo _culture = new CultureInfo("it-IT");

        // Stato di espansione delle ore (per raggruppamento)
        private Dictionary<int, bool> _expandedHours = new();


        // ===============================
        // COSTRUTTORE
        // ===============================

        public AgendaDgvForm()
        {
            InitializeComponent();

            // Inizializza la settimana corrente (lunedì)
            _weekStart = GetStartOfWeek(DateTime.Today);

            // Costruisce UNA VOLTA gli slot orari
            BuildDefaultRows();

            // Configura UNA VOLTA la griglia (colonne + stili)
            SetupGrid();

            // Aggiorna UI e contenuti per la settimana corrente
            UpdateWeekUI();

            // Eventi
            dgvData.SelectionChanged += dgvData_SelectionChanged;
            dgvData.CellPainting += dgvData_CellPainting;
            dgvData.CellClick += dgvData_CellClick;
        }

        // ===============================
        // LOGICA TEMPORALE
        // ===============================

        /// <summary>
        /// Restituisce il lunedì della settimana della data fornita
        /// </summary>
        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-diff).Date;
        }

        /// <summary>
        /// Costruisce gli slot temporali della giornata (15 minuti)
        /// </summary>
        private void BuildDefaultRows()
        {
            TSRows = new List<TimeSlotRow>();

            for (int hour = 8; hour <= 21; hour++)
            {
                TSRows.Add(new TimeSlotRow { Start = new TimeSpan(hour, 0, 0), End = new TimeSpan(hour, 15, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new TimeSpan(hour, 15, 0), End = new TimeSpan(hour, 30, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new TimeSpan(hour, 30, 0), End = new TimeSpan(hour, 45, 0), HourGroup = hour });
                TSRows.Add(new TimeSlotRow { Start = new TimeSpan(hour, 45, 0), End = new TimeSpan(hour + 1, 0, 0), HourGroup = hour });
            }
        }

        // ===============================
        // SETUP GRIGLIA
        // ===============================

        /// <summary>
        /// Configura la DataGridView:
        /// - comportamento
        /// - stili
        /// - colonne
        /// </summary>
        private void SetupGrid()
        {
            dgvData.EnableHeadersVisualStyles = false;

            // Griglie sottili stile Excel
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvData.GridColor = Color.FromArgb(210, 210, 210);

            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ReadOnly = true;
            dgvData.MultiSelect = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvData.RowHeadersVisible = false;
            dgvData.AutoGenerateColumns = false;

            dgvData.Font = new Font("Segoe UI", 10f);
            dgvData.RowTemplate.Height = 60;
            dgvData.RowTemplate.MinimumHeight = 60;
            dgvData.ColumnHeadersHeight = 50;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font(dgvData.Font, FontStyle.Regular);

            dgvData.DefaultCellStyle.BackColor = Color.White;
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250);

            dgvData.Columns.Clear();

            // Colonna ORA
            dgvData.Columns.Add(CreateOraColumn());

            // 7 colonne dei giorni (vuote, header aggiornato dinamicamente)
            for (int i = 0; i < 7; i++)
                dgvData.Columns.Add(CreateDayColumn());

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.Resizable = DataGridViewTriState.False;
            }
        }

        /// <summary>
        /// Crea la colonna ORA con stili coerenti e non selezionabili
        /// </summary>
        private DataGridViewTextBoxColumn CreateOraColumn()
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

        /// <summary>
        /// Crea una colonna giorno (header impostato successivamente)
        /// </summary>
        private DataGridViewTextBoxColumn CreateDayColumn()
        {
            return new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }

        // ===============================
        // AGGIORNAMENTO UI
        // ===============================

        /// <summary>
        /// Aggiorna completamente la UI in base alla settimana corrente
        /// </summary>
        private void UpdateWeekUI()
        {
            UpdateWeekLabelText();
            UpdateGridHeaders();
            ApplyFolding(hour => true);
            RebuildGrid();
        }

        /// <summary>
        /// Aggiorna la label con il range settimanale
        /// </summary>
        private void UpdateWeekLabelText()
        {
            DateTime start = _weekStart;
            DateTime end = _weekStart.AddDays(6);

            string text = start.Month == end.Month
                ? $"{start.Day} – {end.Day} {start:MMMM yyyy}"
                : $"{start:dd MMM} – {end:dd MMM yyyy}";

            lblTimeSlot.Text = _culture.TextInfo.ToTitleCase(text);
        }

        /// <summary>
        /// Aggiorna SOLO gli header delle colonne giorno
        /// Nessuna colonna viene ricreata
        /// </summary>
        private void UpdateGridHeaders()
        {
            for (int i = 0; i < 7; i++)
            {
                DateTime day = _weekStart.AddDays(i);
                var col = dgvData.Columns[i + 1]; // +1 = salta "Ora"

                string dayName = _culture.DateTimeFormat.GetDayName(day.DayOfWeek);
                dayName = _culture.TextInfo.ToTitleCase(dayName);

                string dayDate = day.ToString("d MMMM", _culture);
                dayDate = _culture.TextInfo.ToTitleCase(dayDate);

                col.Name = day.ToString("yyyyMMdd");
                col.HeaderText = $"{dayName}\n{dayDate}";
            }
        }

        /// <summary>
        /// Ricostruisce le righe in base agli slot temporali
        /// </summary>
        private void RebuildGrid()
        {
            int firstDisplayedRow = dgvData.FirstDisplayedScrollingRowIndex;

            dgvData.SuspendLayout();
            dgvData.Rows.Clear();

            foreach (var slot in TSRows
                .Where(r => !r.IsCollapsed)
                .OrderBy(r => r.Start))
            {
                int rowIndex = dgvData.Rows.Add();
                var row = dgvData.Rows[rowIndex];

                row.Cells["Ora"].Value = slot.Start.ToString(@"hh\:mm");

                if (slot.Start.Minutes == 0)
                {
                    row.DefaultCellStyle.Font = new Font(dgvData.Font, FontStyle.Bold);
                    row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    row.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
                }
                else
                {
                    row.DefaultCellStyle.Font = dgvData.Font;
                    row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                row.DefaultCellStyle.BackColor =
                    slot.HourGroup % 2 == 0
                        ? Color.FromArgb(240, 240, 255)
                        : Color.White;
            }

            dgvData.ResumeLayout();

            if (firstDisplayedRow >= 0 && firstDisplayedRow < dgvData.Rows.Count)
            {
                dgvData.FirstDisplayedScrollingRowIndex = firstDisplayedRow;
            }
        }


        /// <summary>
        /// Applies folding logic to time slot rows, collapsing or expanding slots within each hour group based on event
        /// presence and expansion state.
        /// </summary>
        /// <remarks>
        /// Slots at the start of each hour are always expanded. Other slots are collapsed unless
        /// the hour contains events or is explicitly expanded.
        /// </remarks>
        private void ApplyFolding(Func<int, bool> hourHasEvents)
        {
            foreach (var hourGroup in TSRows.GroupBy(r => r.HourGroup))
            {
                int hour = hourGroup.Key;

                bool hasEvents = hourHasEvents(hour);
                bool isExpanded = _expandedHours.ContainsKey(hour) && _expandedHours[hour];

                foreach (var slot in hourGroup)
                {
                    // Mostra sempre hh:00
                    if (slot.Start.Minutes == 0)
                    {
                        slot.IsCollapsed = false;
                        continue;
                    }

                    // Mostra solo se necessario
                    slot.IsCollapsed = !(hasEvents || isExpanded);
                }
            }
        }


        // ===============================
        // EVENTI
        // ===============================

        /// <summary>
        /// Impedisce la selezione della colonna ORA
        /// </summary>
        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.CurrentCell?.OwningColumn.Name == "Ora")
                dgvData.ClearSelection();
        }

        /// <summary>
        /// Personalizza il rendering dell'header ORA
        /// </summary>
        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) // HEADER
            {
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
                        if (DateTime.TryParseExact(dgvData.Columns[e.ColumnIndex].Name, "yyyyMMdd", CultureInfo.InvariantCulture,
                                                   DateTimeStyles.None, out DateTime colDate))
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
                            dateFont = new Font(dateFont, FontStyle.Italic);
                        }
                        else
                        {
                            dayFont = new Font(dayFont, FontStyle.Bold);
                            dayColor = Color.Black;
                        }

                        // Riga giorno
                        TextRenderer.DrawText(
                            e.Graphics!,
                            dayName,
                            dayFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top, e.CellBounds.Width - 8, lineHeight),
                            dayColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                        );

                        // Riga data (normale)
                        TextRenderer.DrawText(
                            e.Graphics!,
                            dayDate,
                            dateFont,
                            new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Top + lineHeight, e.CellBounds.Width - 8, lineHeight),
                            dateColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                        );
                    }
                }

                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the CellClick event for the data grid, toggling the expanded or collapsed state of an hour group
        /// when the first column of a data row is clicked.
        /// </summary>
        /// <remarks>
        /// This handler only responds to clicks in the first column of data rows. Clicking a
        /// valid cell toggles the expansion state for the corresponding hour and updates the grid display.
        /// </remarks>
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0)
                return;

            string? value = dgvData.Rows[e.RowIndex].Cells["Ora"].Value?.ToString();
            if (value == null) return;

            if (TimeSpan.TryParse(value, out var time) && time.Minutes == 0)
            {
                int hour = time.Hours;

                // Toggle espansione di questa ora
                bool currentlyExpanded = _expandedHours.GetValueOrDefault(hour, true); // default true
                _expandedHours[hour] = !currentlyExpanded;

                // Applica folding solo basandosi sullo stato salvato
                ApplyFolding(hourKey =>
                {
                    // Se c'è stato un toggle, rispetta lo stato salvato
                    return _expandedHours.GetValueOrDefault(hourKey, true);
                });

                RebuildGrid();
            }
        }


        // ===============================
        // NAVIGAZIONE SETTIMANE
        // ===============================

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            _weekStart = _weekStart.AddDays(-7);
            UpdateWeekUI();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            _weekStart = _weekStart.AddDays(7);
            UpdateWeekUI();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            _weekStart = GetStartOfWeek(DateTime.Today);
            UpdateWeekUI();
        }
    }
}
