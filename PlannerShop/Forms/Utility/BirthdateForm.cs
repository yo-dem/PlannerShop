using PlannerShop.Data;

namespace PlannerShop.Forms.Utility
{
    public partial class BirthdateForm : Form
    {
        public BirthdateForm()
        {
            InitializeComponent();

            LoadClienti();
        }

        void LoadClienti(String? searchItem = null)
        {
            DgvUtils.SetDataGridStyle(dgvData, true, 40, 40, true);

            dgvData.DataSource = ModelClienti.searchBirthdayClienti();
            SetClientDataGridStructure();
        }

        void SetClientDataGridStructure()
        {
            var idClientColumn = dgvData.Columns["IDCLIENTE"];
            idClientColumn.DisplayIndex = 0;
            idClientColumn.Visible = false;
            idClientColumn.HeaderText = "IDCLIENTE";
            idClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            dataNascitaClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataNascitaClientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataNascitaClientColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var indirizzoSupplierColumn = dgvData.Columns["INDIRIZZO"];
            indirizzoSupplierColumn.DisplayIndex = 4;
            indirizzoSupplierColumn.Visible = false;
            indirizzoSupplierColumn.HeaderText = "INDIRIZZO";
            indirizzoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indirizzoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            indirizzoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var telefonoFissoSupplierColumn = dgvData.Columns["TELEFONO"];
            telefonoFissoSupplierColumn.DisplayIndex = 5;
            telefonoFissoSupplierColumn.Visible = true;
            telefonoFissoSupplierColumn.HeaderText = "TELEFONO";
            telefonoFissoSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefonoFissoSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            telefonoFissoSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var emailSupplierColumn = dgvData.Columns["EMAIL"];
            emailSupplierColumn.DisplayIndex = 6;
            emailSupplierColumn.Visible = false;
            emailSupplierColumn.HeaderText = "EMAIL";
            emailSupplierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailSupplierColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            emailSupplierColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            var noteProductColumn = dgvData.Columns["NOTE"];
            noteProductColumn.DisplayIndex = 7;
            noteProductColumn.Visible = false;
            noteProductColumn.HeaderText = "NOTE";
            noteProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            noteProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name != "COMPLEANNO")
                return;

            if (e.Value == null)
                return;

            string raw = e.Value.ToString()!; // es: "29-10"

            var parts = raw.Split('-');

            if (!int.TryParse(parts[0], out int giorno) ||
                !int.TryParse(parts[1], out int mese))
                return;

            string? nomeMese = mese switch
            {
                1 => "Gennaio",
                2 => "Febbraio",
                3 => "Marzo",
                4 => "Aprile",
                5 => "Maggio",
                6 => "Giugno",
                7 => "Luglio",
                8 => "Agosto",
                9 => "Settembre",
                10 => "Ottobre",
                11 => "Novembre",
                12 => "Dicembre",
                _ => null
            };

            if (nomeMese == null)
                return;

            e.Value = $"{giorno:00} {nomeMese}";
            e.FormattingApplied = true;
        }

        private void dgvData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string? selectedId = dgvData.SelectedRows[0].Cells["IDCLIENTE"].Value?.ToString();
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
                    LoadClienti();
                }
            }
        }
    }
}
