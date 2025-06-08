using PlannerShop.Data;

namespace PlannerShop.Forms
{
    public partial class ClientInsertForm : Form
    {
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
            bool res5 = true;
            bool res6 = true;

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
            return res0 && res1 && res2 && res3 && res4;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                ModelClienti.addCliente(
                    txtNome.Text.ToUpper(),
                    txtCognome.Text.ToUpper(),
                    dtpDataNascita.Text.ToUpper(),
                    txtTelefonoFisso.Text.ToUpper(),
                    txtTelefonoMobile.Text.ToUpper(),
                    txtEmail.Text.ToUpper(),
                    txtIndirizzo.Text.ToUpper(),
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

        
    }
}
