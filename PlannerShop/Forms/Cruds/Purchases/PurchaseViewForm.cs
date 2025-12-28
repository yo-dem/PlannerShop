using PlannerShop.Data;
using System.Data;

namespace PlannerShop.Forms
{
    public partial class PurchaseViewForm : Form
    {
        private string idCliente;
        private Dictionary<string, Color> groupColors = new Dictionary<string, Color>();
        private Color[] palette = new Color[]
        {
            Color.White,
            Color.FromArgb(225, 225, 225)
        };

        public PurchaseViewForm(string idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            loadClienteData();


            DataTable dtAcquistiTemp = ModelAcquisti.getAcquistiByIdCliente(idCliente).Copy();

            foreach (DataRow item in dtAcquistiTemp.Rows)
            {
                item["TIMESTAMP"] = item["TIMESTAMP"].ToString().Split(' ')[0];
            }

            dgvDataAcquisto.DataSource = dtAcquistiTemp;
            DgvUtils.SetDataGridStyle(dgvDataAcquisto, false, 40, 40, false);
            dgvDataAcquisto.DefaultCellStyle.SelectionBackColor = dgvDataAcquisto.DefaultCellStyle.BackColor;
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
            var idPurchaseColumn = dgvDataAcquisto.Columns["IDACQUISTO"];
            idPurchaseColumn.DisplayIndex = 0;
            idPurchaseColumn.Visible = false;
            idPurchaseColumn.HeaderText = "IDACQUISTO";
            idPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var marcaPurchaseColumnn = dgvDataAcquisto.Columns["MARCA"];
            marcaPurchaseColumnn.DisplayIndex = 1;
            marcaPurchaseColumnn.Visible = true;
            marcaPurchaseColumnn.HeaderText = "MARCA";
            marcaPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            marcaPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var nomePurchaseColumnn = dgvDataAcquisto.Columns["NOME"];
            nomePurchaseColumnn.DisplayIndex = 2;
            nomePurchaseColumnn.Visible = true;
            nomePurchaseColumnn.HeaderText = "NOME";
            nomePurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomePurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomePurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var descrizionePurchaseColumnn = dgvDataAcquisto.Columns["DESCRIZIONE"];
            descrizionePurchaseColumnn.DisplayIndex = 3;
            descrizionePurchaseColumnn.Visible = true;
            descrizionePurchaseColumnn.HeaderText = "DESCRIZIONE";
            descrizionePurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizionePurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizionePurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var qntPurchaseColumnn = dgvDataAcquisto.Columns["QNT"];
            qntPurchaseColumnn.DisplayIndex = 4;
            qntPurchaseColumnn.Visible = true;
            qntPurchaseColumnn.HeaderText = "QNT";
            qntPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qntPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoNettoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_NETTO"];
            prezzoNettoPurchaseColumn.DisplayIndex = 5;
            prezzoNettoPurchaseColumn.Visible = false;
            prezzoNettoPurchaseColumn.HeaderText = "NETTO";
            prezzoNettoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoNettoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoIvatoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_IVATO"];
            prezzoIvatoPurchaseColumn.DisplayIndex = 6;
            prezzoIvatoPurchaseColumn.Visible = false;
            prezzoIvatoPurchaseColumn.HeaderText = "IVATO";
            prezzoIvatoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoIvatoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoVenditaPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_VENDITA"];
            prezzoVenditaPurchaseColumn.DisplayIndex = 7;
            prezzoVenditaPurchaseColumn.Visible = false;
            prezzoVenditaPurchaseColumn.HeaderText = "VENDITA";
            prezzoVenditaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            prezzoVenditaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var totalePurchaseColumn = dgvDataAcquisto.Columns["TOTALE"];
            totalePurchaseColumn.DisplayIndex = 8;
            totalePurchaseColumn.Visible = true;
            totalePurchaseColumn.HeaderText = "TOTALE";
            totalePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            totalePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var dataPurchaseColumn = dgvDataAcquisto.Columns["DATA"];
            dataPurchaseColumn.DisplayIndex = 9;
            dataPurchaseColumn.Visible = false;
            dataPurchaseColumn.HeaderText = "DATA";
            dataPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var idClientPurchaseColumn = dgvDataAcquisto.Columns["IDCLIENTE"];
            idClientPurchaseColumn.DisplayIndex = 10;
            idClientPurchaseColumn.Visible = false;
            idClientPurchaseColumn.HeaderText = "IDCLIENTE";
            idClientPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idClientPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idClientPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var idProdottoPurchaseColumn = dgvDataAcquisto.Columns["IDPRODOTTO"];
            idProdottoPurchaseColumn.DisplayIndex = 11;
            idProdottoPurchaseColumn.Visible = false;
            idProdottoPurchaseColumn.HeaderText = "IDPRODOTTO";
            idProdottoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idProdottoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProdottoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var idServizioPurchaseColumn = dgvDataAcquisto.Columns["IDSERVIZIO"];
            idServizioPurchaseColumn.DisplayIndex = 12;
            idServizioPurchaseColumn.Visible = false;
            idServizioPurchaseColumn.HeaderText = "IDSERVIZIO";
            idServizioPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            idServizioPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idServizioPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var aliquotaPurchaseColumn = dgvDataAcquisto.Columns["ALIQUOTA"];
            aliquotaPurchaseColumn.DisplayIndex = 13;
            aliquotaPurchaseColumn.Visible = false;
            aliquotaPurchaseColumn.HeaderText = "IVA";
            aliquotaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            aliquotaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var notePurchaseColumn = dgvDataAcquisto.Columns["NOTE"];
            notePurchaseColumn.DisplayIndex = 14;
            notePurchaseColumn.Visible = false;
            notePurchaseColumn.HeaderText = "NOTE";
            notePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            notePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var timestampPurchaseColumn = dgvDataAcquisto.Columns["TIMESTAMP"];
            timestampPurchaseColumn.DisplayIndex = 15;
            timestampPurchaseColumn.Visible = true;
            timestampPurchaseColumn.HeaderText = "DATA";
            timestampPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timestampPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DgvDataAcquisto_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDataAcquisto.Rows[e.RowIndex];
            var timestampValue = row.Cells["TIMESTAMP"].Value?.ToString();

            if (string.IsNullOrEmpty(timestampValue))
                return;

            // Se questo timestamp non ha ancora un colore associato, glielo diamo
            if (!groupColors.ContainsKey(timestampValue))
            {
                Color nextColor = palette[groupColors.Count % palette.Length];
                groupColors[timestampValue] = nextColor;
            }

            row.DefaultCellStyle.BackColor = groupColors[timestampValue];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDataAcquisto.DataSource = ModelAcquisti.searchAcquisti(txtSearch.Text, idCliente);
        }

        private void PurchaseViewForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                txtSearch.Focus();
                txtSearch.AppendText(e.KeyChar.ToString());
                e.Handled = true;
            }
        }
    }
}
