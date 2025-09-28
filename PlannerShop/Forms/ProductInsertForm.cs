using PlannerShop.Data;

namespace PlannerShop.Forms
{
    public partial class ProductInsertForm : Form
    {
        public bool isDone = false;
        public ProductInsertForm()
        {
            InitializeComponent();

            txtNote.GotFocus += TxtNote_GotFocus;
            txtNote.LostFocus += TxtNote_LostFocus;

            txtPrezzoIvato.ReadOnly = !rdbPrezzoIvato.Checked;
            txtPrezzoNetto.ReadOnly = !rdbPrezzoNetto.Checked;
        }

        private void TxtMarca_TextChanged(object? sender, EventArgs e)
        {
            lblMarca.ForeColor = Color.Black;
        }

        private void TxtDescrizione_TextChanged(object? sender, EventArgs e)
        {
            lblDescrizione.ForeColor = Color.Black;
        }

        private void txtPrezzoNetto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtPrezzoNetto_TextChanged(object? sender, EventArgs e)
        {
            if (rdbPrezzoNetto.Checked)
            {
                lblPrezzoNetto.ForeColor = Color.Black;
                lblPrezzoIvato.ForeColor = Color.Black;

                if (txtPrezzoNetto.Text != String.Empty)
                {
                    double value = double.Parse(txtPrezzoNetto.Text);
                    double res = value + (value * int.Parse(nudAliquota.Value.ToString()) / 100);

                    double prezzoIvato = Math.Ceiling(res * 100) / 100;

                    txtPrezzoIvato.Text = prezzoIvato.ToString("F2");
                }
                else
                {
                    txtPrezzoIvato.Text = String.Empty;
                }
            }
        }

        private void txtPrezzoIvato_TextChanged(object sender, EventArgs e)
        {
            if (rdbPrezzoIvato.Checked)
            {
                lblPrezzoNetto.ForeColor = Color.Black;
                lblPrezzoIvato.ForeColor = Color.Black;

                if (txtPrezzoIvato.Text != String.Empty)
                {
                    double value = double.Parse(txtPrezzoIvato.Text);
                    double aliquota = (double)nudAliquota.Value;

                    double res = value / (1 + aliquota / 100);

                    var prezzoNetto = Math.Ceiling(res * 100) / 100;


                    txtPrezzoNetto.Text = prezzoNetto.ToString("F2"); ;
                }
                else
                {
                    txtPrezzoNetto.Text = String.Empty;
                }
            }
        }

        private void nudAliquota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                lblAliquota.ForeColor = Color.Black;
                txtPrezzoNetto.Text = String.Empty;
            }
        }

        private void nudAliquota_ValueChanged(object sender, EventArgs e)
        {
            txtPrezzoNetto.Text = string.Empty;
            txtPrezzoIvato.Text = string.Empty;
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

            if (String.IsNullOrEmpty(txtMarca.Text))
            {
                lblMarca.ForeColor = Color.Red;
                res0 = false;
            }
            if (String.IsNullOrEmpty(txtDescrizione.Text))
            {
                lblDescrizione.ForeColor = Color.Red;
                res1 = false;
            }
            if (String.IsNullOrEmpty(txtPrezzoNetto.Text))
            {
                lblPrezzoNetto.ForeColor = Color.Red;
                res2 = false;
            }
            if (String.IsNullOrEmpty(txtPrezzoIvato.Text))
            {
                lblPrezzoIvato.ForeColor = Color.Red;
                res3 = false;
            }

            if (txtPrezzoNetto.ForeColor == Color.Red || txtPrezzoIvato.ForeColor == Color.Red)
            {
                res4 = false;
            }

            return res0 && res1 && res2 && res3 && res4;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                double prezzoNetto = double.Parse(txtPrezzoNetto.Text);
                ModelProdotti.addProdotto(
                    dtpData.Value.ToShortDateString(),
                    txtMarca.Text.ToUpper(),
                    txtDescrizione.Text.ToUpper(),
                    nudAliquota.Value.ToString(),
                    nudQnt.Value.ToString(),
                    prezzoNetto.ToString() + " €",
                    txtPrezzoIvato.Text + " €",
                    txtNote.Text);
                if (chkRipeti.Checked)
                {
                    dtpData.Value = DateTime.Now;
                    txtMarca.Text = String.Empty;
                    txtDescrizione.Text = String.Empty;
                    nudAliquota.Value = 22;
                    nudQnt.Value = 1;
                    txtPrezzoNetto.Text = String.Empty;
                    txtPrezzoIvato.Text = String.Empty;
                    txtNote.Text = String.Empty;

                    txtPrezzoNetto.ForeColor = Color.Black;
                    txtPrezzoIvato.ForeColor = Color.Black;
                }
                else
                {
                    this.Close();
                    isDone = true;
                }
            }
        }

        private void rdbPrezzoNetto_CheckedChanged(object sender, EventArgs e)
        {
            txtPrezzoIvato.ReadOnly = !rdbPrezzoIvato.Checked;
            txtPrezzoNetto.ReadOnly = !rdbPrezzoNetto.Checked;
        }

        private void rdbPrezzoIvato_CheckedChanged(object sender, EventArgs e)
        {
            txtPrezzoIvato.ReadOnly = !rdbPrezzoIvato.Checked;
            txtPrezzoNetto.ReadOnly = !rdbPrezzoNetto.Checked;
        }

    }
}
