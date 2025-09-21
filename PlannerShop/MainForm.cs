
using PlannerShop.Data;
using PlannerShop.Forms;

namespace PlannerShop
{
    public partial class MainForm : Form
    {
        bool isClienteSelected = false;
        bool isFornitoreSelected = false;
        bool isProdottoSelected = false;

        Color btnDefaultColor;

        public MainForm()
        {
            InitializeComponent();

            Utils.SetDataGridStyle(dgvData, true, 50, 40);
            LoadClienti();

            if (ModelPwd.IsEnabled())
                btnLogout.Visible = true;
            else
                btnLogout.Visible = false;

            btnDefaultColor = Color.White;
            btnClienti.BackColor = Color.FromArgb(90, 192, 192, 255);
        }

        void SetClientDataGridStructure()
        {
            int fontSize = 10;

            var idClientColumn = dgvData.Columns["IDCLIENTE"];
            idClientColumn.DisplayIndex = 0;
            idClientColumn.Visible = false;
            idClientColumn.HeaderText = "IDCLIENTE";
            idClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idClientColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var nomeClientColumn = dgvData.Columns["NOME"];
            nomeClientColumn.DisplayIndex = 1;
            nomeClientColumn.Visible = true;
            nomeClientColumn.HeaderText = "NOME";
            nomeClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nomeClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nomeClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeClientColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var cognomeClientColumn = dgvData.Columns["COGNOME"];
            cognomeClientColumn.DisplayIndex = 2;
            cognomeClientColumn.Visible = true;
            cognomeClientColumn.HeaderText = "COGNOME";
            cognomeClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cognomeClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cognomeClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cognomeClientColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataNascitaClientColumn = dgvData.Columns["DATA_NASCITA"];
            dataNascitaClientColumn.DisplayIndex = 3;
            dataNascitaClientColumn.Visible = true;
            dataNascitaClientColumn.HeaderText = "DATA DI NASCITA";
            dataNascitaClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNascitaClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataNascitaClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataNascitaClientColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);
            
            var indirizzoSupplierColumn = dgvData.Columns["INDIRIZZO"];
            indirizzoSupplierColumn.DisplayIndex = 4;
            indirizzoSupplierColumn.Visible = true;
            indirizzoSupplierColumn.HeaderText = "INDIRIZZO";
            indirizzoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indirizzoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            indirizzoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            indirizzoSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var telefonoFissoSupplierColumn = dgvData.Columns["TELEFONO_FISSO"];
            telefonoFissoSupplierColumn.DisplayIndex = 5;
            telefonoFissoSupplierColumn.Visible = true;
            telefonoFissoSupplierColumn.HeaderText = "TEL. FISSO";
            telefonoFissoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoFissoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            telefonoFissoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            telefonoFissoSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var telefonoMobileSupplierColumn = dgvData.Columns["TELEFONO_MOBILE"];
            telefonoMobileSupplierColumn.DisplayIndex = 6;
            telefonoMobileSupplierColumn.Visible = true;
            telefonoMobileSupplierColumn.HeaderText = "TEL. CELLULARE";
            telefonoMobileSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoMobileSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            telefonoMobileSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            telefonoMobileSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var emailSupplierColumn = dgvData.Columns["EMAIL"];
            emailSupplierColumn.DisplayIndex = 7;
            emailSupplierColumn.Visible = true;
            emailSupplierColumn.HeaderText = "EMAIL";
            emailSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            emailSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            emailSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductColumn = dgvData.Columns["NOTE"];
            noteProductColumn.DisplayIndex = 8;
            noteProductColumn.Visible = true;
            noteProductColumn.HeaderText = "NOTE";
            noteProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        void SetProductDataGridStructure()
        {
            int fontSize = 10;

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
            dataProductColumn.Visible = true;
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
            aliquotaProductColumn.Visible = true;
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
            noteProductionColumn.Visible = true;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        void SetSupplierDataGridStructure()
        {
            int fontSize = 10;

            var idSupplierColumn = dgvData.Columns["IDFORNITORE"];
            idSupplierColumn.DisplayIndex = 0;
            idSupplierColumn.Visible = false;
            idSupplierColumn.HeaderText = "IDFORNITORE";
            idSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var nomeSupplierColumn = dgvData.Columns["NOME"];
            nomeSupplierColumn.DisplayIndex = 1;
            nomeSupplierColumn.Visible = true;
            nomeSupplierColumn.HeaderText = "NOME";
            nomeSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nomeSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nomeSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var indirizzoSupplierColumn = dgvData.Columns["INDIRIZZO"];
            indirizzoSupplierColumn.DisplayIndex = 2;
            indirizzoSupplierColumn.Visible = true;
            indirizzoSupplierColumn.HeaderText = "INDIRIZZO";
            indirizzoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indirizzoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            indirizzoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            indirizzoSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var telefonoFissoSupplierColumn = dgvData.Columns["TELEFONO_FISSO"];
            telefonoFissoSupplierColumn.DisplayIndex = 3;
            telefonoFissoSupplierColumn.Visible = true;
            telefonoFissoSupplierColumn.HeaderText = "TEL. FISSO";
            telefonoFissoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoFissoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            telefonoFissoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            telefonoFissoSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var telefonoMobileSupplierColumn = dgvData.Columns["TELEFONO_MOBILE"];
            telefonoMobileSupplierColumn.DisplayIndex = 4;
            telefonoMobileSupplierColumn.Visible = true;
            telefonoMobileSupplierColumn.HeaderText = "TEL. CELLULARE";
            telefonoMobileSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoMobileSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            telefonoMobileSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            telefonoMobileSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var emailSupplierColumn = dgvData.Columns["EMAIL"];
            emailSupplierColumn.DisplayIndex = 5;
            emailSupplierColumn.Visible = true;
            emailSupplierColumn.HeaderText = "EMAIL";
            emailSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            emailSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            emailSupplierColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);



            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 6;
            noteProductionColumn.Visible = true;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        void LoadClienti()
        {
            isClienteSelected = true;
            isFornitoreSelected = false;
            isProdottoSelected = false;
            dgvData.DataSource = ModelClienti.getClienti();
            SetClientDataGridStructure();
        }

        void LoadFornitori()
        {
            isClienteSelected = false;
            isFornitoreSelected = true;
            isProdottoSelected = false;
            dgvData.DataSource = ModelFornitori.getFornitori();
            SetSupplierDataGridStructure();
        }

        void LoadProdotti()
        {
            isClienteSelected = false;
            isFornitoreSelected = false;
            isProdottoSelected = true;
            dgvData.DataSource = ModelProdotti.getProdotti();
            SetProductDataGridStructure();
        }

        private void btnProdotti_Click(object sender, EventArgs e)
        {
            LoadProdotti();
            btnClienti.BackColor = btnDefaultColor;
            btnProdotti.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnFornitori.BackColor = btnDefaultColor;
            EnableDisableEditAndInsert();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            LoadClienti();
            btnClienti.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnProdotti.BackColor = btnDefaultColor;
            btnFornitori.BackColor = btnDefaultColor;
            EnableDisableEditAndInsert();
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            LoadFornitori();
            btnClienti.BackColor = btnDefaultColor;
            btnProdotti.BackColor = btnDefaultColor;
            btnFornitori.BackColor = Color.FromArgb(90, 192, 192, 255); 
            EnableDisableEditAndInsert();
        }

        private void btnStatistiche_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm();
            statsForm.ShowDialog();
        }

        private void btnOpzioni_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            if (settingsForm.chkAccessMode.Checked)
                btnLogout.Visible = true;
            else
                btnLogout.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgn = new LoginForm();
            lgn.ShowDialog();
            if (lgn.logged)
                this.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isClienteSelected)
            {
                ClientInsertForm clientInsertForm = new ClientInsertForm();
                clientInsertForm.ShowDialog();
                if (clientInsertForm.isDone)
                    dgvData.DataSource = ModelClienti.getClienti();
            }
            else if (isProdottoSelected)
            {
                ProductInsertForm productInsertForm = new ProductInsertForm();
                productInsertForm.ShowDialog();
                if (productInsertForm.isDone)
                    dgvData.DataSource = ModelProdotti.getProdotti();
            }
            else if (isFornitoreSelected)
            {
                SupplierInsertForm supplierInsertForm = new SupplierInsertForm();
                supplierInsertForm.ShowDialog();
                if (supplierInsertForm.isDone)
                    dgvData.DataSource = ModelFornitori.getFornitori();
            }
            EnableDisableEditAndInsert();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                return;
            }

            int selected = dgvData.SelectedRows[0].Index;
            int displayPos = dgvData.FirstDisplayedScrollingRowIndex;
            String? selectedId = null;

            if (isClienteSelected)
            {
                selectedId = dgvData.SelectedRows[0].Cells["IDCLIENTE"].Value?.ToString();
                if (!String.IsNullOrEmpty(selectedId))
                {
                    ClientEditForm clientiEditForm = new ClientEditForm(selectedId);
                    clientiEditForm.ShowDialog();

                    if (clientiEditForm.isDelete)
                    {
                        LoadClienti();
                        SelectAfterDelete(selected, displayPos, 1);
                    }
                    else
                    {
                        LoadClienti();
                        SelectRowById(selectedId, "IDCLIENTE", displayPos);
                    }
                }
            }
            else if (isProdottoSelected)
            {
                selectedId = dgvData.SelectedRows[0].Cells["IDPRODOTTO"].Value?.ToString();
                if (!String.IsNullOrEmpty(selectedId))
                {
                    ProductEditForm productEditForm = new ProductEditForm(selectedId);
                    productEditForm.ShowDialog();

                    if (productEditForm.isDelete)
                    {
                        LoadProdotti();
                        SelectAfterDelete(selected, displayPos, 1);
                    }
                    else
                    {
                        LoadProdotti();
                        SelectRowById(selectedId, "IDPRODOTTO", displayPos);
                    }
                }
            }
            else if (isFornitoreSelected)
            {
                selectedId = dgvData.SelectedRows[0].Cells["IDFORNITORE"].Value?.ToString();
                if (!String.IsNullOrEmpty(selectedId))
                {
                    SupplierEditForm supplierEditForm = new SupplierEditForm(selectedId);
                    supplierEditForm.ShowDialog();

                    if (supplierEditForm.isDelete)
                    {
                        LoadFornitori();
                        SelectAfterDelete(selected, displayPos, 1);
                    }
                    else
                    {
                        LoadFornitori();
                        SelectRowById(selectedId, "IDFORNITORE", displayPos);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvData.Rows.Count==0) { return; }
            List<String> idsToDelete = new List<String>();
            int firstSelectedIndex = dgvData.SelectedRows[0].Index;
            int displayPos = dgvData.FirstDisplayedScrollingRowIndex;

            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                String? id = row.Cells[0].Value?.ToString();
                if (!String.IsNullOrEmpty(id))
                {
                    idsToDelete.Add(id);
                }
            }

            if (idsToDelete.Count == 0) return;

            String message = idsToDelete.Count == 1
                ? $"Sei sicuro di voler eliminare l'elemento selezionato?"
                : $"Sei sicuro di voler eliminare i {idsToDelete.Count} elementi selezionati?";

            DeleteForm dltFrm = new DeleteForm(message);
            dltFrm.ShowDialog();

            if (dltFrm.result)
            {
                foreach (String id in idsToDelete)
                {
                    if (isClienteSelected)
                    {
                        ModelClienti.deleteCliente(id);
                    }
                    if (isFornitoreSelected)
                    {
                        ModelFornitori.deleteFornitore(id);
                    }
                    if (isProdottoSelected)
                    {
                        ModelProdotti.deleteProdotto(id);
                    }
                }
                if (isClienteSelected)
                {
                    LoadClienti();
                }
                if (isFornitoreSelected)
                {
                    LoadFornitori();
                }
                if (isProdottoSelected)
                {
                    LoadProdotti();
                }

                SelectAfterDelete(firstSelectedIndex, displayPos, idsToDelete.Count);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != String.Empty && dgvData.Rows.Count > 0)
            {
                if (isClienteSelected)
                {
                    foreach (DataGridViewRow dgvr in dgvData.Rows)
                    {
                        try
                        {
                            String nome = dgvr.Cells["NOME"]?.Value?.ToString()?.ToLower() ?? String.Empty;
                            String cognome = dgvr.Cells["COGNOME"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String indirizzo = dgvr.Cells["INDIRIZZO"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String telefonoMobile = dgvr.Cells["TELEFONO_MOBILE"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String email = dgvr.Cells["EMAIL"].Value?.ToString()?.ToLower() ?? String.Empty;

                            if (nome.Contains(txtSearch.Text.ToLower())
                                || cognome.Contains(txtSearch.Text.ToLower())
                                || indirizzo.Contains(txtSearch.Text.ToLower())
                                || telefonoMobile.Contains(txtSearch.Text.ToLower())
                                || email.Contains(txtSearch.Text.ToLower())
                                )
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
                if (isFornitoreSelected)
                {
                    foreach (DataGridViewRow dgvr in dgvData.Rows)
                    {
                        try
                        {
                            String nome = dgvr.Cells["NOME"]?.Value?.ToString()?.ToLower() ?? String.Empty;
                            String indirizzo = dgvr.Cells["INDIRIZZO"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String telefonoMobile = dgvr.Cells["TELEFONO_MOBILE"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String email = dgvr.Cells["EMAIL"].Value?.ToString()?.ToLower() ?? String.Empty;

                            if (nome.Contains(txtSearch.Text.ToLower())
                                || indirizzo.Contains(txtSearch.Text.ToLower())
                                || telefonoMobile.Contains(txtSearch.Text.ToLower())
                                || email.Contains(txtSearch.Text.ToLower())
                                )
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
                if (isProdottoSelected)
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (txtSearch.Text != String.Empty)
                    btnEdit_Click(sender, e);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void dgvData_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (sender != null)
                btnEdit_Click(sender, e);
        }

        private void dgvData_MouseClick(object sender, MouseEventArgs e)
        {
            EnableDisableEditAndInsert();
        }

        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void SelectRowById(String id, String colonnaId, int displayPos)
        {
            dgvData.ClearSelection();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[colonnaId].Value?.ToString() == id)
                {
                    row.Selected = true;
                    dgvData.FirstDisplayedScrollingRowIndex = displayPos;
                    return;
                }
            }
        }

        private void SelectAfterDelete(int previousIndex, int displayPos, int numberOfDeletions)
        {
            dgvData.ClearSelection();

            if (dgvData.Rows.Count == 0) return;

            int lastSelectedIndex = previousIndex;
            if (dgvData.SelectedRows.Count > 0)
            {
                lastSelectedIndex = dgvData.SelectedRows.Cast<DataGridViewRow>().Max(row => row.Index);
            }

            int newIndex = lastSelectedIndex - (numberOfDeletions - 1);

            if (newIndex >= dgvData.Rows.Count) newIndex = dgvData.Rows.Count - 1;
            if (newIndex < 0) newIndex = 0;

            if (newIndex >= 0 && newIndex < dgvData.Rows.Count)
            {
                dgvData.Rows[newIndex].Selected = true;
            }

            if (displayPos >= 0 && displayPos < dgvData.RowCount)
            {
                dgvData.FirstDisplayedScrollingRowIndex = displayPos;
            }
        }

        private void EnableDisableEditAndInsert()
        {
            if (dgvData.SelectedRows.Count > 1)
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }

    }
}
