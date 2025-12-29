using System.Data;

namespace PlannerShop.Forms
{
    public partial class ServicePurchaseDetaIlForm : Form
    {
        private DataRow row;
        private DataTable dtCliente;
        public ServicePurchaseDetaIlForm(DataRow row, DataTable dtCliente)
        {
            InitializeComponent();
            this.row = row;
            this.dtCliente = dtCliente;

            lblName.Text = dtCliente.Rows[0]["NOME"].ToString()!.ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString()!.ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();

            lblPrezzoVendita.Text = row["PREZZO_VENDITA"].ToString();

            lblNome.Text = row["NOME"].ToString();
            lblDescrizione.Text = row["DESCRIZIONE"].ToString();

            lblTotaleCalcolato.Text = lblPrezzoVendita.Text;
        }

        private void nudSconto_KeyUp(object sender, KeyEventArgs e)
        {
            totalCalculator();
        }

        private void nudSconto_ValueChanged(object sender, EventArgs e)
        {
            totalCalculator();
        }

        private void txtPrezzoVendita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtPrezzoVendita_TextChanged(object sender, EventArgs e)
        {
            totalCalculator();
        }

        private void nudQnt_KeyUp(object sender, KeyEventArgs e)
        {
            totalCalculator();
        }

        private void nudQnt_ValueChanged(object sender, EventArgs e)
        {
            totalCalculator();
        }

        private void totalCalculator()
        {
            // Rimuove simbolo € e spazi
            string prezzoText = lblPrezzoVendita.Text.Replace("€", "").Trim();

            // Controlla se il campo non è vuoto e se il valore è valido
            if (decimal.TryParse(prezzoText, out decimal prezzoVendita))
            {
                decimal sconto = nudSconto.Value;

                // Calcolo totale con sconto
                decimal total = prezzoVendita * (1 - sconto / 100);

                // Arrotondamento a 2 decimali
                total = Math.Round(total, 2);

                // Visualizzazione con sempre due cifre decimali
                lblTotaleCalcolato.Text = total.ToString("F2") + " €";
            }
            else
            {
                // Se il campo non contiene un numero valido
                lblTotaleCalcolato.Text = "Totale: 0.00 €";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
