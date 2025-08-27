using PlannerShop.Data;
using System.Data;
using System.Text.RegularExpressions;

namespace PlannerShop.Forms
{
    public partial class ClientEditForm : Form
    {
        string idCliente;
        bool emailNotValid = false;
        public bool isDelete = false;
        public ClientEditForm(string idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            txtNote.GotFocus += TxtNote_GotFocus;
            txtNote.LostFocus += TxtNote_LostFocus;

            LoadForm();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Black;
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            lblCognome.ForeColor = Color.Black;
        }

        private void txtTelefonoMobile_TextChanged(object sender, EventArgs e)
        {
            lblTelefonoMobile.ForeColor = Color.Black;
        }

        private void txtIndirizzo_TextChanged(object sender, EventArgs e)
        {
            lblIndirizzo.ForeColor = Color.Black;
        }

        private void dtpDataNascita_ValueChanged(object sender, EventArgs e)
        {
            lblDataNascita.ForeColor = Color.Black;
        }

        private void TxtNote_GotFocus(object? sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void TxtNote_LostFocus(object? sender, EventArgs e)
        {
            this.AcceptButton = this.btnOk;
        }

        private void LoadForm()
        {
            DataTable dt = ModelClienti.getClienteById(idCliente);
            if (dt.Rows.Count != 0)
            {
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtCognome.Text = dt.Rows[0]["COGNOME"].ToString();
                txtTelefonoFisso.Text = dt.Rows[0]["TELEFONO_FISSO"].ToString();
                txtTelefonoMobile.Text = dt.Rows[0]["TELEFONO_MOBILE"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtIndirizzo.Text = dt.Rows[0]["INDIRIZZO"].ToString();
                dtpDataNascita.Text = dt.Rows[0]["DATA_NASCITA"].ToString();
                txtNote.Text = dt.Rows[0]["NOTE"].ToString();
            }
        }

        bool InputCheck()
        {
            bool res0 = true;
            bool res1 = true;
            bool res2 = true;
            bool res3 = true;
            bool res4 = true;

            if (String.IsNullOrEmpty(txtNome.Text))
            {
                lblNome.ForeColor = Color.Red;
                res0 = false;
            }
            if (String.IsNullOrEmpty(txtCognome.Text))
            {
                lblCognome.ForeColor = Color.Red;
                res1 = false;
            }
            if (String.IsNullOrEmpty(txtTelefonoMobile.Text))
            {
                lblTelefonoMobile.ForeColor = Color.Red;
                res2 = false;
            }
            if (String.IsNullOrEmpty(txtIndirizzo.Text))
            {
                lblIndirizzo.ForeColor = Color.Red;
                res3 = false;
            }
            if (String.IsNullOrWhiteSpace(dtpDataNascita.Text))
            {
                lblDataNascita.ForeColor = Color.Red;
                res4 = false;
            }
            return !emailNotValid && res0 && res1 && res2 && res3 && res4;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                ModelClienti.editCliente(
                    idCliente,
                    txtNome.Text,
                    txtCognome.Text,
                    dtpDataNascita.Text,
                    txtIndirizzo.Text.ToUpper(),
                    txtTelefonoFisso.Text,
                    txtTelefonoMobile.Text,
                    txtEmail.Text.ToLower(),
                    txtNote.Text);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteForm dltFrm = new DeleteForm(txtNome.Text + " " + txtCognome.Text);
                dltFrm.ShowDialog();
                if (dltFrm.result)
                {
                    ModelClienti.deleteCliente(idCliente);
                    isDelete = true;
                    this.Close();
                }
            }
            catch { }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmail.ForeColor = Color.Black;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                lblEmail.ForeColor = Color.Black;
                txtEmail.ForeColor = Color.Black;
                emailNotValid = false;
            }
            else
            {
                lblEmail.ForeColor = Color.Red;
                txtEmail.ForeColor = Color.Red;
                emailNotValid = true;
            }
        }
    }
}

