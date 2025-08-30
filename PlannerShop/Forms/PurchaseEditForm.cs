using PlannerShop.Data;
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
    public partial class PurchaseEditForm : Form
    {
        String idCliente;
        public PurchaseEditForm(String IdCliente)
        {
            InitializeComponent();
            this.idCliente = IdCliente;

            dgvData.DataSource = ModelProdotti.getProdotti();
            SetProductDataGridStructure();


            Utils.SetDataGridStyle(dgvDataAcquisto, false);
            Utils.SetDataGridStyle(dgvData, false);
            loadClienteData();

            foreach (DataGridViewColumn col in dgvData.Columns)
            {
                dgvDataAcquisto.Columns.Add((DataGridViewColumn)col.Clone());
            }
        }

        private void loadClienteData()
        {
            DataTable dtCliente = ModelClienti.getClienteById(idCliente);
            lblName.Text = dtCliente.Rows[0]["NOME"].ToString().ToUpper() + " " + dtCliente.Rows[0]["COGNOME"].ToString().ToUpper();
            lblIndirizzo.Text = dtCliente.Rows[0]["INDIRIZZO"].ToString();
            lblTelefono.Text = "Tel. " + dtCliente.Rows[0]["TELEFONO_MOBILE"].ToString();
            lblEmail.Text = dtCliente.Rows[0]["EMAIL"].ToString();
        }

        void SetProductDataGridStructure()
        {
            int fontSize = 10;

            var idProductColumn = dgvData.Columns["IDPRODOTTO"];
            idProductColumn.DisplayIndex = 0;
            idProductColumn.Visible = false;
            idProductColumn.HeaderText = "IDPRODOTTO";
            idProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            idProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var dataProductColumn = dgvData.Columns["DATA"];
            dataProductColumn.DisplayIndex = 1;
            dataProductColumn.Visible = false;
            dataProductColumn.HeaderText = "DATA";
            dataProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var marcaProductColumn = dgvData.Columns["MARCA"];
            marcaProductColumn.DisplayIndex = 2;
            marcaProductColumn.Visible = true;
            marcaProductColumn.HeaderText = "MARCA";
            marcaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            marcaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            marcaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            marcaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var descrizioneProductColumn = dgvData.Columns["DESCRIZIONE"];
            descrizioneProductColumn.DisplayIndex = 3;
            descrizioneProductColumn.Visible = true;
            descrizioneProductColumn.HeaderText = "DESCRIZIONE";
            descrizioneProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descrizioneProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            descrizioneProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            descrizioneProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);

            var aliquotaProductColumn = dgvData.Columns["ALIQUOTA"];
            aliquotaProductColumn.DisplayIndex = 4;
            aliquotaProductColumn.Visible = false;
            aliquotaProductColumn.HeaderText = "IVA";
            aliquotaProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            aliquotaProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aliquotaProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            aliquotaProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var qntProductColumn = dgvData.Columns["QNT"];
            qntProductColumn.DisplayIndex = 5;
            qntProductColumn.Visible = true;
            qntProductColumn.HeaderText = "QNT";
            qntProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            qntProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            qntProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qntProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoNettoProductColumn = dgvData.Columns["PREZZO_NETTO"];
            prezzoNettoProductColumn.DisplayIndex = 6;
            prezzoNettoProductColumn.Visible = true;
            prezzoNettoProductColumn.HeaderText = "PREZZO NETTO";
            prezzoNettoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoNettoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoNettoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoNettoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var prezzoIvatoProductColumn = dgvData.Columns["PREZZO_IVATO"];
            prezzoIvatoProductColumn.DisplayIndex = 7;
            prezzoIvatoProductColumn.Visible = true;
            prezzoIvatoProductColumn.HeaderText = "PREZZO IVATO";
            prezzoIvatoProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezzoIvatoProductColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            prezzoIvatoProductColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            prezzoIvatoProductColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Regular);

            var noteProductionColumn = dgvData.Columns["NOTE"];
            noteProductionColumn.DisplayIndex = 8;
            noteProductionColumn.Visible = false;
            noteProductionColumn.HeaderText = "NOTE";
            noteProductionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteProductionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            noteProductionColumn.DefaultCellStyle.Font = new Font("Corbel", fontSize, FontStyle.Bold);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != String.Empty && dgvData.Rows.Count > 0)
            {
                {
                    foreach (DataGridViewRow dgvr in dgvData.Rows)
                    {
                        try
                        {
                            String data = dgvr.Cells["DATA"]?.Value?.ToString()?.ToLower() ?? String.Empty;
                            String marca = dgvr.Cells["MARCA"].Value?.ToString()?.ToLower() ?? String.Empty;
                            String descrizione = dgvr.Cells["DESCRIZIONE"].Value?.ToString()?.ToLower() ?? String.Empty;

                            if (data.Contains(txtSearch.Text.ToLower())
                                || marca.Contains(txtSearch.Text.ToLower())
                                || descrizione.Contains(txtSearch.Text.ToLower()))
                            {
                                dgvData.ClearSelection();
                                dgvData.Rows[dgvr.Index].Selected = true;
                                dgvData.FirstDisplayedScrollingRowIndex = dgvData.SelectedRows[0].Index;
                                return;
                            }
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica che l'indice sia valido
            if (e.RowIndex < 0 || e.RowIndex >= dgvData.Rows.Count)
                return;

            // Verifica che il numero di colonne sia compatibile
            int colCount = Math.Min(dgvData.Columns.Count, dgvDataAcquisto.Columns.Count);

            // Crea una nuova riga per dgvDataAcquisto
            DataGridViewRow newRow = new DataGridViewRow();

            newRow.Height = 40;

            newRow.CreateCells(dgvDataAcquisto);

            // Copia i valori dalla riga selezionata
            for (int i = 0; i < colCount; i++)
            {
                newRow.Cells[i].Value = dgvData.Rows[e.RowIndex].Cells[i].Value;
            }

            // Aggiungi la riga al secondo DataGridView
            dgvDataAcquisto.Rows.Add(newRow);
        }
    }
}
