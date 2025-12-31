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
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Black;
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            lblCognome.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblTelefono.ForeColor = Color.Black;
        }

        private void txtIndirizzo_TextChanged(object sender, EventArgs e)
        {
            lblIndirizzo.ForeColor = Color.Black;
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
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Black;
                txtEmail.ForeColor = Color.Black;
                emailNotValid = false;
            }
        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnOk;
        }

        private void txtIndirizzo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtIndirizzo_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnOk;
        }

        bool InputCheck()
        {
            bool res0 = true;
            bool res1 = true;
            bool res2 = true;

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
            if (String.IsNullOrEmpty(txtTelefono.Text))
            {
                lblTelefono.ForeColor = Color.Red;
                res2 = false;
            }
            return !emailNotValid && res0 && res1 && res2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                ModelClienti.addCliente(
                    txtNome.Text.ToUpper(),
                    txtCognome.Text.ToUpper(),
                    dtpCompleanno.Checked ? dtpCompleanno.Text : string.Empty, 
                    txtIndirizzo.Text.ToUpper(),
                    txtTelefono.Text,
                    txtEmail.Text.ToLower(),
                    txtNote.Text);
                if (chkRipeti.Checked)
                {
                    txtNome.Text = String.Empty;
                    txtCognome.Text = String.Empty;
                    dtpCompleanno.Text = String.Empty;
                    dtpCompleanno.Checked = false;
                    txtTelefono.Text = String.Empty;
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

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
