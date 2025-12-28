using PlannerShop.Data;
using System.Data;


namespace PlannerShop.Forms
{
    public partial class ProductPurchaseEditForm : Form
    {
        private DataTable dtProdottiTemp;
        private DataTable dtAcquistiTemp;
        private DataTable dtCliente;

        DateTime timeStamp;
        string idCliente;

        public ProductPurchaseEditForm(string IdCliente)
        {
            InitializeComponent();

            idCliente = IdCliente;
            timeStamp = DateTime.Now;

            // Copie locali
            dtProdottiTemp = ModelProdotti.getExistingProdotti().Copy();
            dtAcquistiTemp = ModelAcquisti.getAcquistiByIdClienteAndTimestamp(idCliente, timeStamp.ToString()).Copy();

            dgvData.DataSource = dtProdottiTemp;
            SetProductDataGridStructure();

            DgvUtils.SetDataGridStyle(dgvData, false, 40, 40, true);
            dgvData.DefaultCellStyle.SelectionBackColor = dgvData.DefaultCellStyle.BackColor;
            DgvUtils.SetDataGridStyle(dgvDataAcquisto, false, 40, 40, true);
            dgvDataAcquisto.DefaultCellStyle.SelectionBackColor = dgvDataAcquisto.DefaultCellStyle.BackColor;
            loadClienteData();

            dgvDataAcquisto.DataSource = dtAcquistiTemp;
            SetPurchaseDataGridStructure();

            dgvDataAcquisto.CellFormatting += dgvDataAcquisto_CellFormatting;
        }

        private void loadClienteData()
        {
            dtCliente = ModelClienti.getClienteById(idCliente);
            lblName.Text = dtCliente.Rows[0]["NOME"].ToString()!.ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString()!.ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();
        }

        void SetProductDataGridStructure()
        {
            int fontSize = 10;

            var idProductColumn = dgvData.Columns["IDPRODOTTO"];
            idProductColumn.DisplayIndex = 0;
            idProductColumn.Visible = false;
            idProductColumn.HeaderText = "IDPRODOTTO";
            idProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataProductColumn = dgvData.Columns["DATA"];
            dataProductColumn.DisplayIndex = 1;
            dataProductColumn.Visible = false;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaProductColumn = dgvData.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 2;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            marcaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizioneProductColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneProductColumn.DisplayIndex = 3;
            descrizioneProductColumn.Visible = true;
            descrizioneProductColumn.HeaderText = "DESCRIZIONE";
            descrizioneProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var aliquotaProductColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaProductColumn.DisplayIndex = 4;
            aliquotaProductColumn.Visible = false;
            aliquotaProductColumn.HeaderText = "IVA";
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var qntProductColumn = dgvData.Columns["QNT"];
            qntProductColumn.DisplayIndex = 5;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoProductColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 6;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoProductColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 7;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoVenditaProductColumn = dgvData.Columns["PREZZO_VENDITA"];
            prezzoVenditaProductColumn.DisplayIndex = 8;
            prezzoVenditaProductColumn.Visible = true;
            prezzoVenditaProductColumn.HeaderText = "VENDITA";
            prezzoVenditaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prezzoVenditaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoVenditaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 9;
            noteProductionColumn.Visible = false;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        void SetPurchaseDataGridStructure()
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
            marcaPurchaseColumnn.Visible = true;
            marcaPurchaseColumnn.HeaderText = "MARCA";
            marcaPurchaseColumnn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            marcaPurchaseColumnn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaPurchaseColumnn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var nomePurchaseColumnn = dgvDataAcquisto.Columns["NOME"];
            nomePurchaseColumnn.DisplayIndex = 2;
            nomePurchaseColumnn.Visible = false;
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
            qntPurchaseColumnn.Visible = true;
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
            totalePurchaseColumn.HeaderText = "TOTALE";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtProdottiTemp = ModelProdotti.searchProdotti(txtSearch.Text);
            dgvData.DataSource = dtProdottiTemp;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow row = dtProdottiTemp.Rows[e.RowIndex];

            ProductPurchaseDetaIlForm purchaseDetailForm = new ProductPurchaseDetaIlForm(row, dtCliente);
            DialogResult result = purchaseDetailForm.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            string idProdotto = row["IDPRODOTTO"]?.ToString() ?? string.Empty;

            string marca = row["MARCA"]?.ToString() ?? string.Empty;
            string descrizione = row["DESCRIZIONE"]?.ToString() ?? string.Empty;
            string prezzoNetto = row["PREZZO_NETTO"]?.ToString() ?? string.Empty;
            string prezzoIvato = row["PREZZO_IVATO"]?.ToString() ?? string.Empty;
            string prezzoVendita = row["PREZZO_VENDITA"]?.ToString() ?? string.Empty;
            string totale = purchaseDetailForm.lblTotaleCalcolato.Text;
            string aliquota = row["ALIQUOTA"]?.ToString() ?? string.Empty;
            string data = row["DATA"]?.ToString() ?? string.Empty;
            string note = row["NOTE"]?.ToString() ?? string.Empty;

            if (!int.TryParse(purchaseDetailForm.nudQnt.Value.ToString(), out int qnt))
            {
                qnt = 0;
            }

            if (!int.TryParse(row["QNT"].ToString(), out int actualQnt))
            {
                actualQnt = 0;
            }

            if (qnt > 0)
                row["QNT"] = actualQnt - qnt;
            else
                return;

            DataRow[] acquistoEsistente = dtAcquistiTemp.Select($"IDPRODOTTO = '{idProdotto}'");

            if (acquistoEsistente.Length == 0)
            {
                DataRow newAcq = dtAcquistiTemp.NewRow();

                newAcq["IDPRODOTTO"] = idProdotto;
                newAcq["IDCLIENTE"] = idCliente;
                newAcq["MARCA"] = marca;
                newAcq["DESCRIZIONE"] = descrizione;
                newAcq["PREZZO_NETTO"] = prezzoNetto;
                newAcq["PREZZO_IVATO"] = prezzoIvato;
                newAcq["PREZZO_VENDITA"] = prezzoVendita;

                decimal totaleVendita = decimal.Parse(totale.Replace("€", "").Trim());
                newAcq["TOTALE"] = totaleVendita.ToString("F2") + "€";
                newAcq["ALIQUOTA"] = aliquota;
                newAcq["DATA"] = data;
                newAcq["NOTE"] = note;
                newAcq["TIMESTAMP"] = timeStamp.ToString();
                newAcq["QNT"] = qnt;
                newAcq["SCONTO"] = calculateSconto(newAcq);

                dtAcquistiTemp.Rows.Add(newAcq);
            }
            else
            {
                DataRow acq = acquistoEsistente[0];

                int qVecchia = int.Parse(acq["QNT"].ToString());
                acq["QNT"] = qVecchia + qnt;

                decimal vecchioTotale = decimal.Parse(acq["TOTALE"].ToString().Replace("€", ""));
                decimal nuovoTotale = decimal.Parse(totale.Replace("€", "").Trim());
                acq["TOTALE"] = (vecchioTotale + nuovoTotale).ToString("F2") + "€";
                acq["SCONTO"] = calculateSconto(acq);

            }

            dgvData.Refresh();
            dgvDataAcquisto.Refresh();

            dgvData.ClearSelection();
            dgvDataAcquisto.ClearSelection();
        }

        private void dgvDataAcquisto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow acqRow = ((DataRowView)dgvDataAcquisto.Rows[e.RowIndex].DataBoundItem).Row;
            string idProdotto = acqRow["IDPRODOTTO"]?.ToString() ?? string.Empty;

            int qntAcq = Convert.ToInt32(acqRow["QNT"]);

            DataRow[] prdRows = dtProdottiTemp.Select($"IDPRODOTTO = '{idProdotto}'");

            if (prdRows.Length == 0)
            {
                DataRow newPrd = dtProdottiTemp.NewRow();

                newPrd["IDPRODOTTO"] = idProdotto;
                newPrd["DATA"] = acqRow["DATA"];
                newPrd["MARCA"] = acqRow["MARCA"];
                newPrd["DESCRIZIONE"] = acqRow["DESCRIZIONE"];
                newPrd["ALIQUOTA"] = acqRow["ALIQUOTA"];
                newPrd["PREZZO_NETTO"] = acqRow["PREZZO_NETTO"];
                newPrd["PREZZO_IVATO"] = acqRow["PREZZO_IVATO"];
                newPrd["PREZZO_VENDITA"] = acqRow["PREZZO_VENDITA"];
                newPrd["NOTE"] = acqRow["NOTE"];

                newPrd["QNT"] = 1;

                dtProdottiTemp.Rows.Add(newPrd);
            }
            else
            {
                int qntMag = Convert.ToInt32(prdRows[0]["QNT"]);
                prdRows[0]["QNT"] = qntMag + Convert.ToInt32(acqRow["QNT"]);
            }

            dtAcquistiTemp.Rows.Remove(acqRow);

            dgvData.Refresh();
            dgvDataAcquisto.Refresh();

            dgvData.ClearSelection();
            dgvDataAcquisto.ClearSelection();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtAcquistiTemp.Rows.Count == 0)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            UpdateProductStock(dtProdottiTemp);

            DataTable originalAcquisti =
                ModelAcquisti.getAcquistiByIdClienteAndTimestamp(
                    idCliente,
                    timeStamp.ToString()
                );

            SaveProductPurchases(dtAcquistiTemp, originalAcquisti, idCliente);

            Close();
        }


        private void UpdateProductStock(DataTable prodottiTemp)
        {
            foreach (DataRow row in prodottiTemp.Rows)
            {
                string idProdotto = row["IDPRODOTTO"]?.ToString() ?? string.Empty;

                if (!int.TryParse(row["QNT"]?.ToString(), out int qnt))
                    continue;

                ModelProdotti.updateQuantity(idProdotto, qnt);
            }
        }


        private void SaveProductPurchases(DataTable acquistiTemp, DataTable acquistiOriginali, string idCliente)
        {
            foreach (DataRow row in acquistiTemp.Rows)
            {
                string idProdotto = row["IDPRODOTTO"]?.ToString() ?? string.Empty;

                if (!int.TryParse(row["QNT"]?.ToString(), out int qnt) || qnt <= 0)
                    continue;

                bool exists = acquistiOriginali
                    .Select($"IDPRODOTTO = '{idProdotto}'")
                    .Length > 0;

                if (!exists)
                {
                    ModelAcquisti.addAcquisto(
                        row["MARCA"]?.ToString() ?? string.Empty,
                        string.Empty, // NOME non usato per prodotti
                        row["DESCRIZIONE"]?.ToString() ?? string.Empty,
                        qnt.ToString(),
                        row["PREZZO_NETTO"]?.ToString() ?? string.Empty,
                        row["PREZZO_IVATO"]?.ToString() ?? string.Empty,
                        row["PREZZO_VENDITA"]?.ToString() ?? string.Empty,
                        row["TOTALE"]?.ToString() ?? string.Empty,
                        calculateSconto(row),
                        row["DATA"]?.ToString() ?? string.Empty,
                        idCliente,
                        idProdotto,
                        string.Empty, // IDSERVIZIO = NULL
                        row["ALIQUOTA"]?.ToString() ?? string.Empty,
                        row["NOTE"]?.ToString() ?? string.Empty,
                        row["TIMESTAMP"]?.ToString() ?? string.Empty
                    );
                }
                else
                {
                    ModelAcquisti.updateQuantity(idProdotto, idCliente, qnt);
                }
            }
        }


        private string calculateSconto(DataRow row)
        {
            if (!decimal.TryParse(
                    row["PREZZO_VENDITA"]?.ToString()?.Replace("€", "").Trim(),
                    out decimal prezzoUnitario) ||
                !decimal.TryParse(
                    row["TOTALE"]?.ToString()?.Replace("€", "").Trim(),
                    out decimal totalePagato) ||
                !int.TryParse(row["QNT"]?.ToString(), out int qnt) ||
                prezzoUnitario <= 0 || qnt <= 0)
            {
                return "0%";
            }

            decimal totaleTeorico = prezzoUnitario * qnt;

            if (totalePagato >= totaleTeorico)
                return "0%";

            decimal sconto =
                (totaleTeorico - totalePagato) / totaleTeorico * 100m;

            return sconto.ToString("0.00") + "%";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDataAcquisto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvDataAcquisto.Columns[e.ColumnIndex].Name == "PREZZO_TOTALE")
            {
                var drv = dgvDataAcquisto.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (drv == null) return;

                decimal prezzoVendita = Convert.ToDecimal(drv["PREZZO_VENDITA"].ToString().Replace("€", ""));
                int qnt = Convert.ToInt32(drv["QNT"]);

                decimal totale = prezzoVendita * qnt;

                e.Value = totale.ToString("F2") + " €";
                e.FormattingApplied = true;
            }
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

