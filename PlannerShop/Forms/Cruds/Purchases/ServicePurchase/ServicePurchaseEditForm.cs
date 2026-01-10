using PlannerShop.Data;
using System.Data;

namespace PlannerShop.Forms
{
    public partial class ServicePurchaseEditForm : Form
    {
        private DataTable dtServiziTemp;
        private DataTable dtAcquistiTemp;
        private DataTable dtCliente;

        private readonly DateTime timeStamp;
        private readonly string idCliente;

        public ServicePurchaseEditForm(string idCliente)
        {
            InitializeComponent();

            this.idCliente = idCliente;
            timeStamp = DateTime.Now;

            dtServiziTemp = ModelServizi.getServizi().Copy();
            dtAcquistiTemp = ModelAcquisti
                .getAcquistiByIdClienteAndTimestamp(idCliente, timeStamp.ToString())
                .Copy();

            dgvData.DataSource = dtServiziTemp;
            dgvDataAcquisto.DataSource = dtAcquistiTemp;

            SetServiceDataGridStructure();
            SetPurchaseDataGridStructure();

            DgvUtils.SetDataGridStyle(dgvData, false, 40, 40, true);
            DgvUtils.SetDataGridStyle(dgvDataAcquisto, false, 40, 40, true);

            LoadClienteData();
        }

        private void LoadClienteData()
        {
            dtCliente = ModelClienti.getClienteById(idCliente);

            var row = dtCliente.Rows[0];
            lblName.Text = $"{row["NOME"]} {row["COGNOME"]}".ToUpper();
            lblIndirizzo.Text = row["INDIRIZZO"].ToString();
            lblTelefono.Text = $"Tel. {row["TELEFONO"]}";
            lblEmail.Text = row["EMAIL"].ToString();
        }

        // =========================
        // SCONTO (SERVIZI)
        // =========================

        private string CalculateSconto(DataRow row)
        {
            // CHANGED: niente QNT, un servizio è sempre 1

            if (!TryParseEuro(row["PREZZO_VENDITA"], out decimal prezzo))
                return "0%";

            if (!TryParseEuro(row["TOTALE"], out decimal totale))
                return "0%";

            if (totale >= prezzo || prezzo <= 0)
                return "0%";

            decimal sconto = (prezzo - totale) / prezzo * 100m;
            return sconto.ToString("0.00") + "%";
        }

        private static bool TryParseEuro(object value, out decimal result)
        {
            result = 0m;
            if (value == null) return false;

            return decimal.TryParse(
                value.ToString()!
                    .Replace("€", "")
                    .Trim(),
                out result
            );
        }

        // =========================
        // EVENTI
        // =========================

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtServiziTemp = ModelServizi.searchServizi(txtSearch.Text);
            dgvData.DataSource = dtServiziTemp;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow row = dtServiziTemp.Rows[e.RowIndex];

            using var detailForm =
                new ServicePurchaseDetaIlForm(row, dtCliente);

            if (detailForm.ShowDialog() == DialogResult.Cancel)
                return;

            DataRow newAcq = dtAcquistiTemp.NewRow();

            newAcq["IDSERVIZIO"] = row["IDSERVIZIO"];
            newAcq["IDCLIENTE"] = idCliente;
            newAcq["NOME"] = row["NOME"];
            newAcq["DESCRIZIONE"] = row["DESCRIZIONE"];
            newAcq["PREZZO_NETTO"] = row["PREZZO_NETTO"];
            newAcq["PREZZO_IVATO"] = row["PREZZO_IVATO"];
            newAcq["PREZZO_VENDITA"] = row["PREZZO_VENDITA"];
            newAcq["ALIQUOTA"] = row["ALIQUOTA"];
            newAcq["DATA"] = row["DATA"];
            newAcq["NOTE"] = row["NOTE"];
            newAcq["TIMESTAMP"] = timeStamp.ToString();
            newAcq["TOTALE"] = detailForm.lblTotaleCalcolato.Text;
            newAcq["SCONTO"] = CalculateSconto(newAcq);

            dtAcquistiTemp.Rows.Add(newAcq);

            dgvData.ClearSelection();
            dgvDataAcquisto.ClearSelection();
        }

        private void dgvDataAcquisto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow row =
                ((DataRowView)dgvDataAcquisto.Rows[e.RowIndex]
                    .DataBoundItem).Row;

            dtAcquistiTemp.Rows.Remove(row);
        }

        private void dgvDataAcquisto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvDataAcquisto.Columns[e.ColumnIndex].Name != "PREZZO_TOTALE")
                return;

            var drv =
                dgvDataAcquisto.Rows[e.RowIndex]
                    .DataBoundItem as DataRowView;

            if (drv == null) return;

            if (!TryParseEuro(drv["PREZZO_VENDITA"], out decimal prezzo))
                return;

            e.Value = prezzo.ToString("F2") + " €";
            e.FormattingApplied = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtAcquistiTemp.Rows.Count == 0)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            DataTable originali =
                ModelAcquisti.getAcquistiByIdClienteAndTimestamp(
                    idCliente,
                    timeStamp.ToString()
                );

            SaveServicePurchase(dtAcquistiTemp, originali);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================
        // SALVATAGGIO
        // =========================

        private void SaveServicePurchase(DataTable acquistiTemp, DataTable acquistiOriginali)
        {
            foreach (DataRow row in acquistiTemp.Rows)
            {
                string idServizio = row["IDSERVIZIO"].ToString()!;

                if (acquistiOriginali
                    .Select($"IDSERVIZIO = '{idServizio}'")
                    .Length > 0)
                    continue;

                ModelAcquisti.addAcquisto(
                    string.Empty,
                    row["NOME"].ToString()!,
                    row["DESCRIZIONE"].ToString()!,
                    string.Empty,
                    row["PREZZO_NETTO"].ToString()!,
                    row["PREZZO_IVATO"].ToString()!,
                    row["PREZZO_VENDITA"].ToString()!,
                    row["TOTALE"].ToString()!,
                    CalculateSconto(row),
                    row["DATA"].ToString()!,
                    idCliente,
                    string.Empty,
                    idServizio,
                    row["ALIQUOTA"].ToString()!,
                    row["NOTE"].ToString()!,
                    row["TIMESTAMP"].ToString()!
                );
            }
        }

        private void SetServiceDataGridStructure()
        {
            int fontSize = 10;

            var idServiceColumn = dgvData.Columns["IDSERVIZIO"];
            idServiceColumn.DisplayIndex = 0;
            idServiceColumn.Visible = false;
            idServiceColumn.HeaderText = "IDSERVIZIO";
            idServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataServiceColumn = dgvData.Columns["DATA"];
            dataServiceColumn.DisplayIndex = 1;
            dataServiceColumn.Visible = false;
            dataServiceColumn.HeaderText = "DATA";
            dataServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var nomeServiceColumn = dgvData.Columns["NOME"];
            nomeServiceColumn.DisplayIndex = 2;
            nomeServiceColumn.Visible = true;
            nomeServiceColumn.HeaderText = "NOME";
            nomeServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizioneServiceColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneServiceColumn.DisplayIndex = 3;
            descrizioneServiceColumn.Visible = true;
            descrizioneServiceColumn.HeaderText = "DESCRIZIONE";
            descrizioneServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var aliquotaServiceColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaServiceColumn.DisplayIndex = 4;
            aliquotaServiceColumn.Visible = false;
            aliquotaServiceColumn.HeaderText = "IVA";
            aliquotaServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aliquotaServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            aliquotaServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoServiceColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoServiceColumn.DisplayIndex = 5;
            prezzoNettoServiceColumn.Visible = true;
            prezzoNettoServiceColumn.HeaderText = "NETTO";
            prezzoNettoServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoNettoServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoServiceColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoServiceColumn.DisplayIndex = 6;
            prezzoIvatoServiceColumn.Visible = true;
            prezzoIvatoServiceColumn.HeaderText = "IVATO";
            prezzoIvatoServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoIvatoServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoVenditaServiceColumn = dgvData.Columns["PREZZO_VENDITA"];
            prezzoVenditaServiceColumn.DisplayIndex = 7;
            prezzoVenditaServiceColumn.Visible = true;
            prezzoVenditaServiceColumn.HeaderText = "VENDITA";
            prezzoVenditaServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoVenditaServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoVenditaServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteServiceColumn = dgvData.Columns["NOTE"];
            noteServiceColumn.DisplayIndex = 8;
            noteServiceColumn.Visible = false;
            noteServiceColumn.HeaderText = "NOTE";
            noteServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteServiceColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        private void SetPurchaseDataGridStructure()
        {
            int fontSize = 10;

            var idPurchaseColumn = dgvDataAcquisto.Columns["IDACQUISTO"];
            idPurchaseColumn.DisplayIndex = 0;
            idPurchaseColumn.Visible = false;
            idPurchaseColumn.HeaderText = "IDACQUISTO";
            idPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaPurchaseColumnn = dgvDataAcquisto.Columns["MARCA"];
            marcaPurchaseColumnn.DisplayIndex = 1;
            marcaPurchaseColumnn.Visible = false;
            marcaPurchaseColumnn.HeaderText = "MARCA";
            marcaPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            marcaPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var nomePurchaseColumnn = dgvDataAcquisto.Columns["NOME"];
            nomePurchaseColumnn.DisplayIndex = 2;
            nomePurchaseColumnn.Visible = true;
            nomePurchaseColumnn.HeaderText = "NOME";
            nomePurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomePurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomePurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomePurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizionePurchaseColumnn = dgvDataAcquisto.Columns["DESCRIZIONE"];
            descrizionePurchaseColumnn.DisplayIndex = 3;
            descrizionePurchaseColumnn.Visible = true;
            descrizionePurchaseColumnn.HeaderText = "DESCRIZIONE";
            descrizionePurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizionePurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizionePurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizionePurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var qntPurchaseColumnn = dgvDataAcquisto.Columns["QNT"];
            qntPurchaseColumnn.DisplayIndex = 4;
            qntPurchaseColumnn.Visible = false;
            qntPurchaseColumnn.HeaderText = "QNT";
            qntPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qntPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntPurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_NETTO"];
            prezzoNettoPurchaseColumn.DisplayIndex = 5;
            prezzoNettoPurchaseColumn.Visible = true;
            prezzoNettoPurchaseColumn.HeaderText = "NETTO";
            prezzoNettoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoNettoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_IVATO"];
            prezzoIvatoPurchaseColumn.DisplayIndex = 6;
            prezzoIvatoPurchaseColumn.Visible = true;
            prezzoIvatoPurchaseColumn.HeaderText = "IVATO";
            prezzoIvatoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoIvatoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoVenditaPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_VENDITA"];
            prezzoVenditaPurchaseColumn.DisplayIndex = 7;
            prezzoVenditaPurchaseColumn.Visible = false;
            prezzoVenditaPurchaseColumn.HeaderText = "VENDITA";
            prezzoVenditaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoVenditaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoVenditaPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            dgvDataAcquisto.Columns.Add("PREZZO_TOTALE", "PREZZO");
            var totalePrezzoPurchaseColumn = dgvDataAcquisto.Columns["PREZZO_TOTALE"];
            totalePrezzoPurchaseColumn.DisplayIndex = 8;
            totalePrezzoPurchaseColumn.Visible = true;
            totalePrezzoPurchaseColumn.HeaderText = "PREZZO";
            totalePrezzoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalePrezzoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            totalePrezzoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalePrezzoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var totalePurchaseColumn = dgvDataAcquisto.Columns["TOTALE"];
            totalePurchaseColumn.DisplayIndex = 9;
            totalePurchaseColumn.Visible = true;
            totalePurchaseColumn.HeaderText = "PAGATO";
            totalePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            totalePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalePurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataPurchaseColumn = dgvDataAcquisto.Columns["DATA"];
            dataPurchaseColumn.DisplayIndex = 10;
            dataPurchaseColumn.Visible = false;
            dataPurchaseColumn.HeaderText = "DATA";
            dataPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idClientPurchaseColumn = dgvDataAcquisto.Columns["IDCLIENTE"];
            idClientPurchaseColumn.DisplayIndex = 11;
            idClientPurchaseColumn.Visible = false;
            idClientPurchaseColumn.HeaderText = "IDCLIENTE";
            idClientPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idClientPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idClientPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idClientPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idProdottoPurchaseColumn = dgvDataAcquisto.Columns["IDPRODOTTO"];
            idProdottoPurchaseColumn.DisplayIndex = 12;
            idProdottoPurchaseColumn.Visible = false;
            idProdottoPurchaseColumn.HeaderText = "IDPRODOTTO";
            idProdottoPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idProdottoPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProdottoPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idProdottoPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idServizioPurchaseColumn = dgvDataAcquisto.Columns["IDSERVIZIO"];
            idServizioPurchaseColumn.DisplayIndex = 13;
            idServizioPurchaseColumn.Visible = false;
            idServizioPurchaseColumn.HeaderText = "IDSERVIZIO";
            idServizioPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idServizioPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idServizioPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idServizioPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var aliquotaPurchaseColumn = dgvDataAcquisto.Columns["ALIQUOTA"];
            aliquotaPurchaseColumn.DisplayIndex = 14;
            aliquotaPurchaseColumn.Visible = false;
            aliquotaPurchaseColumn.HeaderText = "IVA";
            aliquotaPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aliquotaPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var notePurchaseColumn = dgvDataAcquisto.Columns["NOTE"];
            notePurchaseColumn.DisplayIndex = 15;
            notePurchaseColumn.Visible = false;
            notePurchaseColumn.HeaderText = "NOTE";
            notePurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            notePurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notePurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notePurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var timestampPurchaseColumn = dgvDataAcquisto.Columns["TIMESTAMP"];
            timestampPurchaseColumn.DisplayIndex = 16;
            timestampPurchaseColumn.Visible = false;
            timestampPurchaseColumn.HeaderText = "TIMESTAMP";
            timestampPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timestampPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        private void PurchaseEditForm_KeyPress(object sender, KeyPressEventArgs e)
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










