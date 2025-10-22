using PlannerShop.Data;
using System.Data;


namespace PlannerShop.Forms
{
    public partial class PurchaseEditForm : Form
    {
        DateTime timeStamp;
        string idCliente;

        public PurchaseEditForm(string IdCliente)
        {
            InitializeComponent();

            timeStamp = DateTime.Now;

            idCliente = IdCliente;

            dgvData.DataSource = ModelProdotti.getProdotti();
            SetProductDataGridStructure();

            Utils.SetDataGridStyle(dgvData, false, 40, 30);
            Utils.SetDataGridStyle(dgvDataAcquisto, false, 40, 30);
            loadClienteData();

            dgvDataAcquisto.DataSource = ModelAcquisti.getAcquistiByIdCliente(idCliente, timeStamp.ToString());
            SetPurchaseDataGridStructure();
        }

        private void loadClienteData()
        {
            DataTable dtCliente = ModelClienti.getClienteById(idCliente);
            lblName.Text = dtCliente.Rows[0]["NOME"].ToString()!.ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString()!.ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO_MOBILE"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();
        }

        void SetProductDataGridStructure()
        {
            int fontSize = 8;

            var idProductColumn = dgvData.Columns["IDPRODOTTO"];
            idProductColumn.DisplayIndex = 0;
            idProductColumn.Visible = false;
            idProductColumn.HeaderText = "IDPRODOTTO";
            idProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataProductColumn = dgvData.Columns["DATA"];
            dataProductColumn.DisplayIndex = 1;
            dataProductColumn.Visible = false;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaProductColumn = dgvData.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 2;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            marcaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            marcaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizioneProductColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneProductColumn.DisplayIndex = 3;
            descrizioneProductColumn.Visible = true;
            descrizioneProductColumn.HeaderText = "DESCRIZIONE";
            descrizioneProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            descrizioneProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var aliquotaProductColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaProductColumn.DisplayIndex = 4;
            aliquotaProductColumn.Visible = false;
            aliquotaProductColumn.HeaderText = "IVA";
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var qntProductColumn = dgvData.Columns["QNT"];
            qntProductColumn.DisplayIndex = 5;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoProductColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 6;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "PREZZO NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoProductColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 7;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "PREZZO IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 8;
            noteProductionColumn.Visible = false;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            if (dgvData.Rows[e.RowIndex].Cells[0].Value == null) return;
            String idProdotto = dgvData.Rows[e.RowIndex].Cells["IDPRODOTTO"].Value.ToString()!;

            DataTable DTproductRow = ModelProdotti.getProdottoById(idProdotto);

            if (!int.TryParse(DTproductRow.Rows[0]["QNT"].ToString(), out int intQnt)) return;

            if (intQnt > 1)
            {
                ModelProdotti.updateQuantity(idProdotto, intQnt - 1);
            }
            else
            {
                ModelProdotti.deleteProdotto(idProdotto);
            }

            dgvData.DataSource = ModelProdotti.getProdotti();
            
            DataTable dt = ModelAcquisti.getAcquistiByIdClienteAndProductId(idCliente, idProdotto);
            if (dt.Rows.Count == 0)
            {
                ModelAcquisti.addAcquisto(
                    DTproductRow.Rows[0]["MARCA"].ToString()!,
                    DTproductRow.Rows[0]["DESCRIZIONE"].ToString()!,
                    1.ToString(),
                    DTproductRow.Rows[0]["PREZZO_NETTO"].ToString()!,
                    DTproductRow.Rows[0]["PREZZO_IVATO"].ToString()!,
                    DTproductRow.Rows[0]["DATA"].ToString()!,
                    idCliente,
                    idProdotto,
                    DTproductRow.Rows[0]["ALIQUOTA"].ToString()!,
                    DTproductRow.Rows[0]["NOTE"].ToString()!,
                    timeStamp.ToString()
                    );
            }
            else
            {
                if (!int.TryParse(dt.Rows[0]["QNT"].ToString(), out int qnt)) return;
                ModelAcquisti.updateQuantity(idProdotto, idCliente, ++qnt);
            }

            dgvDataAcquisto.DataSource = ModelAcquisti.getAcquistiByIdCliente(idCliente, timeStamp.ToString());

            dgvDataAcquisto.ClearSelection();
            dgvData.ClearSelection();
        }

        private void dgvDataAcquisto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvDataAcquisto.Rows[e.RowIndex].Cells["IDPRODOTTO"].Value == null) return;
            String idProdotto = dgvDataAcquisto.Rows[e.RowIndex].Cells["IDPRODOTTO"].Value.ToString()!;

            DataTable DTacquistoRow = ModelAcquisti.getAcquistiByIdClienteAndProductId(idCliente, idProdotto);
            if (!int.TryParse(DTacquistoRow.Rows[0]["QNT"].ToString(), out int intQnt)) return;

            DataTable DTproductRow = ModelProdotti.getProdottoById(idProdotto);

            if (DTproductRow.Rows.Count == 0)
            {
                ModelProdotti.addProdotto(
                    DTacquistoRow.Rows[0]["DATA"].ToString()!,
                    DTacquistoRow.Rows[0]["MARCA"].ToString()!,
                    DTacquistoRow.Rows[0]["DESCRIZIONE"].ToString()!,
                    DTacquistoRow.Rows[0]["ALIQUOTA"].ToString()!,
                    1.ToString(),
                    DTacquistoRow.Rows[0]["PREZZO_NETTO"].ToString()!,
                    DTacquistoRow.Rows[0]["PREZZO_IVATO"].ToString()!,
                    DTacquistoRow.Rows[0]["NOTE"].ToString()!,
                    DTacquistoRow.Rows[0]["IDPRODOTTO"].ToString()!
                    );
            }
            else
            {
                if (!int.TryParse(DTproductRow.Rows[0]["QNT"].ToString(), out int intQntPrd)) return;
                ModelProdotti.updateQuantity(idProdotto, ++intQntPrd);
            }

            dgvData.DataSource = ModelProdotti.getProdotti();

            
            if (intQnt > 1)
            {
                ModelAcquisti.updateQuantity(idProdotto, idCliente, intQnt - 1);
            }
            else
            {
                ModelAcquisti.deleteAcquisto(idProdotto, idCliente);
            }

            dgvDataAcquisto.DataSource = ModelAcquisti.getAcquistiByIdCliente(idCliente, timeStamp.ToString());

            dgvData.ClearSelection();
            dgvDataAcquisto.ClearSelection();
        }

    }
}

