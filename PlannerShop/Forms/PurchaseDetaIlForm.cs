using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerShop.Forms
{
    public partial class PurchaseDetaIlForm : Form
    {
        private DataRow row;
        private DataTable dtCliente;
        public PurchaseDetaIlForm(DataRow row, DataTable dtCliente)
        {
            InitializeComponent();
            this.row = row;
            this.dtCliente = dtCliente;

            lblName.Text = dtCliente.Rows[0]["NOME"].ToString()!.ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString()!.ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();

            txtPrezzoVendita.Text = row["PREZZO_VENDITA"].ToString();

            nudQnt.Maximum = Convert.ToDecimal(row["QNT"]);

            lblMarca.Text = row["MARCA"].ToString();
            lblDescrizione.Text = row["DESCRIZIONE"].ToString();
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
            if (txtPrezzoVendita.Text != "")
            {
                if (txtPrezzoVendita.Text.Contains("€"))
                {
                    txtPrezzoVendita.Text = txtPrezzoVendita.Text.Replace(" €", "");
                }
                decimal prezzoVendita = Convert.ToDecimal(txtPrezzoVendita.Text);
                decimal qnt = nudQnt.Value;
                decimal total = prezzoVendita * qnt - (prezzoVendita * nudSconto.Value / 100);
                lblTotaleCalcolato.Text = total.ToString("F2") + " €";
            }
            else
            {
                lblTotaleCalcolato.Text = "Totale: 0.00 €";
            }
        }

    }
}
