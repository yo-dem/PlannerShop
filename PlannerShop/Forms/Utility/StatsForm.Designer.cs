namespace PlannerShop.Forms
{
    partial class StatsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlAccent = new Panel();
            pnlHeader = new Panel();
            lblTitolo = new Label();
            pnlFiltri = new Panel();
            btnAggiorna = new Button();
            dtpA = new DateTimePicker();
            lblA = new Label();
            dtpDa = new DateTimePicker();
            lblDa = new Label();
            rdbPersonalizzato = new RadioButton();
            rdbUltimaSettimana = new RadioButton();
            rdbUltimoAnno = new RadioButton();
            rdbDaSempre = new RadioButton();
            lblPeriodo = new Label();
            pnlSepFiltri = new Panel();
            tabControl = new TabControl();
            tabDati = new TabPage();
            tabGrafici = new TabPage();

            // ── Tab Dati ──
            pnlBody = new Panel();
            grpTopClienti = new GroupBox();
            dgvTopClienti = new DataGridView();
            pnlSpacerBottom = new Panel();
            grpTopProdotti = new GroupBox();
            dgvTopProdotti = new DataGridView();
            pnlSpacerMid = new Panel();
            pnlCards = new FlowLayoutPanel();
            grpBilancio = new GroupBox();
            pnlBilancioContent = new Panel();
            pnlUtileRow = new Panel();
            pnlSepUtile = new Panel();
            lblUtileVal = new Label();
            lblUtile = new Label();
            pnlUsciteRow = new Panel();
            lblUsciteVal = new Label();
            lblUscite = new Label();
            pnlEntrateRow = new Panel();
            lblEntrateVal = new Label();
            lblEntrate = new Label();
            grpInventario = new GroupBox();
            pnlInvContent = new Panel();
            lblInvIvato = new Label();
            lblInvNetto = new Label();
            grpProdotti = new GroupBox();
            pnlProdContent = new Panel();
            lblNumProdottiSub = new Label();
            lblNumProdotti = new Label();

            // ── Tab Grafici ──
            pnlGrafici = new Panel();
            grpGrBilancio = new GroupBox();
            pnlGrBilancioToggle = new Panel();
            grpGrClienti = new GroupBox();
            pnlGrClientiToggle = new Panel();
            btnGrClientiTorta = new Button();
            btnGrClientiBarre = new Button();
            grpGrProdotti = new GroupBox();
            pnlGrProdottiToggle = new Panel();
            btnGrProdottiTorta = new Button();
            btnGrProdottiBarre = new Button();
            pnlGrSpacerC = new Panel();
            pnlGrSpacerP = new Panel();

            pnlAccent.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlFiltri.SuspendLayout();
            tabControl.SuspendLayout();
            tabDati.SuspendLayout();
            tabGrafici.SuspendLayout();
            pnlBody.SuspendLayout();
            grpTopClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopClienti).BeginInit();
            grpTopProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopProdotti).BeginInit();
            pnlCards.SuspendLayout();
            grpBilancio.SuspendLayout();
            pnlBilancioContent.SuspendLayout();
            pnlUtileRow.SuspendLayout();
            pnlUsciteRow.SuspendLayout();
            pnlEntrateRow.SuspendLayout();
            grpInventario.SuspendLayout();
            pnlInvContent.SuspendLayout();
            grpProdotti.SuspendLayout();
            pnlProdContent.SuspendLayout();
            pnlGrafici.SuspendLayout();
            grpGrBilancio.SuspendLayout();
            grpGrClienti.SuspendLayout();
            grpGrProdotti.SuspendLayout();
            SuspendLayout();

            // ── pnlAccent ──────────────────────────────────────────────────────
            pnlAccent.BackColor = Color.FromArgb(192, 192, 255);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1020, 8);

            // ── pnlHeader ──────────────────────────────────────────────────────
            pnlHeader.BackColor = Color.White;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(14, 10, 14, 0);
            pnlHeader.Size = new Size(1020, 52);
            pnlHeader.Controls.Add(lblTitolo);

            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitolo.ForeColor = Color.FromArgb(90, 192, 192, 255);
            lblTitolo.Location = new Point(14, 10);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Text = "STATISTICHE";

            // ── pnlFiltri ──────────────────────────────────────────────────────
            pnlFiltri.BackColor = Color.White;
            pnlFiltri.Dock = DockStyle.Top;
            pnlFiltri.Name = "pnlFiltri";
            pnlFiltri.Size = new Size(1020, 88);

            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPeriodo.Location = new Point(14, 14);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Text = "PERIODO:";

            rdbDaSempre.AutoSize = true;
            rdbDaSempre.Font = new Font("Segoe UI", 9F);
            rdbDaSempre.Location = new Point(98, 12);
            rdbDaSempre.Name = "rdbDaSempre";
            rdbDaSempre.Text = "Da sempre";
            rdbDaSempre.UseVisualStyleBackColor = true;

            rdbUltimoAnno.AutoSize = true;
            rdbUltimoAnno.Font = new Font("Segoe UI", 9F);
            rdbUltimoAnno.Location = new Point(200, 12);
            rdbUltimoAnno.Name = "rdbUltimoAnno";
            rdbUltimoAnno.Text = "Ultimo anno";
            rdbUltimoAnno.UseVisualStyleBackColor = true;

            rdbUltimaSettimana.AutoSize = true;
            rdbUltimaSettimana.Font = new Font("Segoe UI", 9F);
            rdbUltimaSettimana.Location = new Point(310, 12);
            rdbUltimaSettimana.Name = "rdbUltimaSettimana";
            rdbUltimaSettimana.Text = "Ultima settimana";
            rdbUltimaSettimana.UseVisualStyleBackColor = true;

            rdbPersonalizzato.AutoSize = true;
            rdbPersonalizzato.Font = new Font("Segoe UI", 9F);
            rdbPersonalizzato.Location = new Point(440, 12);
            rdbPersonalizzato.Name = "rdbPersonalizzato";
            rdbPersonalizzato.Text = "Personalizzato";
            rdbPersonalizzato.UseVisualStyleBackColor = true;
            rdbPersonalizzato.CheckedChanged += rdbPersonalizzato_CheckedChanged;

            lblDa.AutoSize = true;
            lblDa.Font = new Font("Segoe UI", 9F);
            lblDa.Location = new Point(98, 48);
            lblDa.Name = "lblDa";
            lblDa.Text = "Da:";
            lblDa.Visible = false;

            dtpDa.Format = DateTimePickerFormat.Short;
            dtpDa.Location = new Point(118, 44);
            dtpDa.Name = "dtpDa";
            dtpDa.Size = new Size(140, 23);
            dtpDa.Visible = false;

            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 9F);
            lblA.Location = new Point(274, 48);
            lblA.Name = "lblA";
            lblA.Text = "A:";
            lblA.Visible = false;

            dtpA.Format = DateTimePickerFormat.Short;
            dtpA.Location = new Point(294, 44);
            dtpA.Name = "dtpA";
            dtpA.Size = new Size(140, 23);
            dtpA.Visible = false;

            btnAggiorna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggiorna.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnAggiorna.FlatAppearance.BorderSize = 0;
            btnAggiorna.FlatStyle = FlatStyle.Flat;
            btnAggiorna.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAggiorna.Location = new Point(870, 28);
            btnAggiorna.Name = "btnAggiorna";
            btnAggiorna.Size = new Size(130, 30);
            btnAggiorna.Text = "AGGIORNA";
            btnAggiorna.UseVisualStyleBackColor = false;
            btnAggiorna.Click += btnAggiorna_Click;

            pnlFiltri.Controls.Add(lblPeriodo);
            pnlFiltri.Controls.Add(rdbDaSempre);
            pnlFiltri.Controls.Add(rdbUltimoAnno);
            pnlFiltri.Controls.Add(rdbUltimaSettimana);
            pnlFiltri.Controls.Add(rdbPersonalizzato);
            pnlFiltri.Controls.Add(lblDa);
            pnlFiltri.Controls.Add(dtpDa);
            pnlFiltri.Controls.Add(lblA);
            pnlFiltri.Controls.Add(dtpA);
            pnlFiltri.Controls.Add(btnAggiorna);

            // ── pnlSepFiltri ───────────────────────────────────────────────────
            pnlSepFiltri.BackColor = Color.DarkGray;
            pnlSepFiltri.Dock = DockStyle.Top;
            pnlSepFiltri.Name = "pnlSepFiltri";
            pnlSepFiltri.Size = new Size(1020, 1);

            // ══════════════════════════════════════════════════════════════════
            // TAB DATI
            // ══════════════════════════════════════════════════════════════════

            grpProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpProdotti.Margin = new Padding(4);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Padding = new Padding(8);
            grpProdotti.Size = new Size(310, 148);
            grpProdotti.Text = "PRODOTTI A CATALOGO";
            grpProdotti.Controls.Add(pnlProdContent);

            pnlProdContent.Dock = DockStyle.Fill;
            pnlProdContent.Name = "pnlProdContent";
            pnlProdContent.Padding = new Padding(8, 2, 8, 4);
            pnlProdContent.Controls.Add(lblNumProdottiSub);
            pnlProdContent.Controls.Add(lblNumProdotti);

            lblNumProdotti.AutoSize = false;
            lblNumProdotti.Dock = DockStyle.Fill;
            lblNumProdotti.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold);
            lblNumProdotti.ForeColor = Color.FromArgb(90, 192, 192, 255);
            lblNumProdotti.Name = "lblNumProdotti";
            lblNumProdotti.Text = "0";
            lblNumProdotti.TextAlign = ContentAlignment.MiddleCenter;

            lblNumProdottiSub.AutoSize = false;
            lblNumProdottiSub.Dock = DockStyle.Bottom;
            lblNumProdottiSub.Font = new Font("Segoe UI", 8.5F);
            lblNumProdottiSub.ForeColor = Color.Gray;
            lblNumProdottiSub.Height = 20;
            lblNumProdottiSub.Name = "lblNumProdottiSub";
            lblNumProdottiSub.Text = "prodotti in catalogo";
            lblNumProdottiSub.TextAlign = ContentAlignment.MiddleCenter;

            grpInventario.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpInventario.Margin = new Padding(4);
            grpInventario.Name = "grpInventario";
            grpInventario.Padding = new Padding(8);
            grpInventario.Size = new Size(340, 148);
            grpInventario.Text = "VALORE INVENTARIO (snapshot attuale)";
            grpInventario.Controls.Add(pnlInvContent);

            pnlInvContent.Dock = DockStyle.Fill;
            pnlInvContent.Name = "pnlInvContent";
            pnlInvContent.Padding = new Padding(8, 4, 8, 4);
            pnlInvContent.Controls.Add(lblInvIvato);
            pnlInvContent.Controls.Add(lblInvNetto);

            lblInvNetto.AutoSize = false;
            lblInvNetto.Dock = DockStyle.Top;
            lblInvNetto.Font = new Font("Segoe UI", 14F);
            lblInvNetto.ForeColor = Color.FromArgb(40, 120, 40);
            lblInvNetto.Height = 40;
            lblInvNetto.Name = "lblInvNetto";
            lblInvNetto.Text = "Netto: 0,00 €";
            lblInvNetto.TextAlign = ContentAlignment.MiddleLeft;

            lblInvIvato.AutoSize = false;
            lblInvIvato.Dock = DockStyle.Top;
            lblInvIvato.Font = new Font("Segoe UI", 14F);
            lblInvIvato.ForeColor = Color.FromArgb(70, 70, 70);
            lblInvIvato.Height = 40;
            lblInvIvato.Name = "lblInvIvato";
            lblInvIvato.Text = "IVA incl.: 0,00 €";
            lblInvIvato.TextAlign = ContentAlignment.MiddleLeft;

            grpBilancio.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpBilancio.Margin = new Padding(4);
            grpBilancio.Name = "grpBilancio";
            grpBilancio.Padding = new Padding(8);
            grpBilancio.Size = new Size(330, 148);
            grpBilancio.Text = "BILANCIO PERIODO";
            grpBilancio.Controls.Add(pnlBilancioContent);

            pnlBilancioContent.Dock = DockStyle.Fill;
            pnlBilancioContent.Name = "pnlBilancioContent";
            pnlBilancioContent.Padding = new Padding(8, 2, 8, 2);
            pnlBilancioContent.Controls.Add(pnlUtileRow);
            pnlBilancioContent.Controls.Add(pnlSepUtile);
            pnlBilancioContent.Controls.Add(pnlUsciteRow);
            pnlBilancioContent.Controls.Add(pnlEntrateRow);

            pnlEntrateRow.Dock = DockStyle.Top;
            pnlEntrateRow.Height = 30;
            pnlEntrateRow.Name = "pnlEntrateRow";
            pnlEntrateRow.Controls.Add(lblEntrateVal);
            pnlEntrateRow.Controls.Add(lblEntrate);

            lblEntrate.AutoSize = true;
            lblEntrate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEntrate.ForeColor = Color.FromArgb(40, 130, 40);
            lblEntrate.Location = new Point(0, 7);
            lblEntrate.Name = "lblEntrate";
            lblEntrate.Text = "ENTRATE";

            lblEntrateVal.AutoSize = true;
            lblEntrateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEntrateVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEntrateVal.ForeColor = Color.FromArgb(40, 130, 40);
            lblEntrateVal.Location = new Point(190, 7);
            lblEntrateVal.Name = "lblEntrateVal";
            lblEntrateVal.Text = "0,00 €";

            pnlUsciteRow.Dock = DockStyle.Top;
            pnlUsciteRow.Height = 30;
            pnlUsciteRow.Name = "pnlUsciteRow";
            pnlUsciteRow.Controls.Add(lblUsciteVal);
            pnlUsciteRow.Controls.Add(lblUscite);

            lblUscite.AutoSize = true;
            lblUscite.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUscite.ForeColor = Color.FromArgb(180, 60, 60);
            lblUscite.Location = new Point(0, 7);
            lblUscite.Name = "lblUscite";
            lblUscite.Text = "USCITE";

            lblUsciteVal.AutoSize = true;
            lblUsciteVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsciteVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsciteVal.ForeColor = Color.FromArgb(180, 60, 60);
            lblUsciteVal.Location = new Point(190, 7);
            lblUsciteVal.Name = "lblUsciteVal";
            lblUsciteVal.Text = "0,00 €";

            pnlSepUtile.BackColor = Color.DarkGray;
            pnlSepUtile.Dock = DockStyle.Top;
            pnlSepUtile.Height = 1;
            pnlSepUtile.Name = "pnlSepUtile";

            pnlUtileRow.Dock = DockStyle.Top;
            pnlUtileRow.Height = 34;
            pnlUtileRow.Name = "pnlUtileRow";
            pnlUtileRow.Controls.Add(lblUtileVal);
            pnlUtileRow.Controls.Add(lblUtile);

            lblUtile.AutoSize = true;
            lblUtile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtile.Location = new Point(0, 8);
            lblUtile.Name = "lblUtile";
            lblUtile.Text = "SALDO";

            lblUtileVal.AutoSize = true;
            lblUtileVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUtileVal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtileVal.Location = new Point(190, 8);
            lblUtileVal.Name = "lblUtileVal";
            lblUtileVal.Text = "0,00 €";

            pnlCards.AutoSize = false;
            pnlCards.Dock = DockStyle.Top;
            pnlCards.FlowDirection = FlowDirection.LeftToRight;
            pnlCards.Height = 158;
            pnlCards.Name = "pnlCards";
            pnlCards.WrapContents = false;
            pnlCards.Controls.Add(grpProdotti);
            pnlCards.Controls.Add(grpInventario);
            pnlCards.Controls.Add(grpBilancio);

            pnlSpacerMid.Dock = DockStyle.Top;
            pnlSpacerMid.Height = 10;
            pnlSpacerMid.Name = "pnlSpacerMid";

            grpTopProdotti.Dock = DockStyle.Top;
            grpTopProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopProdotti.Height = 232;
            grpTopProdotti.Name = "grpTopProdotti";
            grpTopProdotti.Padding = new Padding(6, 4, 6, 6);
            grpTopProdotti.Text = "CLASSIFICA PRODOTTI PIÙ VENDUTI (TOP 10)";
            grpTopProdotti.Controls.Add(dgvTopProdotti);

            dgvTopProdotti.Dock = DockStyle.Fill;
            dgvTopProdotti.Name = "dgvTopProdotti";

            pnlSpacerBottom.Dock = DockStyle.Top;
            pnlSpacerBottom.Height = 10;
            pnlSpacerBottom.Name = "pnlSpacerBottom";

            grpTopClienti.Dock = DockStyle.Top;
            grpTopClienti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopClienti.Height = 232;
            grpTopClienti.Name = "grpTopClienti";
            grpTopClienti.Padding = new Padding(6, 4, 6, 6);
            grpTopClienti.Text = "CLASSIFICA CLIENTI PIÙ FREQUENTI (TOP 10)";
            grpTopClienti.Controls.Add(dgvTopClienti);

            dgvTopClienti.Dock = DockStyle.Fill;
            dgvTopClienti.Name = "dgvTopClienti";

            // ordine inverso per Dock=Top
            pnlBody.AutoScroll = true;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(10, 8, 10, 8);
            pnlBody.Controls.Add(grpTopClienti);
            pnlBody.Controls.Add(pnlSpacerBottom);
            pnlBody.Controls.Add(grpTopProdotti);
            pnlBody.Controls.Add(pnlSpacerMid);
            pnlBody.Controls.Add(pnlCards);

            // ══════════════════════════════════════════════════════════════════
            // TAB GRAFICI
            // ══════════════════════════════════════════════════════════════════

            // grpGrBilancio (solo barre, nessun toggle)
            grpGrBilancio.Dock = DockStyle.Top;
            grpGrBilancio.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrBilancio.Height = 270;
            grpGrBilancio.Name = "grpGrBilancio";
            grpGrBilancio.Padding = new Padding(8, 6, 8, 8);
            grpGrBilancio.Text = "BILANCIO ENTRATE / USCITE";
            pnlGrBilancioToggle.Dock = DockStyle.Top;
            pnlGrBilancioToggle.Height = 0;
            pnlGrBilancioToggle.Name = "pnlGrBilancioToggle";
            grpGrBilancio.Controls.Add(pnlGrBilancioToggle);

            // grpGrProdotti
            btnGrProdottiBarre.Name = "btnGrProdottiBarre";
            btnGrProdottiBarre.Text = "■  BARRE";
            btnGrProdottiBarre.Size = new Size(90, 26);
            btnGrProdottiBarre.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrProdottiBarre.FlatStyle = FlatStyle.Flat;
            btnGrProdottiBarre.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnGrProdottiBarre.ForeColor = Color.White;
            btnGrProdottiBarre.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrProdottiBarre.UseVisualStyleBackColor = false;
            btnGrProdottiBarre.Margin = new Padding(0, 0, 6, 0);
            btnGrProdottiBarre.Click += btnGrProdottiBarre_Click;

            btnGrProdottiTorta.Name = "btnGrProdottiTorta";
            btnGrProdottiTorta.Text = "◎  TORTA";
            btnGrProdottiTorta.Size = new Size(90, 26);
            btnGrProdottiTorta.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrProdottiTorta.FlatStyle = FlatStyle.Flat;
            btnGrProdottiTorta.BackColor = Color.White;
            btnGrProdottiTorta.ForeColor = Color.Black;
            btnGrProdottiTorta.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrProdottiTorta.UseVisualStyleBackColor = false;
            btnGrProdottiTorta.Margin = new Padding(0, 0, 6, 0);
            btnGrProdottiTorta.Click += btnGrProdottiTorta_Click;

            pnlGrProdottiToggle.Dock = DockStyle.Top;
            pnlGrProdottiToggle.Height = 34;
            pnlGrProdottiToggle.Name = "pnlGrProdottiToggle";
            pnlGrProdottiToggle.Padding = new Padding(0, 4, 0, 0);
            pnlGrProdottiToggle.Controls.Add(btnGrProdottiBarre);
            pnlGrProdottiToggle.Controls.Add(btnGrProdottiTorta);

            grpGrProdotti.Dock = DockStyle.Top;
            grpGrProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrProdotti.Height = 310;
            grpGrProdotti.Name = "grpGrProdotti";
            grpGrProdotti.Padding = new Padding(8, 6, 8, 8);
            grpGrProdotti.Text = "PRODOTTI PIÙ VENDUTI";
            grpGrProdotti.Controls.Add(pnlGrProdottiToggle);

            pnlGrSpacerP.Dock = DockStyle.Top;
            pnlGrSpacerP.Height = 10;
            pnlGrSpacerP.Name = "pnlGrSpacerP";

            // grpGrClienti
            btnGrClientiBarre.Name = "btnGrClientiBarre";
            btnGrClientiBarre.Text = "■  BARRE";
            btnGrClientiBarre.Size = new Size(90, 26);
            btnGrClientiBarre.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrClientiBarre.FlatStyle = FlatStyle.Flat;
            btnGrClientiBarre.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnGrClientiBarre.ForeColor = Color.White;
            btnGrClientiBarre.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrClientiBarre.UseVisualStyleBackColor = false;
            btnGrClientiBarre.Margin = new Padding(0, 0, 6, 0);
            btnGrClientiBarre.Click += btnGrClientiBarre_Click;

            btnGrClientiTorta.Name = "btnGrClientiTorta";
            btnGrClientiTorta.Text = "◎  TORTA";
            btnGrClientiTorta.Size = new Size(90, 26);
            btnGrClientiTorta.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrClientiTorta.FlatStyle = FlatStyle.Flat;
            btnGrClientiTorta.BackColor = Color.White;
            btnGrClientiTorta.ForeColor = Color.Black;
            btnGrClientiTorta.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrClientiTorta.UseVisualStyleBackColor = false;
            btnGrClientiTorta.Margin = new Padding(0, 0, 6, 0);
            btnGrClientiTorta.Click += btnGrClientiTorta_Click;

            pnlGrClientiToggle.Dock = DockStyle.Top;
            pnlGrClientiToggle.Height = 34;
            pnlGrClientiToggle.Name = "pnlGrClientiToggle";
            pnlGrClientiToggle.Padding = new Padding(0, 4, 0, 0);
            pnlGrClientiToggle.Controls.Add(btnGrClientiBarre);
            pnlGrClientiToggle.Controls.Add(btnGrClientiTorta);

            grpGrClienti.Dock = DockStyle.Top;
            grpGrClienti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrClienti.Height = 310;
            grpGrClienti.Name = "grpGrClienti";
            grpGrClienti.Padding = new Padding(8, 6, 8, 8);
            grpGrClienti.Text = "CLIENTI PIÙ FREQUENTI";
            grpGrClienti.Controls.Add(pnlGrClientiToggle);

            pnlGrSpacerC.Dock = DockStyle.Top;
            pnlGrSpacerC.Height = 10;
            pnlGrSpacerC.Name = "pnlGrSpacerC";

            // pnlGrafici – ordine inverso per Dock=Top
            pnlGrafici.AutoScroll = true;
            pnlGrafici.Dock = DockStyle.Fill;
            pnlGrafici.Name = "pnlGrafici";
            pnlGrafici.Padding = new Padding(10, 8, 10, 8);
            pnlGrafici.Controls.Add(grpGrClienti);
            pnlGrafici.Controls.Add(pnlGrSpacerC);
            pnlGrafici.Controls.Add(grpGrProdotti);
            pnlGrafici.Controls.Add(pnlGrSpacerP);
            pnlGrafici.Controls.Add(grpGrBilancio);

            // ── TabControl ─────────────────────────────────────────────────────
            tabDati.BackColor = SystemColors.Control;
            tabDati.Name = "tabDati";
            tabDati.Padding = new Padding(0);
            tabDati.Text = "  DATI  ";
            tabDati.Controls.Add(pnlBody);

            tabGrafici.BackColor = SystemColors.Control;
            tabGrafici.Name = "tabGrafici";
            tabGrafici.Padding = new Padding(0);
            tabGrafici.Text = "  GRAFICI  ";
            tabGrafici.Controls.Add(pnlGrafici);

            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(12, 4);
            tabControl.Controls.Add(tabDati);
            tabControl.Controls.Add(tabGrafici);

            // ── Form ───────────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 790);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(900, 680);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistiche";
            Load += StatsForm_Load;

            Controls.Add(tabControl);
            Controls.Add(pnlSepFiltri);
            Controls.Add(pnlFiltri);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);

            pnlAccent.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltri.ResumeLayout(false);
            pnlFiltri.PerformLayout();
            tabControl.ResumeLayout(false);
            tabDati.ResumeLayout(false);
            tabGrafici.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpTopClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopClienti).EndInit();
            grpTopProdotti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopProdotti).EndInit();
            pnlCards.ResumeLayout(false);
            grpBilancio.ResumeLayout(false);
            pnlBilancioContent.ResumeLayout(false);
            pnlUtileRow.ResumeLayout(false);
            pnlUtileRow.PerformLayout();
            pnlUsciteRow.ResumeLayout(false);
            pnlUsciteRow.PerformLayout();
            pnlEntrateRow.ResumeLayout(false);
            pnlEntrateRow.PerformLayout();
            grpInventario.ResumeLayout(false);
            pnlInvContent.ResumeLayout(false);
            grpProdotti.ResumeLayout(false);
            pnlProdContent.ResumeLayout(false);
            pnlGrafici.ResumeLayout(false);
            grpGrBilancio.ResumeLayout(false);
            grpGrClienti.ResumeLayout(false);
            grpGrProdotti.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ── Tab Dati ──────────────────────────────────────────────────────────
        private Panel pnlAccent;
        private Panel pnlHeader;
        private Label lblTitolo;
        private Panel pnlFiltri;
        private Label lblPeriodo;
        private RadioButton rdbDaSempre;
        private RadioButton rdbUltimoAnno;
        private RadioButton rdbUltimaSettimana;
        private RadioButton rdbPersonalizzato;
        private Label lblDa;
        private DateTimePicker dtpDa;
        private Label lblA;
        private DateTimePicker dtpA;
        private Button btnAggiorna;
        private Panel pnlSepFiltri;
        private TabControl tabControl;
        private TabPage tabDati;
        private TabPage tabGrafici;
        private Panel pnlBody;
        private FlowLayoutPanel pnlCards;
        private GroupBox grpProdotti;
        private Panel pnlProdContent;
        private Label lblNumProdotti;
        private Label lblNumProdottiSub;
        private GroupBox grpInventario;
        private Panel pnlInvContent;
        private Label lblInvNetto;
        private Label lblInvIvato;
        private GroupBox grpBilancio;
        private Panel pnlBilancioContent;
        private Panel pnlEntrateRow;
        private Label lblEntrate;
        private Label lblEntrateVal;
        private Panel pnlUsciteRow;
        private Label lblUscite;
        private Label lblUsciteVal;
        private Panel pnlSepUtile;
        private Panel pnlUtileRow;
        private Label lblUtile;
        private Label lblUtileVal;
        private Panel pnlSpacerMid;
        private GroupBox grpTopProdotti;
        private DataGridView dgvTopProdotti;
        private Panel pnlSpacerBottom;
        private GroupBox grpTopClienti;
        private DataGridView dgvTopClienti;

        // ── Tab Grafici ───────────────────────────────────────────────────────
        private Panel pnlGrafici;
        private GroupBox grpGrBilancio;
        private Panel pnlGrBilancioToggle;
        private GroupBox grpGrClienti;
        private Panel pnlGrClientiToggle;
        private Button btnGrClientiTorta;
        private Button btnGrClientiBarre;
        private GroupBox grpGrProdotti;
        private Panel pnlGrProdottiToggle;
        private Button btnGrProdottiTorta;
        private Button btnGrProdottiBarre;
        private Panel pnlGrSpacerC;
        private Panel pnlGrSpacerP;
    }
}
