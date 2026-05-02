using PlannerShop.Data;
using System.Data;
using System.Globalization;

namespace PlannerShop.Forms
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            rdbDaSempre.Checked = true;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            AggiornaDati();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            AggiornaDati();
        }

        private void rdbPersonalizzato_CheckedChanged(object sender, EventArgs e)
        {
            bool vis = rdbPersonalizzato.Checked;
            lblDa.Visible = vis;
            dtpDa.Visible = vis;
            lblA.Visible = vis;
            dtpA.Visible = vis;
        }

        // ── Filtro temporale ──────────────────────────────────────────────────

        private (DateTime? da, DateTime? a) GetFiltro()
        {
            if (rdbDaSempre.Checked) return (null, null);
            if (rdbUltimoAnno.Checked) return (DateTime.Now.AddYears(-1).Date, null);
            if (rdbUltimaSettimana.Checked) return (DateTime.Now.AddDays(-7).Date, null);
            return (dtpDa.Value.Date, dtpA.Value.Date.AddDays(1).AddTicks(-1));
        }

        private static List<DataRow> FiltraAcquisti(DataTable dt, DateTime? da, DateTime? a)
        {
            var rows = dt.AsEnumerable().ToList();
            if (da == null) return rows;

            return rows.Where(r =>
            {
                // Preferisce TIMESTAMP (formato ISO), fallback su DATA
                string? tsStr = r.Table.Columns.Contains("TIMESTAMP") ? r["TIMESTAMP"]?.ToString() : null;
                string? dataStr = r["DATA"]?.ToString();

                DateTime? d = ModelStatistiche.ParseData(tsStr?.Split(' ')[0])
                           ?? ModelStatistiche.ParseData(dataStr);

                if (d == null) return false;
                if (da != null && d < da) return false;
                if (a != null && d > a) return false;
                return true;
            }).ToList();
        }

        private static List<DataRow> FiltraProdotti(DataTable dt, DateTime? da, DateTime? a)
        {
            var rows = dt.AsEnumerable().ToList();
            if (da == null) return rows;

            return rows.Where(r =>
            {
                DateTime? d = ModelStatistiche.ParseData(r["DATA"]?.ToString());
                if (d == null) return false;
                if (da != null && d < da) return false;
                if (a != null && d > a) return false;
                return true;
            }).ToList();
        }

        // ── Aggiornamento dati ────────────────────────────────────────────────

        private void AggiornaDati()
        {
            var (da, a) = GetFiltro();

            DataTable dtAcquisti = ModelStatistiche.GetAllAcquistiAttivi();
            DataTable dtProdotti = ModelStatistiche.GetAllProdotti();

            List<DataRow> acquistiPeriodo = FiltraAcquisti(dtAcquisti, da, a);
            List<DataRow> prodottiPeriodo = FiltraProdotti(dtProdotti, da, a);

            AggiornaNumeroProdotti(dtProdotti, prodottiPeriodo, da);
            AggiornaValoreInventario(dtProdotti);
            AggiornaBilancio(acquistiPeriodo, prodottiPeriodo, da);
            AggiornaTopProdotti(acquistiPeriodo);
            AggiornaTopClienti(acquistiPeriodo);
        }

        private void AggiornaNumeroProdotti(DataTable dtTutti, List<DataRow> prodottiPeriodo, DateTime? da)
        {
            int count = da == null ? dtTutti.Rows.Count : prodottiPeriodo.Count;
            lblNumProdotti.Text = count.ToString("N0", new CultureInfo("it-IT"));
            lblNumProdottiSub.Text = da == null ? "prodotti in catalogo" : "prodotti aggiunti nel periodo";
        }

        private void AggiornaValoreInventario(DataTable dtProdotti)
        {
            decimal netto = 0m;
            decimal ivato = 0m;

            foreach (DataRow r in dtProdotti.Rows)
            {
                if (!int.TryParse(r["QNT"]?.ToString(), out int qnt)) qnt = 0;
                netto += ModelStatistiche.ParseEuro(r["PREZZO_NETTO"]) * qnt;
                ivato += ModelStatistiche.ParseEuro(r["PREZZO_IVATO"]) * qnt;
            }

            lblInvNetto.Text = $"Netto:       {netto.ToString("N2", new CultureInfo("it-IT"))} €";
            lblInvIvato.Text = $"IVA incl.:  {ivato.ToString("N2", new CultureInfo("it-IT"))} €";
        }

        private void AggiornaBilancio(List<DataRow> acquistiPeriodo, List<DataRow> prodottiPeriodo, DateTime? da)
        {
            decimal entrate = acquistiPeriodo.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]));

            // Le uscite sono il valore (PREZZO_NETTO * QNT) dei prodotti nel periodo selezionato
            decimal uscite = prodottiPeriodo.Sum(r =>
            {
                if (!int.TryParse(r["QNT"]?.ToString(), out int q)) q = 0;
                return ModelStatistiche.ParseEuro(r["PREZZO_NETTO"]) * q;
            });

            decimal saldo = entrate - uscite;

            var it = new CultureInfo("it-IT");
            lblEntrateVal.Text = entrate.ToString("N2", it) + " €";
            lblUsciteVal.Text = uscite.ToString("N2", it) + " €";
            lblUtileVal.Text = saldo.ToString("N2", it) + " €";
            lblUtileVal.ForeColor = saldo >= 0 ? Color.FromArgb(40, 130, 40) : Color.FromArgb(180, 60, 60);
            lblUtile.ForeColor = lblUtileVal.ForeColor;
        }

        private void AggiornaTopProdotti(List<DataRow> acquistiPeriodo)
        {
            var top = acquistiPeriodo
                .Where(r => !string.IsNullOrWhiteSpace(r["NOME"]?.ToString()))
                .GroupBy(r =>
                    (r["NOME"]?.ToString() ?? "").ToUpper() + "|" +
                    (r["MARCA"]?.ToString() ?? "").ToUpper())
                .Select(g => new
                {
                    Nome = (g.First()["NOME"]?.ToString() ?? "").ToUpper(),
                    Marca = (g.First()["MARCA"]?.ToString() ?? "").ToUpper(),
                    QntTot = g.Sum(r => int.TryParse(r["QNT"]?.ToString(), out int q) ? q : 0),
                    Importo = g.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]))
                })
                .OrderByDescending(x => x.QntTot)
                .Take(10)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("#", typeof(int));
            dt.Columns.Add("PRODOTTO", typeof(string));
            dt.Columns.Add("MARCA", typeof(string));
            dt.Columns.Add("QNT VENDUTA", typeof(int));
            dt.Columns.Add("INCASSATO", typeof(string));

            var it = new CultureInfo("it-IT");
            for (int i = 0; i < top.Count; i++)
                dt.Rows.Add(i + 1, top[i].Nome, top[i].Marca, top[i].QntTot,
                    top[i].Importo.ToString("N2", it) + " €");

            dgvTopProdotti.DataSource = dt;
            ApplicaStileDgv(dgvTopProdotti);
            ImpostaColonneDgv(dgvTopProdotti, rightAlignCols: new[] { "QNT VENDUTA", "INCASSATO" });
        }

        private void AggiornaTopClienti(List<DataRow> acquistiPeriodo)
        {
            var top = acquistiPeriodo
                .Where(r => r["IDCLIENTE"] != DBNull.Value)
                .GroupBy(r => r["IDCLIENTE"]?.ToString())
                .Select(g => new
                {
                    Cliente = ((g.First()["NOME_CLIENTE"]?.ToString() ?? "?").ToUpper() + " " +
                               (g.First()["COGNOME_CLIENTE"]?.ToString() ?? "?").ToUpper()).Trim(),
                    NAcquisti = g.Count(),
                    Speso = g.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]))
                })
                .OrderByDescending(x => x.NAcquisti)
                .Take(10)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("#", typeof(int));
            dt.Columns.Add("CLIENTE", typeof(string));
            dt.Columns.Add("N. ACQUISTI", typeof(int));
            dt.Columns.Add("TOTALE SPESO", typeof(string));

            var it = new CultureInfo("it-IT");
            for (int i = 0; i < top.Count; i++)
                dt.Rows.Add(i + 1, top[i].Cliente, top[i].NAcquisti,
                    top[i].Speso.ToString("N2", it) + " €");

            dgvTopClienti.DataSource = dt;
            ApplicaStileDgv(dgvTopClienti);
            ImpostaColonneDgv(dgvTopClienti, rightAlignCols: new[] { "N. ACQUISTI", "TOTALE SPESO" });
        }

        // ── Helpers UI ────────────────────────────────────────────────────────

        private static void ApplicaStileDgv(DataGridView dgv)
        {
            DgvUtils.SetDataGridStyle(dgv, false, 36, 34, false);
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private static void ImpostaColonneDgv(DataGridView dgv, string[] rightAlignCols)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (rightAlignCols.Contains(col.Name))
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }
    }
}
