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
        string mailgest;
        string pwdmailgest;
        string smtpmailgest;
        string portmailgest;



        public ClientEditForm(string idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;

            LoadForm();

            this.mailgest = ModelOpzioni.GetOpzione("mailgest");
            this.pwdmailgest = ModelOpzioni.GetOpzione("pwdmailgest");
            this.smtpmailgest = ModelOpzioni.GetOpzione("smtpmailgest");
            this.portmailgest = ModelOpzioni.GetOpzione("portmailgest");

            btnMail.Visible = (mailgest == string.Empty 
                || pwdmailgest == string.Empty 
                || smtpmailgest == string.Empty 
                || portmailgest == string.Empty) 
                ? false : true;
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

        private void dtpDataNascita_ValueChanged(object sender, EventArgs e)
        {
            lblCompleanno.ForeColor = Color.Black;
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

        private void LoadForm()
        {
            DataTable dt = ModelClienti.getClienteById(idCliente);
            if (dt.Rows.Count != 0)
            {
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtCognome.Text = dt.Rows[0]["COGNOME"].ToString();
                txtTelefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtIndirizzo.Text = dt.Rows[0]["INDIRIZZO"].ToString();
                dtpCompleanno.Text = dt.Rows[0]["COMPLEANNO"].ToString() != string.Empty ? dt.Rows[0]["COMPLEANNO"].ToString() + "-2000" : string.Empty;
                dtpCompleanno.Checked = dt.Rows[0]["COMPLEANNO"].ToString() != string.Empty;
                txtNote.Text = dt.Rows[0]["NOTE"].ToString();
            }
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
                ModelClienti.editCliente(
                    idCliente,
                    txtNome.Text.ToUpper(),
                    txtCognome.Text.ToUpper(),
                    dtpCompleanno.Checked ? dtpCompleanno.Text : string.Empty,
                    txtIndirizzo.Text.ToUpper(),
                    txtTelefono.Text,
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

        private void btnProductPurchase_Click(object sender, EventArgs e)
        {
            ProductPurchaseEditForm purchaseEditForm = new ProductPurchaseEditForm(idCliente);
            DialogResult result = purchaseEditForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                //this.Close();
            }
        }

        private void btnServicePurchase_Click(object sender, EventArgs e)
        {
            ServicePurchaseEditForm purchaseEditForm = new ServicePurchaseEditForm(idCliente);
            DialogResult result = purchaseEditForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                //this.Close();
            }
        }

        private void btnViewPurchase_Click(object sender, EventArgs e)
        {
            PurchaseViewForm purchaseClientEditForm = new PurchaseViewForm(idCliente);
            DialogResult result = purchaseClientEditForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                //this.Close();
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || emailNotValid)
            {
                MessageBox.Show("L'indirizzo email non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SendMailForm sendMailForm = new SendMailForm(txtEmail.Text);
            var result = sendMailForm.ShowDialog();
        }
    }
}

