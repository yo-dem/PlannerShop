using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerShop
{
    struct Utils
    {
        public static void SetDataGridStyle(DataGridView dgvData)
        {
            // Elimina i tooltips dalle celle
            dgvData.ShowCellToolTips = true;
            // Impedisce al controllo di scegliere autonomamente l'altezza dell'header delle colonne
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // Imposta l'altezza dell'header delle colonne
            dgvData.ColumnHeadersHeight = 70;
            // Imposta l'altezza delle singole righe
            dgvData.RowTemplate.Height = 50;
            // Imposta il font per l'header delle colonne
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 8, System.Drawing.FontStyle.Bold);
            // Impedisce all'utente di modificare la dimensione delle righe
            dgvData.AllowUserToResizeRows = false;
            // Impedisce all'utente di modificare la dimensione delle colonne
            dgvData.AllowUserToResizeColumns = false;
            // Impedisce all'utente di aggiungere una nuova riga
            dgvData.AllowUserToAddRows = false;
            // impedisce all'utente di eliminare le righe in modo non gestito
            dgvData.AllowUserToDeleteRows = false;
            // Impone la dimensione massima possibile per ciascuna colonna
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Nasconde o visualizza il selettore di riga
            dgvData.RowHeadersVisible = true;
            // Impedisce la modifica del valore delle celle
            dgvData.ReadOnly = true;
            // Impone la selezione dell'intera riga e non della singola cella
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Impedisce la selezione di più righe contemporaneamente
            dgvData.MultiSelect = true;
            // Aggiunge un offset per distanziare i contenuti delle celle dai bordi
            dgvData.DefaultCellStyle.Padding = new Padding(5);
            // Disabilita l'ordinamento automatico di ogni colonna, escluse le prime 4
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Index > 3)
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //
            // Opzioni di stile grafico
            //

            // Abilita la gli stili automatici dell'header
            dgvData.EnableHeadersVisualStyles = false;
            // Imposta il colore di sfondo del datagridview
            dgvData.BackgroundColor = Color.FromArgb(240, 240, 240);
            // Elimina il bordo del datagridview
            dgvData.BorderStyle = BorderStyle.None;
            // Elimina il bordo dell'header delle colonne
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            // Imposta solo una bordo orizzontale per ogni riga
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            // Imposta il colore di sfondo dell'header delle colonne a un grigio chiaro
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            // Imposta il colore di sfondo delle righe selezionate
            dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 210, 240);
            // Imposta il colore del testo delle righe selezionate
            dgvData.DefaultCellStyle.SelectionForeColor = Color.Black;
            // Imposta il colore di sfondo dell'header selezionato uguale a quello del proprio sfondo
            dgvData.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvData.ColumnHeadersDefaultCellStyle.BackColor;
            // Imposta il colore del selettore di riga
            dgvData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 255);
            // Imposta la larghezza dell'header delle righe
            dgvData.RowHeadersWidth = 30;
            // Disabilita la possibilità di ridimensionare la larghezza dell'header delle righe
            dgvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }
    }
}
