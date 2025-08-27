using PlannerShop.Data;
using System.Data;

namespace PlannerShop.Forms
{
    public partial class ProductEditForm : Form
    {
        string idProdotto;
        public bool isDelete = false;

        public ProductEditForm(string idProdotto)
        {
            InitializeComponent();
            this.idProdotto = idProdotto;

            txtNote.GotFocus += txtNote_GotFocus;
            txtNote.LostFocus += txtNote_LostFocus;

            txtPrezzoIvato.ReadOnly = !rdbPrezzoIvato.Checked;
            txtPrezzoNetto.ReadOnly = !rdbPrezzoNetto.Checked;

            LoadForm();
        }

        private void txtMarca_TextChanged(object? sender, EventArgs e)
        {
            lblMarca.ForeColor = Color.Black;
        }

        private void txtMarca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDescrizione_TextChanged(object? sender, EventArgs e)
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
            if (rdbPrezzoNetto.Checked) {
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

        private void txtNote_GotFocus(object? sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtNote_LostFocus(object? sender, EventArgs e)
        {
            this.AcceptButton = this.btnOk;
        }

        private void LoadForm()
        {
            DataTable dt = ModelProdotti.getProdottoById(idProdotto);
            if (dt.Rows.Count != 0)
            {
                dtpData.Text = dt.Rows[0]["DATA"].ToString();
                txtMarca.Text = dt.Rows[0]["MARCA"].ToString();
                txtDescrizione.Text = dt.Rows[0]["DESCRIZIONE"].ToString();
                string? sqnt = dt.Rows[0]["QNT"].ToString();
                if (!String.IsNullOrEmpty(sqnt))
                    nudQnt.Value = int.Parse(sqnt);
                string? saliquota = dt.Rows[0]["ALIQUOTA"].ToString();
                if (!String.IsNullOrEmpty(saliquota))
                    nudAliquota.Value = int.Parse(saliquota);
                string? strPN = dt.Rows[0]["PREZZO_NETTO"].ToString();
                if (!String.IsNullOrEmpty(strPN))
                    txtPrezzoNetto.Text = strPN.Replace("€", "");
                string? strPI = dt.Rows[0]["PREZZO_IVATO"].ToString();
                if (!String.IsNullOrEmpty(strPI))
                    txtPrezzoIvato.Text = strPI.Replace("€", "");
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
            bool res5 = true;

            if (String.IsNullOrEmpty(txtMarca.Text))
            {
                lblMarca.ForeColor = Color.Red;
                res1 = false;
            }
            if (String.IsNullOrEmpty(txtDescrizione.Text))
            {
                lblDescrizione.ForeColor = Color.Red;
                res2 = false;
            }
            if (String.IsNullOrEmpty(txtPrezzoNetto.Text))
            {
                lblPrezzoNetto.ForeColor = Color.Red;
                res3 = false;
            }
            if (String.IsNullOrEmpty(txtPrezzoIvato.Text))
            {
                lblPrezzoIvato.ForeColor = Color.Red;
                res4 = false;
            }

            if (txtPrezzoNetto.ForeColor == Color.Red || txtPrezzoIvato.ForeColor == Color.Red)
            {
                res5 = false;
            }

            return res0 && res1 && res2 && res3 && res4 && res5;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                double prezzoNetto = double.Parse(txtPrezzoNetto.Text);
                ModelProdotti.editProdotto(
                    idProdotto,
                    dtpData.Value.ToShortDateString(),
                    txtMarca.Text.ToUpper(),
                    txtDescrizione.Text.ToUpper(),
                    nudAliquota.Value.ToString(),
                    nudQnt.Value.ToString(),
                    prezzoNetto.ToString() + " €",
                    txtPrezzoIvato.Text + " €",
                    txtNote.Text);

                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteForm dltFrm = new DeleteForm(txtMarca.Text + " " + txtDescrizione.Text);
                dltFrm.ShowDialog();
                if (dltFrm.result)
                {
                    ModelProdotti.deleteProdotto(idProdotto);
                    isDelete = true;
                    this.Close();
                }
            }
            catch { }
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
