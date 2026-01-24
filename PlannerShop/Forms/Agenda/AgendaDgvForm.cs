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
            dgvData.CellMouseClick += dgvData_CellMouseClick;
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
            dgvData.RowTemplate.Height = 100;
            dgvData.RowTemplate.MinimumHeight = 100;
            dgvData.ColumnHeadersHeight = 50;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font(dgvData.Font, FontStyle.Regular);

            dgvData.DefaultCellStyle.BackColor = Color.White;
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230);

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
            AddMockAppointment(new DateTime(2026, 1, 18),new TimeSpan(9, 0, 0), new Appuntamento
            {
                Id = 1,
                Titolo = "Appuntamento mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 15), new TimeSpan(9, 45, 0), new Appuntamento
            {
                Id = 2,
                Titolo = "Appuntamento 2 mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 15), new TimeSpan(9, 0, 0), new Appuntamento
            {
                Id = 2,
                Titolo = "Appuntamento 2 mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 15), new TimeSpan(10, 0, 0), new Appuntamento
            {
                Id = 2,
                Titolo = "Appuntamento 2 mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 15), new TimeSpan(8, 15, 0), new Appuntamento
            {
                Id = 2,
                Titolo = "Appuntamento 2 mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 14), new TimeSpan(9, 0, 0), new Appuntamento
            {
                Id = 2,
                Titolo = "Appuntamento 2 mock",
                Colore = Color.MediumSlateBlue
            });
            AddMockAppointment(new DateTime(2026, 1, 14), new TimeSpan(9, 0, 0), new Appuntamento
            {
                Id = 0,
                Titolo = "Appuntamento 0 mock",
                Colore = Color.MediumSlateBlue
            });
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

                // Ciclo sulle colonne dei giorni (1-7, skip "Ora")
                for (int colIndex = 1; colIndex <= 7; colIndex++)
                {
                    var col = dgvData.Columns[colIndex];
                    if (DateTime.TryParseExact(col.Name, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime colDate))
                    {
                        if (colDate.DayOfWeek == DayOfWeek.Saturday || colDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            row.Cells[colIndex].Style.BackColor = Color.FromArgb(245, 245, 245); // WEEKEND COLORI                        
                        }
                        else
                        {
                            row.Cells[colIndex].Style.BackColor = slot.HourGroup % 2 == 0
                                ? Color.FromArgb(240, 240, 255)
                                : Color.FromArgb(250, 250, 255);
                        }
                    }
                }
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

                if (cell.Tag is List<Appuntamento> apps && apps.Count > 0)
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

                    return;
                }
            }

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

        private void timerTime_Tick(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            btnWeek.Text = "OGGI: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void AddMockAppointment(DateTime date, TimeSpan startTime, Appuntamento app)
        {
            // Colonna = giorno
            string colName = date.ToString("yyyyMMdd");

            int colIndex = dgvData.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.Name == colName)?
                .Index ?? -1;

            if (colIndex == -1)
                return;

            // Riga = slot orario
            for (int r = 0; r < dgvData.Rows.Count; r++)
            {
                if (TimeSpan.TryParse(dgvData.Rows[r].Cells["Ora"].Value?.ToString(), out var rowTime)
                    && rowTime == startTime)
                {
                    var cell = dgvData.Rows[r].Cells[colIndex];

                    if (cell.Tag is not List<Appuntamento> list)
                    {
                        list = new List<Appuntamento>();
                        cell.Tag = list;
                    }

                    list.Add(app);

                    dgvData.InvalidateCell(cell);
                    break;
                }
            }
        }

        private void dgvData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
{
    if (e.RowIndex < 0 || e.ColumnIndex <= 0)
        return;

    var cell = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex];

    if (cell.Tag is not List<Appuntamento> apps || apps.Count == 0)
        return;

    // Stessi parametri del CellPainting
    int padding = 4;
    int spacing = 3;
    int maxVisible = 3;

    int visibleCount = Math.Min(apps.Count, maxVisible);
    int blockHeight = (dgvData.Rows[e.RowIndex].Height - padding * 2 - spacing * (visibleCount - 1)) / visibleCount;

    // Coordinate Y relative alla cella
    int relativeY = e.Location.Y - padding;

    if (relativeY < 0)
        return;

    int index = relativeY / (blockHeight + spacing);

    if (index >= 0 && index < visibleCount)
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


    }
}
