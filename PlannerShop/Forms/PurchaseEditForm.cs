using PlannerShop.Data;
using System.Data;


namespace PlannerShop.Forms
{
    public partial class PurchaseEditForm : Form
    {
        private DataTable dtProdottiTemp;
        private DataTable dtAcquistiTemp;

        DateTime timeStamp;
        string idCliente;

        public PurchaseEditForm(string IdCliente)
        {
            InitializeComponent();

            idCliente = IdCliente;
            timeStamp = DateTime.Now;

            // Copie locali
            dtProdottiTemp = ModelProdotti.getProdotti().Copy();
            dtAcquistiTemp = ModelAcquisti.getAcquistiByIdCliente(idCliente, timeStamp.ToString()).Copy();

            dgvData.DataSource = dtProdottiTemp;
            SetProductDataGridStructure();

            Utils.SetDataGridStyle(dgvData, false, 40, 40);
            Utils.SetDataGridStyle(dgvDataAcquisto, false, 40, 40);
            loadClienteData();

            dgvDataAcquisto.DataSource = dtAcquistiTemp;
            SetPurchaseDataGridStructure();
        }

        private void loadClienteData()
        {
            DataTable dtCliente = ModelClienti.getClienteById(idCliente);
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
            idProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataProductColumn = dgvData.Columns["DATA"];
            dataProductColumn.DisplayIndex = 1;
            dataProductColumn.Visible = false;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaProductColumn = dgvData.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 2;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var qntProductColumn = dgvData.Columns["QNT"];
            qntProductColumn.DisplayIndex = 5;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoProductColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 6;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoProductColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 7;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 8;
            noteProductionColumn.Visible = false;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        void SetPurchaseDataGridStructure()
        {
            int fontSize = 8;

            var idPurchaseColumn = dgvDataAcquisto.Columns["IDACQUISTO"];
            idPurchaseColumn.DisplayIndex = 0;
            idPurchaseColumn.Visible = false;
            idPurchaseColumn.HeaderText = "IDACQUISTO";
            idPurchaseColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idPurchaseColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idPurchaseColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idPurchaseColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaProductColumn = dgvDataAcquisto.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 1;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            marcaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            marcaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizioneProductColumn = dgvDataAcquisto.Columns["DESCRIZIONE"];
            descrizioneProductColumn.DisplayIndex = 2;
            descrizioneProductColumn.Visible = true;
            descrizioneProductColumn.HeaderText = "DESCRIZIONE";
            descrizioneProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            descrizioneProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var qntProductColumn = dgvDataAcquisto.Columns["QNT"];
            qntProductColumn.DisplayIndex = 3;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoProductColumn = dgvDataAcquisto.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 4;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "PREZZO NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoProductColumn = dgvDataAcquisto.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 5;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "PREZZO IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataProductColumn = dgvDataAcquisto.Columns["DATA"];
            dataProductColumn.DisplayIndex = 6;
            dataProductColumn.Visible = false;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idClientColumn = dgvDataAcquisto.Columns["IDCLIENTE"];
            idClientColumn.DisplayIndex = 7;
            idClientColumn.Visible = false;
            idClientColumn.HeaderText = "IDCLIENTE";
            idClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idClientColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var idProducrColumn = dgvDataAcquisto.Columns["IDPRODOTTO"];
            idProducrColumn.DisplayIndex = 8;
            idProducrColumn.Visible = false;
            idProducrColumn.HeaderText = "IDPRODOTTO";
            idProducrColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idProducrColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProducrColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idProducrColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var aliquotaProductColumn = dgvDataAcquisto.Columns["ALIQUOTA"];
            aliquotaProductColumn.DisplayIndex = 9;
            aliquotaProductColumn.Visible = false;
            aliquotaProductColumn.HeaderText = "IVA";
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductionColumn = dgvDataAcquisto.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 10;
            noteProductionColumn.Visible = false;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var timestampProductionColumn = dgvDataAcquisto.Columns["TIMESTAMP"];
            timestampProductionColumn.DisplayIndex = 11;
            timestampProductionColumn.Visible = false;
            timestampProductionColumn.HeaderText = "TIMESTAMP";
            timestampProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timestampProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            timestampProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != String.Empty && dgvData.Rows.Count > 0)
            {
                {
                    foreach (DataGridViewRow dgvr in dgvData.Rows)
                    {
                        try
                        {
                            String data = dgvr.Cells["DATA"]?.Value?.ToString()?.ToLower() ?? String.Empty;
                            String marca = dgvr.Cells["MARCA"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String descrizione = dgvr.Cells["DESCRIZIONE"].Value?.ToString()?.ToLower() ?? String.Empty;

                            if (data.Contains(txtSearch.Text.ToLower())
                                || marca.Contains(txtSearch.Text.ToLower())
                                || descrizione.Contains(txtSearch.Text.ToLower()))
                            {
                                dgvData.ClearSelection();
                                dgvData.Rows[dgvr.Index].Selected = true;
                                dgvData.FirstDisplayedScrollingRowIndex = dgvData.SelectedRows[0].Index;
                                return;
                            }
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRow row = dtProdottiTemp.Rows[e.RowIndex];
            string idProdotto = row["IDPRODOTTO"]?.ToString() ?? string.Empty;

            string marca = row["MARCA"]?.ToString() ?? string.Empty;
            string descrizione = row["DESCRIZIONE"]?.ToString() ?? string.Empty;
            string prezzoNetto = row["PREZZO_NETTO"]?.ToString() ?? string.Empty;
            string prezzoIvato = row["PREZZO_IVATO"]?.ToString() ?? string.Empty;
            string aliquota = row["ALIQUOTA"]?.ToString() ?? string.Empty;
            string data = row["DATA"]?.ToString() ?? string.Empty;
            string note = row["NOTE"]?.ToString() ?? string.Empty;

            if (!int.TryParse(row["QNT"]?.ToString(), out int qnt))
            {
                qnt = 0;
            }

            if (qnt > 1)
                row["QNT"] = qnt - 1;
            else
                dtProdottiTemp.Rows.Remove(row);

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
                newAcq["ALIQUOTA"] = aliquota;
                newAcq["DATA"] = data;
                newAcq["NOTE"] = note;
                newAcq["TIMESTAMP"] = timeStamp.ToString();
                newAcq["QNT"] = 1;

                dtAcquistiTemp.Rows.Add(newAcq);
            }
            else
            {
                if (!int.TryParse(acquistoEsistente[0]["QNT"]?.ToString(), out int q))
                {
                    q = 0;
                }

                acquistoEsistente[0]["QNT"] = q + 1;
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
                newPrd["NOTE"] = acqRow["NOTE"];

                newPrd["QNT"] = 1;

                dtProdottiTemp.Rows.Add(newPrd);
            }
            else
            {
                int qntMag = Convert.ToInt32(prdRows[0]["QNT"]);
                prdRows[0]["QNT"] = qntMag + 1;
            }

            if (qntAcq > 1)
            {
                acqRow["QNT"] = qntAcq - 1;
            }
            else
            {
                dtAcquistiTemp.Rows.Remove(acqRow);
            }

            dgvData.Refresh();
            dgvDataAcquisto.Refresh();

            dgvData.ClearSelection();
            dgvDataAcquisto.ClearSelection();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataTable originalProducts = ModelProdotti.getProdotti();

            foreach (DataRow tempRow in dtProdottiTemp.Rows)
            {
                string id = tempRow["IDPRODOTTO"]?.ToString() ?? string.Empty;
                int qnt = Convert.ToInt32(tempRow["QNT"]);

                string data = tempRow["DATA"]?.ToString() ?? string.Empty;
                string marca = tempRow["MARCA"]?.ToString() ?? string.Empty;
                string descrizione = tempRow["DESCRIZIONE"]?.ToString() ?? string.Empty;
                string aliquota = tempRow["ALIQUOTA"]?.ToString() ?? string.Empty;
                string prezzoNetto = tempRow["PREZZO_NETTO"]?.ToString() ?? string.Empty;
                string prezzoIvato = tempRow["PREZZO_IVATO"]?.ToString() ?? string.Empty;
                string note = tempRow["NOTE"]?.ToString() ?? string.Empty;

                DataRow[] found = originalProducts.Select($"IDPRODOTTO = '{id}'");

                if (found.Length == 0)
                {
                    ModelProdotti.addProdotto(
                        data,
                        marca,
                        descrizione,
                        aliquota,
                        qnt.ToString(),
                        prezzoNetto,
                        prezzoIvato,
                        note,
                        id
                    );
                }
                else
                {
                    ModelProdotti.updateQuantity(id, qnt);
                }
            }

            foreach (DataRow orig in originalProducts.Rows)
            {
                string id = orig["IDPRODOTTO"]?.ToString() ?? string.Empty;

                bool stillExists = dtProdottiTemp.AsEnumerable()
                    .Any(r => r["IDPRODOTTO"].ToString() == id);

                if (!stillExists)
                {
                    ModelProdotti.deleteProdotto(id);
                }
            }

            DataTable originalAcquisti =
                ModelAcquisti.getAcquistiByIdCliente(idCliente, timeStamp.ToString());

            foreach (DataRow temp in dtAcquistiTemp.Rows)
            {
                string idProdotto = temp["IDPRODOTTO"]?.ToString() ?? string.Empty;
                int qnt = Convert.ToInt32(temp["QNT"]);

                string marca = temp["MARCA"]?.ToString() ?? string.Empty;
                string descrizione = temp["DESCRIZIONE"]?.ToString() ?? string.Empty;
                string prezzoNetto = temp["PREZZO_NETTO"]?.ToString() ?? string.Empty;
                string prezzoIvato = temp["PREZZO_IVATO"]?.ToString() ?? string.Empty;
                string dataAcquisto = temp["DATA"]?.ToString() ?? string.Empty;
                string aliquota = temp["ALIQUOTA"]?.ToString() ?? string.Empty;
                string note = temp["NOTE"]?.ToString() ?? string.Empty;
                string timeStampValue = temp["TIMESTAMP"]?.ToString() ?? string.Empty;

                DataRow[] found = originalAcquisti.Select($"IDPRODOTTO = '{idProdotto}'");

                if (found.Length == 0)
                {
                    ModelAcquisti.addAcquisto(
                        marca,
                        descrizione,
                        qnt.ToString(),
                        prezzoNetto,
                        prezzoIvato,
                        dataAcquisto,
                        idCliente,
                        idProdotto,
                        aliquota,
                        note,
                        timeStampValue
                    );
                }
                else
                {
                    ModelAcquisti.updateQuantity(idProdotto, idCliente, qnt);
                }
            }

            foreach (DataRow orig in originalAcquisti.Rows)
            {
                string idProdotto = orig["IDPRODOTTO"]?.ToString() ?? string.Empty;

                bool stillExists = dtAcquistiTemp.AsEnumerable()
                    .Any(r => r["IDPRODOTTO"].ToString() == idProdotto);

                if (!stillExists)
                {
                    ModelAcquisti.deleteAcquisto(idProdotto, idCliente);
                }
            }

            MessageBox.Show("Modifiche confermate.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

