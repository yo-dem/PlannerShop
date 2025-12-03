using PlannerShop.Data;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace PlannerShop.Forms
{
    public partial class SupplierEditForm : Form
    {
        string idFornitore;
        bool emailNotValid = false;
        bool ibanNotValid = false;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_TextChanged(object? sender, EventArgs e)
        {
            lblTelefono.ForeColor = Color.Black;
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
            lblTelefono.ForeColor = Color.Black;
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

        private void TxtIban_TextChanged(object? sender, EventArgs e)
        {
            lblIban.ForeColor = Color.Black;

            // IBAN: due lettere paese + due cifre + da 11 a 30 caratteri alfanumerici
            string ibanPattern = @"^[A-Z]{2}\d{2}[A-Z0-9]{11,30}$";

            string iban = txtIban.Text.ToUpper().Replace(" ", "");

            if (string.IsNullOrEmpty(iban))
            {
                lblIban.ForeColor = Color.Black;
                txtIban.ForeColor = Color.Black;
                ibanNotValid = false;
                return;
            }

            bool regexOk = Regex.IsMatch(iban, ibanPattern);
            bool mod97Ok = regexOk && CheckIbanMod97(iban);

            if (regexOk && mod97Ok)
            {
                lblIban.ForeColor = Color.Black;
                txtIban.ForeColor = Color.Black;
                ibanNotValid = false;
            }
            else
            {
                lblIban.ForeColor = Color.Red;
                txtIban.ForeColor = Color.Red;
                ibanNotValid = true;
            }
        }

        private bool CheckIbanMod97(string iban)
        {
            string rearranged = iban.Substring(4) + iban.Substring(0, 4);

            StringBuilder sb = new StringBuilder();
            foreach (char c in rearranged)
            {
                if (char.IsLetter(c))
                    sb.Append((c - 'A') + 10);
                else
                    sb.Append(c);
            }

            string converted = sb.ToString();
            int chunk = 0;

            foreach (char digit in converted)
            {
                chunk = (chunk * 10 + (digit - '0')) % 97;
            }

            return chunk == 1;
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
                txtTelefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtIban.Text = dt.Rows[0]["IBAN"].ToString();
                txtNote.Text = dt.Rows[0]["NOTE"].ToString();
            }
        }

        bool InputCheck()
        {
            bool res0 = true;
            bool res1 = true;
            bool res2 = true;
            bool res3 = true;

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
            if (String.IsNullOrEmpty(txtTelefono.Text))
            {
                lblTelefono.ForeColor = Color.Red;
                res2 = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Red;
                res3 = false;
            }

            return res0 && res1 && res2 && res3 && !emailNotValid && !ibanNotValid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                ModelFornitori.editFornitore(
                    idFornitore,
                    txtNome.Text,
                    txtIndirizzo.Text,
                    txtTelefono.Text,
                    txtEmail.Text.ToLower(),
                    txtIban.Text,
                    txtNote.Text);
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

