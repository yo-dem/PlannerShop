using PlannerShop.Data;
using System.Data;

namespace PlannerShop.Forms
{
    public partial class PurchaseClientEditForm : Form
    {
        private string idCliente;
        private Dictionary<string, Color> groupColors = new Dictionary<string, Color>();
        private Color[] palette = new Color[]
        {
            Color.White,
            Color.FromArgb(225, 225, 225)
        };

        public PurchaseClientEditForm(string idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            loadClienteData();


            DataTable dtAcquistiTemp = ModelAcquisti.getAcquistiByIdCliente(idCliente).Copy();

            Utils.SetDataGridStyle(dgvDataAcquisto, false, 40, 40);

            foreach (DataRow item in dtAcquistiTemp.Rows)
            {
                item["TIMESTAMP"] = item["TIMESTAMP"].ToString().Split(' ')[0];
            }

            dgvDataAcquisto.DataSource = dtAcquistiTemp;
            SetPurchaseDataGridStructure();

            dgvDataAcquisto.RowPrePaint += DgvDataAcquisto_RowPrePaint;

        }

        private void loadClienteData()
        {
            DataTable dtCliente = ModelClienti.getClienteById(idCliente);
            lblName.Text = dtCliente.Rows[0]["NOME"].ToString()!.ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString()!.ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();
        }

        void SetPurchaseDataGridStructure()
        {
            int fontSize = 10;

            var idPurchaseColumn = dgvDataAcquisto.Columns["IDACQUISTO"];
            idPurchaseColumn.DisplayIndex = 0;
            idPurchaseColumn.Visible = false;
            idPurchaseColumn.HeaderText = "IDACQUISTO";
            idPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaPurchaseColumnn = dgvDataAcquisto.Columns["MARCA"];
            marcaPurchaseColumnn.DisplayIndex = 1;
            marcaPurchaseColumnn.Visible = true;
            marcaPurchaseColumnn.HeaderText = "MARCA";
            marcaPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            marcaPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizionePurchaseColumnn = dgvDataAcquisto.Columns["DESCRIZIONE"];
            descrizionePurchaseColumnn.DisplayIndex = 2;
            descrizionePurchaseColumnn.Visible = true;
            descrizionePurchaseColumnn.HeaderText = "DESCRIZIONE";
            descrizionePurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizionePurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizionePurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizionePurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var qntPurchaseColumnn = dgvDataAcquisto.Columns["QNT"];
            qntPurchaseColumnn.DisplayIndex = 3;
            qntPurchaseColumnn.Visible = true;
            qntPurchaseColumnn.HeaderText = "QNT";
            qntPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qntPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntPurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_NETTO"];
            prezzoNettoPurchaseColumn.DisplayIndex = 4;
            prezzoNettoPurchaseColumn.Visible = false;
            prezzoNettoPurchaseColumn.HeaderText = "NETTO";
            prezzoNettoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoNettoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_IVATO"];
            prezzoIvatoPurchaseColumn.DisplayIndex = 5;
            prezzoIvatoPurchaseColumn.Visible = false;
            prezzoIvatoPurchaseColumn.HeaderText = "IVATO";
            prezzoIvatoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoIvatoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoVenditaPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_VENDITA"];
            prezzoVenditaPurchaseColumn.DisplayIndex = 6;
            prezzoVenditaPurchaseColumn.Visible = false;
            prezzoVenditaPurchaseColumn.HeaderText = "VENDITA";
            prezzoVenditaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoVenditaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoVenditaPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var totalePurchaseColumn = dgvDataAcquisto.Columns["TOTALE"];
            totalePurchaseColumn.DisplayIndex = 7;
            totalePurchaseColumn.Visible = true;
            totalePurchaseColumn.HeaderText = "TOTALE";
            totalePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            totalePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalePurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataPurchaseColumn = dgvDataAcquisto.Columns["DATA"];
            dataPurchaseColumn.DisplayIndex = 8;
            dataPurchaseColumn.Visible = false;
            dataPurchaseColumn.HeaderText = "DATA";
            dataPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idClientPurchaseColumn = dgvDataAcquisto.Columns["IDCLIENTE"];
            idClientPurchaseColumn.DisplayIndex = 9;
            idClientPurchaseColumn.Visible = false;
            idClientPurchaseColumn.HeaderText = "IDCLIENTE";
            idClientPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idClientPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idClientPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idClientPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idProdottoPurchaseColumn = dgvDataAcquisto.Columns["IDPRODOTTO"];
            idProdottoPurchaseColumn.DisplayIndex = 10;
            idProdottoPurchaseColumn.Visible = false;
            idProdottoPurchaseColumn.HeaderText = "IDPRODOTTO";
            idProdottoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idProdottoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProdottoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idProdottoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var aliquotaPurchaseColumn = dgvDataAcquisto.Columns["ALIQUOTA"];
            aliquotaPurchaseColumn.DisplayIndex = 11;
            aliquotaPurchaseColumn.Visible = false;
            aliquotaPurchaseColumn.HeaderText = "IVA";
            aliquotaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            aliquotaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var notePurchaseColumn = dgvDataAcquisto.Columns["NOTE"];
            notePurchaseColumn.DisplayIndex = 12;
            notePurchaseColumn.Visible = false;
            notePurchaseColumn.HeaderText = "NOTE";
            notePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            notePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notePurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var timestampPurchaseColumn = dgvDataAcquisto.Columns["TIMESTAMP"];
            timestampPurchaseColumn.DisplayIndex = 13;
            timestampPurchaseColumn.Visible = true;
            timestampPurchaseColumn.HeaderText = "DATA";
            timestampPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timestampPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        private void DgvDataAcquisto_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var grid = sender as DataGridView;
            if (e.RowIndex < 0) return;

            var row = grid.Rows[e.RowIndex];
            var timestampValue = row.Cells["TIMESTAMP"].Value?.ToString();

            if (string.IsNullOrEmpty(timestampValue))
                return;

            // Se questo timestamp non ha ancora un colore associato, glielo diamo
            if (!groupColors.ContainsKey(timestampValue))
            {
                Color nextColor = palette[groupColors.Count % palette.Length];
                groupColors[timestampValue] = nextColor;
            }

            // Applicazione del colore
            row.DefaultCellStyle.BackColor = groupColors[timestampValue];
        }


    }
}
