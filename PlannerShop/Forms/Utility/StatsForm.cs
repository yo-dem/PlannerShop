using PlannerShop.Data;
using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlannerShop.Forms
{
    public partial class StatsForm : Form
    {
        // ── Dati calcolati condivisi tra tab Dati e tab Grafici ───────────────
        private record TopProdottoItem(string Label, int QntTot, decimal Importo);
        private record TopClienteItem(string Cliente, int NAcquisti, decimal Speso);

        private List<TopProdottoItem> _topProdotti = new();
        private List<TopClienteItem> _topClienti = new();
        private decimal _entrate;
        private decimal _uscite;

        // ── Stato toggle grafici ──────────────────────────────────────────────
        private bool _prodottiMostraTorta = false;
        private bool _clientiMostraTorta = false;

        // ── Chart controls (creati in InitGrafici) ────────────────────────────
        private Chart chartProdotti = null!;
        private Chart chartClienti = null!;
        private Chart chartBilancio = null!;

        // ── Palette colori per grafici a torta ────────────────────────────────
        private static readonly Color[] Palette = new[]
        {
            Color.FromArgb(90,  192, 192, 255),
            Color.FromArgb(255, 140, 100, 180),
            Color.FromArgb(255, 100, 200, 150),
            Color.FromArgb(255, 230, 160,  60),
            Color.FromArgb(255, 220, 100, 100),
            Color.FromArgb(255,  80, 180, 240),
            Color.FromArgb(255, 150, 230, 150),
            Color.FromArgb(255, 255, 150,  80),
            Color.FromArgb(255, 150, 100, 240),
            Color.FromArgb(255, 200, 200,  80),
        };

        public StatsForm()
        {
            InitializeComponent();
            rdbDaSempre.Checked = true;
            InitGrafici();
        }

        private void StatsForm_Load(object sender, EventArgs e) => AggiornaDati();
        private void btnAggiorna_Click(object sender, EventArgs e) => AggiornaDati();

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
                string? tsStr = r.Table.Columns.Contains("TIMESTAMP") ? r["TIMESTAMP"]?.ToString() : null;
                DateTime? d = ModelStatistiche.ParseData(tsStr?.Split(' ')[0])
                           ?? ModelStatistiche.ParseData(r["DATA"]?.ToString());
                if (d == null) return false;
                if (da != null && d < da) return false;
                if (a  != null && d > a)  return false;
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
                if (a  != null && d > a)  return false;
                return true;
            }).ToList();
        }

        // ── Aggiornamento dati ────────────────────────────────────────────────

        private void AggiornaDati()
        {
            var (da, a) = GetFiltro();
            DataTable dtAcquisti = ModelStatistiche.GetAllAcquistiAttivi();
            DataTable dtProdotti = ModelStatistiche.GetAllProdotti();

            var acquistiPeriodo = FiltraAcquisti(dtAcquisti, da, a);
            var prodottiPeriodo = FiltraProdotti(dtProdotti, da, a);

            AggiornaNumeroProdotti(dtProdotti, prodottiPeriodo, da);
            AggiornaValoreInventario(dtProdotti);
            AggiornaBilancio(acquistiPeriodo, prodottiPeriodo);
            AggiornaTopProdotti(acquistiPeriodo);
            AggiornaTopClienti(acquistiPeriodo);
            AggiornaGrafici();
        }

        private void AggiornaNumeroProdotti(DataTable dtTutti, List<DataRow> prodottiPeriodo, DateTime? da)
        {
            int count = da == null ? dtTutti.Rows.Count : prodottiPeriodo.Count;
            var it = new CultureInfo("it-IT");
            lblNumProdotti.Text = count.ToString("N0", it);
            lblNumProdottiSub.Text = da == null ? "prodotti in catalogo" : "prodotti aggiunti nel periodo";
        }

        private void AggiornaValoreInventario(DataTable dtProdotti)
        {
            decimal netto = 0m, ivato = 0m;
            foreach (DataRow r in dtProdotti.Rows)
            {
                if (!int.TryParse(r["QNT"]?.ToString(), out int qnt)) qnt = 0;
                netto += ModelStatistiche.ParseEuro(r["PREZZO_NETTO"]) * qnt;
                ivato += ModelStatistiche.ParseEuro(r["PREZZO_IVATO"]) * qnt;
            }
            var it = new CultureInfo("it-IT");
            lblInvNetto.Text = $"Netto:       {netto.ToString("N2", it)} €";
            lblInvIvato.Text = $"IVA incl.:  {ivato.ToString("N2", it)} €";
        }

        private void AggiornaBilancio(List<DataRow> acquistiPeriodo, List<DataRow> prodottiPeriodo)
        {
            _entrate = acquistiPeriodo.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]));
            _uscite  = prodottiPeriodo.Sum(r =>
            {
                if (!int.TryParse(r["QNT"]?.ToString(), out int q)) q = 0;
                return ModelStatistiche.ParseEuro(r["PREZZO_NETTO"]) * q;
            });
            decimal saldo = _entrate - _uscite;
            var it = new CultureInfo("it-IT");
            lblEntrateVal.Text = _entrate.ToString("N2", it) + " €";
            lblUsciteVal.Text  = _uscite.ToString("N2", it)  + " €";
            lblUtileVal.Text   = saldo.ToString("N2", it)    + " €";
            lblUtileVal.ForeColor = saldo >= 0 ? Color.FromArgb(40, 130, 40) : Color.FromArgb(180, 60, 60);
            lblUtile.ForeColor    = lblUtileVal.ForeColor;
        }

        private void AggiornaTopProdotti(List<DataRow> acquistiPeriodo)
        {
            _topProdotti = acquistiPeriodo
                .Where(r => !string.IsNullOrWhiteSpace(r["NOME"]?.ToString()))
                .GroupBy(r =>
                    (r["NOME"]?.ToString() ?? "").ToUpper() + "|" +
                    (r["MARCA"]?.ToString() ?? "").ToUpper())
                .Select(g =>
                {
                    string nome  = (g.First()["NOME"]?.ToString()  ?? "").ToUpper();
                    string marca = (g.First()["MARCA"]?.ToString() ?? "").ToUpper();
                    string lbl   = string.IsNullOrWhiteSpace(marca) ? nome : $"{nome} ({marca})";
                    int    qnt   = g.Sum(r => int.TryParse(r["QNT"]?.ToString(), out int q) ? q : 0);
                    decimal imp  = g.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]));
                    return new TopProdottoItem(lbl, qnt, imp);
                })
                .OrderByDescending(x => x.QntTot)
                .Take(10)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("#",          typeof(int));
            dt.Columns.Add("PRODOTTO",   typeof(string));
            dt.Columns.Add("QNT VENDUTA",typeof(int));
            dt.Columns.Add("INCASSATO",  typeof(string));
            var it = new CultureInfo("it-IT");
            for (int i = 0; i < _topProdotti.Count; i++)
                dt.Rows.Add(i + 1, _topProdotti[i].Label, _topProdotti[i].QntTot,
                    _topProdotti[i].Importo.ToString("N2", it) + " €");
            dgvTopProdotti.DataSource = dt;
            ApplicaStileDgv(dgvTopProdotti);
            ImpostaColonneDgv(dgvTopProdotti, new[] { "QNT VENDUTA", "INCASSATO" });
        }

        private void AggiornaTopClienti(List<DataRow> acquistiPeriodo)
        {
            _topClienti = acquistiPeriodo
                .Where(r => r["IDCLIENTE"] != DBNull.Value)
                .GroupBy(r => r["IDCLIENTE"]?.ToString())
                .Select(g => new TopClienteItem(
                    Cliente: ((g.First()["NOME_CLIENTE"]?.ToString()    ?? "?").ToUpper() + " " +
                              (g.First()["COGNOME_CLIENTE"]?.ToString() ?? "?").ToUpper()).Trim(),
                    NAcquisti: g.Count(),
                    Speso: g.Sum(r => ModelStatistiche.ParseEuro(r["TOTALE"]))))
                .OrderByDescending(x => x.NAcquisti)
                .Take(10)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("#",           typeof(int));
            dt.Columns.Add("CLIENTE",     typeof(string));
            dt.Columns.Add("N. ACQUISTI", typeof(int));
            dt.Columns.Add("TOTALE SPESO",typeof(string));
            var it = new CultureInfo("it-IT");
            for (int i = 0; i < _topClienti.Count; i++)
                dt.Rows.Add(i + 1, _topClienti[i].Cliente, _topClienti[i].NAcquisti,
                    _topClienti[i].Speso.ToString("N2", it) + " €");
            dgvTopClienti.DataSource = dt;
            ApplicaStileDgv(dgvTopClienti);
            ImpostaColonneDgv(dgvTopClienti, new[] { "N. ACQUISTI", "TOTALE SPESO" });
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
                bool right = rightAlignCols.Contains(col.Name);
                col.DefaultCellStyle.Alignment = right
                    ? DataGridViewContentAlignment.MiddleRight
                    : DataGridViewContentAlignment.MiddleLeft;
                col.HeaderCell.Style.Alignment = right
                    ? DataGridViewContentAlignment.MiddleRight
                    : DataGridViewContentAlignment.MiddleLeft;
                if (right) col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // GRAFICI
        // ════════════════════════════════════════════════════════════════════

        private void InitGrafici()
        {
            chartProdotti = CreaNuovoChart("chartProdotti");
            chartClienti  = CreaNuovoChart("chartClienti");
            chartBilancio = CreaNuovoChart("chartBilancio");

            // Inserisce i Chart SOPRA il pannello toggle (Dock=Top+Fill trick):
            // il toggle ha Dock=Top, il chart riempie il resto con Dock=Fill
            chartProdotti.Dock = DockStyle.Fill;
            chartClienti.Dock  = DockStyle.Fill;
            chartBilancio.Dock = DockStyle.Fill;

            grpGrProdotti.Controls.Add(chartProdotti);
            grpGrClienti.Controls.Add(chartClienti);
            grpGrBilancio.Controls.Add(chartBilancio);
        }

        private static Chart CreaNuovoChart(string name)
        {
            var chart = new Chart { Name = name, BackColor = Color.White };
            var area  = new ChartArea("main")
            {
                BackColor = Color.White,
                BorderColor = Color.Transparent,
            };
            area.AxisX.LineColor        = Color.FromArgb(200, 200, 210);
            area.AxisY.LineColor        = Color.FromArgb(200, 200, 210);
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 240);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 240);
            area.AxisX.LabelStyle.Font  = new Font("Segoe UI", 7.5f);
            area.AxisY.LabelStyle.Font  = new Font("Segoe UI", 7.5f);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(80, 80, 90);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(80, 80, 90);
            chart.ChartAreas.Add(area);
            return chart;
        }

        private void AggiornaGrafici()
        {
            DisegnaGraficoProdotti();
            DisegnaGraficoClienti();
            DisegnaGraficoBilancio();
        }

        // ── Grafico prodotti ──────────────────────────────────────────────────

        private void DisegnaGraficoProdotti()
        {
            chartProdotti.Series.Clear();
            var area = chartProdotti.ChartAreas["main"];

            if (_topProdotti.Count == 0)
            {
                MostraMessaggioVuoto(chartProdotti);
                return;
            }

            if (_prodottiMostraTorta)
            {
                area.Visible = false;
                var s = new Series("prodotti") { ChartType = SeriesChartType.Pie };
                s["PieLabelStyle"] = "Outside";
                s["PieLineColor"]  = "DarkGray";
                s.Font = new Font("Segoe UI", 7.5f);
                for (int i = 0; i < _topProdotti.Count; i++)
                {
                    var pt = s.Points.Add((double)_topProdotti[i].Importo);
                    pt.LegendText = _topProdotti[i].Label;
                    pt.Label      = $"{_topProdotti[i].Label}\n{(double)_topProdotti[i].Importo:#,##0.00} €";
                    pt.Color      = Palette[i % Palette.Length];
                }
                chartProdotti.Series.Add(s);
            }
            else
            {
                area.Visible = true;
                area.AxisX.Interval = 1;
                var s = new Series("prodotti") { ChartType = SeriesChartType.Bar };
                s.Color = Color.FromArgb(90, 192, 192, 255);
                s.Font  = new Font("Segoe UI", 7.5f);
                s["DrawingStyle"] = "Cylinder";
                for (int i = _topProdotti.Count - 1; i >= 0; i--)
                {
                    s.Points.AddXY(_topProdotti[i].Label, _topProdotti[i].QntTot);
                    s.Points[^1].ToolTip = $"{_topProdotti[i].Label}: {_topProdotti[i].QntTot} pz";
                }
                area.AxisX.LabelStyle.Angle = 0;
                area.AxisY.Title     = "Quantità venduta";
                area.AxisY.TitleFont = new Font("Segoe UI", 7.5f);
                chartProdotti.Series.Add(s);
            }
        }

        // ── Grafico clienti ───────────────────────────────────────────────────

        private void DisegnaGraficoClienti()
        {
            chartClienti.Series.Clear();
            var area = chartClienti.ChartAreas["main"];

            if (_topClienti.Count == 0)
            {
                MostraMessaggioVuoto(chartClienti);
                return;
            }

            if (_clientiMostraTorta)
            {
                area.Visible = false;
                var s = new Series("clienti") { ChartType = SeriesChartType.Pie };
                s["PieLabelStyle"] = "Outside";
                s["PieLineColor"]  = "DarkGray";
                s.Font = new Font("Segoe UI", 7.5f);
                for (int i = 0; i < _topClienti.Count; i++)
                {
                    var pt = s.Points.Add((double)_topClienti[i].Speso);
                    pt.LegendText = _topClienti[i].Cliente;
                    pt.Label      = $"{_topClienti[i].Cliente}\n{(double)_topClienti[i].Speso:#,##0.00} €";
                    pt.Color      = Palette[i % Palette.Length];
                }
                chartClienti.Series.Add(s);
            }
            else
            {
                area.Visible = true;
                area.AxisX.Interval = 1;
                var s = new Series("clienti") { ChartType = SeriesChartType.Bar };
                s.Color = Color.FromArgb(140, 192, 140, 255);
                s.Font  = new Font("Segoe UI", 7.5f);
                s["DrawingStyle"] = "Cylinder";
                for (int i = _topClienti.Count - 1; i >= 0; i--)
                {
                    s.Points.AddXY(_topClienti[i].Cliente, _topClienti[i].NAcquisti);
                    s.Points[^1].ToolTip = $"{_topClienti[i].Cliente}: {_topClienti[i].NAcquisti} acquisti";
                }
                area.AxisY.Title     = "N. acquisti";
                area.AxisY.TitleFont = new Font("Segoe UI", 7.5f);
                chartClienti.Series.Add(s);
            }
        }

        // ── Grafico bilancio (solo barre) ─────────────────────────────────────

        private void DisegnaGraficoBilancio()
        {
            chartBilancio.Series.Clear();
            var area = chartBilancio.ChartAreas["main"];
            area.Visible = true;

            var sEntrate = new Series("Entrate")
            {
                ChartType = SeriesChartType.Column,
                Color     = Color.FromArgb(80, 180, 80),
                Font      = new Font("Segoe UI", 8f, FontStyle.Bold),
            };
            sEntrate["DrawingStyle"] = "Cylinder";
            sEntrate.Points.AddXY("ENTRATE", (double)_entrate);
            sEntrate.Points[0].Label = _entrate.ToString("N2", new CultureInfo("it-IT")) + " €";

            var sUscite = new Series("Uscite")
            {
                ChartType = SeriesChartType.Column,
                Color     = Color.FromArgb(210, 80, 80),
                Font      = new Font("Segoe UI", 8f, FontStyle.Bold),
            };
            sUscite["DrawingStyle"] = "Cylinder";
            sUscite.Points.AddXY("USCITE", (double)_uscite);
            sUscite.Points[0].Label = _uscite.ToString("N2", new CultureInfo("it-IT")) + " €";

            decimal saldo = _entrate - _uscite;
            var sSaldo = new Series("Saldo")
            {
                ChartType = SeriesChartType.Column,
                Color     = saldo >= 0 ? Color.FromArgb(60, 130, 200) : Color.FromArgb(200, 130, 60),
                Font      = new Font("Segoe UI", 8f, FontStyle.Bold),
            };
            sSaldo["DrawingStyle"] = "Cylinder";
            sSaldo.Points.AddXY("SALDO", (double)saldo);
            sSaldo.Points[0].Label = saldo.ToString("N2", new CultureInfo("it-IT")) + " €";

            area.AxisX.Interval = 1;
            area.AxisY.Title     = "Importo (€)";
            area.AxisY.TitleFont = new Font("Segoe UI", 7.5f);

            chartBilancio.Series.Add(sEntrate);
            chartBilancio.Series.Add(sUscite);
            chartBilancio.Series.Add(sSaldo);
        }

        private static void MostraMessaggioVuoto(Chart chart)
        {
            chart.ChartAreas["main"].Visible = false;
            var title = new Title("Nessun dato nel periodo selezionato")
            {
                Font      = new Font("Segoe UI", 10f, FontStyle.Italic),
                ForeColor = Color.Gray,
                Docking   = Docking.Top,
            };
            chart.Titles.Clear();
            chart.Titles.Add(title);
        }

        // ── Toggle handlers ───────────────────────────────────────────────────

        private void btnGrProdottiBarre_Click(object sender, EventArgs e)
        {
            _prodottiMostraTorta = false;
            ImpostaToggle(btnGrProdottiBarre, btnGrProdottiTorta);
            DisegnaGraficoProdotti();
        }

        private void btnGrProdottiTorta_Click(object sender, EventArgs e)
        {
            _prodottiMostraTorta = true;
            ImpostaToggle(btnGrProdottiTorta, btnGrProdottiBarre);
            DisegnaGraficoProdotti();
        }

        private void btnGrClientiBarre_Click(object sender, EventArgs e)
        {
            _clientiMostraTorta = false;
            ImpostaToggle(btnGrClientiBarre, btnGrClientiTorta);
            DisegnaGraficoClienti();
        }

        private void btnGrClientiTorta_Click(object sender, EventArgs e)
        {
            _clientiMostraTorta = true;
            ImpostaToggle(btnGrClientiTorta, btnGrClientiBarre);
            DisegnaGraficoClienti();
        }

        private static void ImpostaToggle(Button attivo, Button inattivo)
        {
            attivo.BackColor   = Color.FromArgb(90, 192, 192, 255);
            attivo.ForeColor   = Color.White;
            inattivo.BackColor = Color.White;
            inattivo.ForeColor = Color.Black;
        }
    }
}
