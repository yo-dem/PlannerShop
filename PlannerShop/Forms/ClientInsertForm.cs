using PlannerShop.Data;
using System.Text.RegularExpressions;

namespace PlannerShop.Forms
{
    public partial class ClientInsertForm : Form
    {
        bool emailNotValid = false;
        public bool isDone = false;
        public ClientInsertForm()
        {
            InitializeComponent();

            txtNote.GotFocus += TxtNote_GotFocus;
            txtNote.LostFocus += TxtNote_LostFocus;
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
                ModelClienti.addCliente(
                    txtNome.Text,
                    txtCognome.Text,
                    dtpDataNascita.Text,
                    txtIndirizzo.Text.ToUpper(),
                    txtTelefonoFisso.Text,
                    txtTelefonoMobile.Text,
                    txtEmail.Text.ToLower(),
                    txtNote.Text);
                if (chkRipeti.Checked)
                {
                    txtNome.Text = String.Empty;
                    txtCognome.Text = String.Empty;
                    dtpDataNascita.Text = String.Empty;
                    txtTelefonoFisso.Text = String.Empty;
                    txtTelefonoMobile.Text = String.Empty;
                    txtEmail.Text = String.Empty;
                    txtIndirizzo.Text = String.Empty;
                    txtNote.Text = String.Empty;
                }
                else
                {
                    this.Close();
                    isDone = true;
                }
            }
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
