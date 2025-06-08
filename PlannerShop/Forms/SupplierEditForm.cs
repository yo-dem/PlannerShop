using PlannerShop.Data;
using System.Data;
using System.Text.RegularExpressions;

namespace PlannerShop.Forms
{
    public partial class SupplierEditForm : Form
    {
        string idFornitore;
        bool emailNotValid = false;
        public bool isDelete = false;

        public SupplierEditForm(string idFornitore)
        {
            InitializeComponent();
            this.idFornitore = idFornitore;
            
            txtNote.GotFocus += TxtNote_GotFocus;
            txtNote.LostFocus += TxtNote_LostFocus;

            LoadForm();
        }

        private void TxtNome_TextChanged(object? sender, EventArgs e)
        {
            lblNome.ForeColor = Color.Black;
        }

        private void txtMarca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void TxtIndirizzo_TextChanged(object? sender, EventArgs e)
        {
            lblIndirizzo.ForeColor = Color.Black;
        }

        private void txtTelefonoFisso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoFisso_TextChanged(object? sender, EventArgs e)
        {
            lblTelefonoFisso.ForeColor = Color.Black;
        }

        private void txtTelefonoMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefonoMobile_TextChanged(object? sender, EventArgs e)
        {
            lblTelefonoMobile.ForeColor = Color.Black;
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
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
            DataTable dt = ModelFornitori.getFornitoreById(idFornitore);
            if (dt.Rows.Count != 0)
            {
                txtNome.Text = dt.Rows[0]["NOME"].ToString();
                txtIndirizzo.Text = dt.Rows[0]["INDIRIZZO"].ToString();
                txtTelefonoFisso.Text = dt.Rows[0]["TELEFONO_FISSO"].ToString();
                txtTelefonoMobile.Text = dt.Rows[0]["TELEFONO_MOBILE"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
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
            if (String.IsNullOrEmpty(txtIndirizzo.Text))
            {
                lblIndirizzo.ForeColor = Color.Red;
                res1 = false;
            }
            if (String.IsNullOrEmpty(txtTelefonoFisso.Text))
            {
                lblTelefonoFisso.ForeColor = Color.Red;
                res2 = false;
            }
            if (String.IsNullOrEmpty(txtTelefonoMobile.Text))
            {
                lblTelefonoMobile.ForeColor = Color.Red;
                res3 = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Red;
                res4 = false;
            }

            return res0 && res1 && res2 && res3 && res4 && !emailNotValid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                ModelFornitori.editFornitore(
                    idFornitore,
                    txtNome.Text.ToUpper(),
                    txtIndirizzo.Text.ToUpper(),
                    txtTelefonoFisso.Text.ToUpper(),
                    txtTelefonoMobile.Text.ToUpper(),
                    txtEmail.Text.ToUpper(),
                    txtNote.Text.ToUpper());
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteForm dltFrm = new DeleteForm(txtNome.Text);
                dltFrm.ShowDialog();
                if (dltFrm.result)
                {
                    ModelFornitori.deleteFornitore(idFornitore);
                    isDelete = true;
                    this.Close();
                }
            }
            catch { }
        }
    }
}

