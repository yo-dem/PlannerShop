
using PlannerShop.Data;
using PlannerShop.Forms;

namespace PlannerShop
{
    public partial class MainForm : Form
    {
        bool isClienteSelected = false;
        bool isFornitoreSelected = false;
        bool isProdottoSelected = false;
        bool isServizioSelected = false;

        Color btnDefaultColor;

        public MainForm()
        {
            InitializeComponent();

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
            var idClientColumn = dgvData.Columns["IDCLIENTE"];
            idClientColumn.DisplayIndex = 0;
            idClientColumn.Visible = false;
            idClientColumn.HeaderText = "IDCLIENTE";
            idClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var nomeClientColumn = dgvData.Columns["NOME"];
            nomeClientColumn.DisplayIndex = 1;
            nomeClientColumn.Visible = true;
            nomeClientColumn.HeaderText = "NOME";
            nomeClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var cognomeClientColumn = dgvData.Columns["COGNOME"];
            cognomeClientColumn.DisplayIndex = 2;
            cognomeClientColumn.Visible = true;
            cognomeClientColumn.HeaderText = "COGNOME";
            cognomeClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cognomeClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cognomeClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var dataNascitaClientColumn = dgvData.Columns["COMPLEANNO"];
            dataNascitaClientColumn.DisplayIndex = 3;
            dataNascitaClientColumn.Visible = true;
            dataNascitaClientColumn.HeaderText = "COMPLEANNO";
            dataNascitaClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataNascitaClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataNascitaClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var indirizzoSupplierColumn = dgvData.Columns["INDIRIZZO"];
            indirizzoSupplierColumn.DisplayIndex = 4;
            indirizzoSupplierColumn.Visible = true;
            indirizzoSupplierColumn.HeaderText = "INDIRIZZO";
            indirizzoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indirizzoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            indirizzoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var telefonoFissoSupplierColumn = dgvData.Columns["TELEFONO"];
            telefonoFissoSupplierColumn.DisplayIndex = 5;
            telefonoFissoSupplierColumn.Visible = true;
            telefonoFissoSupplierColumn.HeaderText = "TELEFONO";
            telefonoFissoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefonoFissoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefonoFissoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var emailSupplierColumn = dgvData.Columns["EMAIL"];
            emailSupplierColumn.DisplayIndex = 6;
            emailSupplierColumn.Visible = true;
            emailSupplierColumn.HeaderText = "EMAIL";
            emailSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            emailSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var noteProductColumn = dgvData.Columns["NOTE"];
            noteProductColumn.DisplayIndex = 7;
            noteProductColumn.Visible = true;
            noteProductColumn.HeaderText = "NOTE";
            noteProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void SetProductDataGridStructure()
        {
            var idProductColumn = dgvData.Columns["IDPRODOTTO"];
            idProductColumn.DisplayIndex = 0;
            idProductColumn.Visible = false;
            idProductColumn.HeaderText = "IDPRODOTTO";
            idProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
         
            var dataProductColumn = dgvData.Columns["DATA"];
            dataProductColumn.DisplayIndex = 1;
            dataProductColumn.Visible = true;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            var marcaProductColumn = dgvData.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 2;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            marcaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            var descrizioneProductColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneProductColumn.DisplayIndex = 3;
            descrizioneProductColumn.Visible = true;
            descrizioneProductColumn.HeaderText = "DESCRIZIONE";
            descrizioneProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var qntProductColumn = dgvData.Columns["QNT"];
            qntProductColumn.DisplayIndex = 4;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var aliquotaProductColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaProductColumn.DisplayIndex = 5;
            aliquotaProductColumn.Visible = true;
            aliquotaProductColumn.HeaderText = "IVA";
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoNettoProductColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 6;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoIvatoProductColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 7;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoVenditaProductColumn = dgvData.Columns["PREZZO_VENDITA"];
            prezzoVenditaProductColumn.DisplayIndex = 8;
            prezzoVenditaProductColumn.Visible = true;
            prezzoVenditaProductColumn.HeaderText = "VENDITA";
            prezzoVenditaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoVenditaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 9;
            noteProductionColumn.Visible = true;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void SetSupplierDataGridStructure()
        {
            var idSupplierColumn = dgvData.Columns["IDFORNITORE"];
            idSupplierColumn.DisplayIndex = 0;
            idSupplierColumn.Visible = false;
            idSupplierColumn.HeaderText = "IDFORNITORE";
            idSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            var nomeSupplierColumn = dgvData.Columns["NOME"];
            nomeSupplierColumn.DisplayIndex = 1;
            nomeSupplierColumn.Visible = true;
            nomeSupplierColumn.HeaderText = "NOME";
            nomeSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nomeSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var indirizzoSupplierColumn = dgvData.Columns["INDIRIZZO"];
            indirizzoSupplierColumn.DisplayIndex = 2;
            indirizzoSupplierColumn.Visible = true;
            indirizzoSupplierColumn.HeaderText = "INDIRIZZO";
            indirizzoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indirizzoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            indirizzoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var telefonoFissoSupplierColumn = dgvData.Columns["TELEFONO"];
            telefonoFissoSupplierColumn.DisplayIndex = 3;
            telefonoFissoSupplierColumn.Visible = true;
            telefonoFissoSupplierColumn.HeaderText = "TELEFONO";
            telefonoFissoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefonoFissoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefonoFissoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var emailSupplierColumn = dgvData.Columns["EMAIL"];
            emailSupplierColumn.DisplayIndex = 4;
            emailSupplierColumn.Visible = true;
            emailSupplierColumn.HeaderText = "EMAIL";
            emailSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            emailSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            emailSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var ibanSupplierColumn = dgvData.Columns["IBAN"];
            ibanSupplierColumn.DisplayIndex = 5;
            ibanSupplierColumn.Visible = false;
            ibanSupplierColumn.HeaderText = "IBAN";
            ibanSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ibanSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ibanSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 6;
            noteProductionColumn.Visible = true;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void SetServiceDataGridStructure()
        {
            var idServiceColumn = dgvData.Columns["IDSERVIZIO"];
            idServiceColumn.DisplayIndex = 0;
            idServiceColumn.Visible = false;
            idServiceColumn.HeaderText = "IDSERVIZIO";
            idServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            idServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            var dataServiceColumn = dgvData.Columns["DATA"];
            dataServiceColumn.DisplayIndex = 1;
            dataServiceColumn.Visible = true;
            dataServiceColumn.HeaderText = "DATA";
            dataServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var nomeServiceColumn = dgvData.Columns["NOME"];
            nomeServiceColumn.DisplayIndex = 2;
            nomeServiceColumn.Visible = true;
            nomeServiceColumn.HeaderText = "NOME";
            nomeServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nomeServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            nomeServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var descrizioneServiceColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneServiceColumn.DisplayIndex = 3;
            descrizioneServiceColumn.Visible = true;
            descrizioneServiceColumn.HeaderText = "DESCRIZIONE";
            descrizioneServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var aliquotaServiceColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaServiceColumn.DisplayIndex = 4;
            aliquotaServiceColumn.Visible = true;
            aliquotaServiceColumn.HeaderText = "IVA";
            aliquotaServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            aliquotaServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoNettoServiceColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoServiceColumn.DisplayIndex = 5;
            prezzoNettoServiceColumn.Visible = true;
            prezzoNettoServiceColumn.HeaderText = "NETTO";
            prezzoNettoServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoNettoServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoIvatoServiceColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoServiceColumn.DisplayIndex = 6;
            prezzoIvatoServiceColumn.Visible = true;
            prezzoIvatoServiceColumn.HeaderText = "IVATO";
            prezzoIvatoServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoIvatoServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var prezzoVenditaServiceColumn = dgvData.Columns["PREZZO_VENDITA"];
            prezzoVenditaServiceColumn.DisplayIndex = 7;
            prezzoVenditaServiceColumn.Visible = true;
            prezzoVenditaServiceColumn.HeaderText = "VENDITA";
            prezzoVenditaServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoVenditaServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prezzoVenditaServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var noteServiceColumn = dgvData.Columns["NOTE"];
            noteServiceColumn.DisplayIndex = 8;
            noteServiceColumn.Visible = true;
            noteServiceColumn.HeaderText = "NOTE";
            noteServiceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteServiceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteServiceColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        void LoadClienti(String? searchItem = null)
        {
            isClienteSelected = true;
            isFornitoreSelected = false;
            isProdottoSelected = false;
            isServizioSelected = false;
            if (string.IsNullOrEmpty(searchItem))
            {
                dgvData.DataSource = ModelClienti.getClienti();
            }
            else
            {
                dgvData.DataSource = ModelClienti.searchClienti(searchItem);
            }
            Utils.SetDataGridStyle(dgvData, true, 40, 40, true);
            SetClientDataGridStructure();
        }

        void LoadFornitori(string? searchItem = null)
        {
            isClienteSelected = false;
            isFornitoreSelected = true;
            isProdottoSelected = false;
            isServizioSelected = false;
            if (string.IsNullOrEmpty(searchItem))
            {
                dgvData.DataSource = ModelFornitori.getFornitori();
            }
            else
            {
                dgvData.DataSource = ModelFornitori.searchFornitori(searchItem);
            }
            Utils.SetDataGridStyle(dgvData, true, 40, 40, true);
            SetSupplierDataGridStructure();
        }

        void LoadProdotti(string? searchItem = null)
        {
            isClienteSelected = false;
            isFornitoreSelected = false;
            isProdottoSelected = true;
            isServizioSelected = false;
            if (string.IsNullOrEmpty(searchItem))
            {
                dgvData.DataSource = ModelProdotti.getProdotti();
            }
            else
            {
                dgvData.DataSource = ModelProdotti.searchProdotti(searchItem);
            }
            Utils.SetDataGridStyle(dgvData, true, 40, 40, true);
            SetProductDataGridStructure();
        }

        void LoadServizi(string? searchItem = null)
        {
            isClienteSelected = false;
            isFornitoreSelected = false;
            isProdottoSelected = false;
            isServizioSelected = true;
            if (string.IsNullOrEmpty(searchItem))
            {
                dgvData.DataSource = ModelServizi.getServizi();
            }
            else
            {
                dgvData.DataSource = ModelServizi.searchServizi(searchItem);
            }
            Utils.SetDataGridStyle(dgvData, true, 40, 40, true);
            SetServiceDataGridStructure();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            LoadClienti();
            txtSearch.Text = String.Empty;
            btnClienti.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnProdotti.BackColor = btnDefaultColor;
            btnFornitori.BackColor = btnDefaultColor;
            btnServizi.BackColor = btnDefaultColor;
            EnableDisableEditAndInsert();
        }

        private void btnProdotti_Click(object sender, EventArgs e)
        {
            LoadProdotti();
            txtSearch.Text = String.Empty;
            btnClienti.BackColor = btnDefaultColor;
            btnProdotti.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnFornitori.BackColor = btnDefaultColor;
            btnServizi.BackColor = btnDefaultColor;
            EnableDisableEditAndInsert();
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            LoadFornitori();
            txtSearch.Text = String.Empty;
            btnClienti.BackColor = btnDefaultColor;
            btnProdotti.BackColor = btnDefaultColor;
            btnFornitori.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnServizi.BackColor = btnDefaultColor;
            EnableDisableEditAndInsert();
        }

        private void btnServizi_Click(object sender, EventArgs e)
        {
            LoadServizi();
            txtSearch.Text = String.Empty;
            btnClienti.BackColor = btnDefaultColor;
            btnProdotti.BackColor = btnDefaultColor;
            btnFornitori.BackColor = btnDefaultColor;
            btnServizi.BackColor = Color.FromArgb(90, 192, 192, 255);
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
            else if (isServizioSelected)
            {
                ServiceInsertForm serviceInsertForm = new ServiceInsertForm();
                serviceInsertForm.ShowDialog();
                if (serviceInsertForm.isDone)
                    dgvData.DataSource = ModelServizi.getServizi();
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
                    }
                    else
                    {
                        LoadClienti(txtSearch.Text);
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
                    }
                    else
                    {
                        LoadProdotti(txtSearch.Text);
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
                    }
                    else
                    {
                        LoadFornitori(txtSearch.Text);
                        SelectRowById(selectedId, "IDFORNITORE", displayPos);
                    }
                }
            }
            else if (isServizioSelected)
            {
                selectedId = dgvData.SelectedRows[0].Cells["IDSERVIZIO"].Value?.ToString();
                if (!String.IsNullOrEmpty(selectedId))
                {
                    ServiceEditForm serviceEditForm = new ServiceEditForm(selectedId);
                    serviceEditForm.ShowDialog();

                    if (serviceEditForm.isDelete)
                    {
                        LoadServizi();
                    }
                    else
                    {
                        LoadServizi(txtSearch.Text);
                        SelectRowById(selectedId, "IDSERVIZIO", displayPos);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0) { return; }
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
                    if (isServizioSelected)
                    {
                        ModelServizi.deleteServizio(id);
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
                if (isServizioSelected)
                {
                    LoadServizi();
                }

            }
        }

        private void DgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (isProdottoSelected)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells["QNT"].Value != null &&
                        int.TryParse(row.Cells["QNT"].Value.ToString(), out int qnt) &&
                        qnt == 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.Font = new Font(dgvData.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (isClienteSelected)
            {
                LoadClienti(txtSearch.Text);
            }
            if (isFornitoreSelected)
            {
                LoadFornitori(txtSearch.Text);
            }
            if (isProdottoSelected)
            {
                LoadProdotti(txtSearch.Text);
            }
            if (isServizioSelected)
            {
                LoadServizi(txtSearch.Text);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
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
