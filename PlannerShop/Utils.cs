namespace PlannerShop
{
    struct Utils
    {
        public static void SetDataGridStyle(
            DataGridView dgvData,
            Boolean isMultiSelect,
            int headerColumnHeight,
            int rowHeight,
            bool sortable)
        {
            // Comportamento base
            dgvData.ShowCellToolTips = true;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = isMultiSelect;

            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.AllowUserToResizeColumns = false;

            // Dimensioni compatte stile Excel
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvData.ColumnHeadersHeight = headerColumnHeight;  
            dgvData.RowTemplate.Height = rowHeight;             

            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Font più piccolo e neutro (Excel-like)
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5f, FontStyle.Bold);
            dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);

            // Padding ridotto (chiave dell’effetto compatto)
            dgvData.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            // Ordinamento
            if (!sortable)
            {
                foreach (DataGridViewColumn column in dgvData.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

            //
            // Stile grafico – Excel compatto ma con i TUOI colori
            //

            dgvData.EnableHeadersVisualStyles = false;

            // Griglie sottili stile Excel
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvData.GridColor = Color.FromArgb(210, 210, 210);

            // Header colonne
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvData.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvData.ColumnHeadersDefaultCellStyle.BackColor;
            
            // Linee orizzontali nel selettore di riga
            dgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Righe
            dgvData.RowHeadersVisible = true;
            dgvData.RowHeadersWidth = 180;
            dgvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Colori di selezione (invariati)
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250);
            dgvData.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 255);
        }
    }
}
