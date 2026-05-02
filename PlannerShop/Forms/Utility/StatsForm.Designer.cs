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
            lblPeriodo = new Label();
            rdbDaSempre = new RadioButton();
            rdbUltimoAnno = new RadioButton();
            rdbUltimaSettimana = new RadioButton();
            rdbPersonalizzato = new RadioButton();
            lblDa = new Label();
            dtpDa = new DateTimePicker();
            lblA = new Label();
            dtpA = new DateTimePicker();
            btnAggiorna = new Button();
            pnlSepFiltri = new Panel();
            tabControl = new TabControl();
            tabDati = new TabPage();
            pnlBody = new Panel();
            grpTopClienti = new GroupBox();
            dgvTopClienti = new DataGridView();
            pnlSpacerBottom = new Panel();
            grpTopProdotti = new GroupBox();
            dgvTopProdotti = new DataGridView();
            pnlSpacerMid = new Panel();
            pnlCards = new FlowLayoutPanel();
            grpProdotti = new GroupBox();
            pnlProdContent = new Panel();
            lblNumProdottiSub = new Label();
            lblNumProdotti = new Label();
            grpInventario = new GroupBox();
            pnlInvContent = new Panel();
            lblInvNetto = new Label();
            grpBilancio = new GroupBox();
            pnlBilancioContent = new Panel();
            pnlUtileRow = new Panel();
            lblUtileVal = new Label();
            lblUtile = new Label();
            pnlSepUtile = new Panel();
            pnlUsciteRow = new Panel();
            lblUsciteVal = new Label();
            lblUscite = new Label();
            pnlEntrateRow = new Panel();
            lblEntrateVal = new Label();
            lblEntrate = new Label();
            tabGrafici = new TabPage();
            pnlGrafici = new Panel();
            grpGrClienti = new GroupBox();
            pnlGrClientiToggle = new Panel();
            btnGrClientiBarre = new Button();
            btnGrClientiTorta = new Button();
            pnlGrSpacerC = new Panel();
            grpGrProdotti = new GroupBox();
            pnlGrProdottiToggle = new Panel();
            btnGrProdottiBarre = new Button();
            btnGrProdottiTorta = new Button();
            pnlGrSpacerP = new Panel();
            grpGrBilancio = new GroupBox();
            pnlGrBilancioToggle = new Panel();
            pnlHeader.SuspendLayout();
            pnlFiltri.SuspendLayout();
            tabControl.SuspendLayout();
            tabDati.SuspendLayout();
            pnlBody.SuspendLayout();
            grpTopClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopClienti).BeginInit();
            grpTopProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopProdotti).BeginInit();
            pnlCards.SuspendLayout();
            grpProdotti.SuspendLayout();
            pnlProdContent.SuspendLayout();
            grpInventario.SuspendLayout();
            pnlInvContent.SuspendLayout();
            grpBilancio.SuspendLayout();
            pnlBilancioContent.SuspendLayout();
            pnlUtileRow.SuspendLayout();
            pnlUsciteRow.SuspendLayout();
            pnlEntrateRow.SuspendLayout();
            tabGrafici.SuspendLayout();
            pnlGrafici.SuspendLayout();
            grpGrClienti.SuspendLayout();
            pnlGrClientiToggle.SuspendLayout();
            grpGrProdotti.SuspendLayout();
            pnlGrProdottiToggle.SuspendLayout();
            grpGrBilancio.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(192, 192, 255);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Margin = new Padding(3, 4, 3, 4);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1166, 11);
            pnlAccent.TabIndex = 4;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitolo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 11);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(16, 13, 16, 0);
            pnlHeader.Size = new Size(1166, 69);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitolo.ForeColor = Color.FromArgb(90, 192, 192, 255);
            lblTitolo.Location = new Point(16, 13);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(192, 41);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "STATISTICHE";
            // 
            // pnlFiltri
            // 
            pnlFiltri.BackColor = Color.White;
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
            pnlFiltri.Dock = DockStyle.Top;
            pnlFiltri.Location = new Point(0, 80);
            pnlFiltri.Margin = new Padding(3, 4, 3, 4);
            pnlFiltri.Name = "pnlFiltri";
            pnlFiltri.Size = new Size(1166, 117);
            pnlFiltri.TabIndex = 2;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPeriodo.Location = new Point(16, 19);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(76, 20);
            lblPeriodo.TabIndex = 0;
            lblPeriodo.Text = "PERIODO:";
            // 
            // rdbDaSempre
            // 
            rdbDaSempre.AutoSize = true;
            rdbDaSempre.Font = new Font("Segoe UI", 9F);
            rdbDaSempre.Location = new Point(112, 16);
            rdbDaSempre.Margin = new Padding(3, 4, 3, 4);
            rdbDaSempre.Name = "rdbDaSempre";
            rdbDaSempre.Size = new Size(109, 24);
            rdbDaSempre.TabIndex = 1;
            rdbDaSempre.Text = "DA SEMPRE";
            rdbDaSempre.UseVisualStyleBackColor = true;
            // 
            // rdbUltimoAnno
            // 
            rdbUltimoAnno.AutoSize = true;
            rdbUltimoAnno.Font = new Font("Segoe UI", 9F);
            rdbUltimoAnno.Location = new Point(227, 15);
            rdbUltimoAnno.Margin = new Padding(3, 4, 3, 4);
            rdbUltimoAnno.Name = "rdbUltimoAnno";
            rdbUltimoAnno.Size = new Size(129, 24);
            rdbUltimoAnno.TabIndex = 2;
            rdbUltimoAnno.Text = "ULTIMO ANNO";
            rdbUltimoAnno.UseVisualStyleBackColor = true;
            // 
            // rdbUltimaSettimana
            // 
            rdbUltimaSettimana.AutoSize = true;
            rdbUltimaSettimana.Font = new Font("Segoe UI", 9F);
            rdbUltimaSettimana.Location = new Point(362, 15);
            rdbUltimaSettimana.Margin = new Padding(3, 4, 3, 4);
            rdbUltimaSettimana.Name = "rdbUltimaSettimana";
            rdbUltimaSettimana.Size = new Size(165, 24);
            rdbUltimaSettimana.TabIndex = 3;
            rdbUltimaSettimana.Text = "ULTIMA SETTIMANA";
            rdbUltimaSettimana.UseVisualStyleBackColor = true;
            // 
            // rdbPersonalizzato
            // 
            rdbPersonalizzato.AutoSize = true;
            rdbPersonalizzato.Font = new Font("Segoe UI", 9F);
            rdbPersonalizzato.Location = new Point(533, 15);
            rdbPersonalizzato.Margin = new Padding(3, 4, 3, 4);
            rdbPersonalizzato.Name = "rdbPersonalizzato";
            rdbPersonalizzato.Size = new Size(151, 24);
            rdbPersonalizzato.TabIndex = 4;
            rdbPersonalizzato.Text = "PERSONALIZZATO";
            rdbPersonalizzato.UseVisualStyleBackColor = true;
            rdbPersonalizzato.CheckedChanged += rdbPersonalizzato_CheckedChanged;
            // 
            // lblDa
            // 
            lblDa.AutoSize = true;
            lblDa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDa.Location = new Point(16, 47);
            lblDa.Name = "lblDa";
            lblDa.Size = new Size(35, 20);
            lblDa.TabIndex = 5;
            lblDa.Text = "DA:";
            lblDa.Visible = false;
            // 
            // dtpDa
            // 
            dtpDa.Format = DateTimePickerFormat.Short;
            dtpDa.Location = new Point(22, 71);
            dtpDa.Margin = new Padding(3, 4, 3, 4);
            dtpDa.Name = "dtpDa";
            dtpDa.Size = new Size(159, 27);
            dtpDa.TabIndex = 6;
            dtpDa.Visible = false;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(186, 47);
            lblA.Name = "lblA";
            lblA.Size = new Size(24, 20);
            lblA.TabIndex = 7;
            lblA.Text = "A:";
            lblA.Visible = false;
            // 
            // dtpA
            // 
            dtpA.Format = DateTimePickerFormat.Short;
            dtpA.Location = new Point(187, 71);
            dtpA.Margin = new Padding(3, 4, 3, 4);
            dtpA.Name = "dtpA";
            dtpA.Size = new Size(159, 27);
            dtpA.TabIndex = 8;
            dtpA.Visible = false;
            // 
            // btnAggiorna
            // 
            btnAggiorna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggiorna.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnAggiorna.FlatAppearance.BorderSize = 0;
            btnAggiorna.FlatStyle = FlatStyle.Flat;
            btnAggiorna.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAggiorna.Location = new Point(994, 37);
            btnAggiorna.Margin = new Padding(3, 4, 3, 4);
            btnAggiorna.Name = "btnAggiorna";
            btnAggiorna.Size = new Size(149, 40);
            btnAggiorna.TabIndex = 9;
            btnAggiorna.Text = "AGGIORNA";
            btnAggiorna.UseVisualStyleBackColor = false;
            btnAggiorna.Click += btnAggiorna_Click;
            // 
            // pnlSepFiltri
            // 
            pnlSepFiltri.BackColor = Color.DarkGray;
            pnlSepFiltri.Dock = DockStyle.Top;
            pnlSepFiltri.Location = new Point(0, 197);
            pnlSepFiltri.Margin = new Padding(3, 4, 3, 4);
            pnlSepFiltri.Name = "pnlSepFiltri";
            pnlSepFiltri.Size = new Size(1166, 1);
            pnlSepFiltri.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabDati);
            tabControl.Controls.Add(tabGrafici);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            tabControl.Location = new Point(0, 198);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(12, 4);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1166, 655);
            tabControl.TabIndex = 0;
            // 
            // tabDati
            // 
            tabDati.BackColor = SystemColors.Control;
            tabDati.Controls.Add(pnlBody);
            tabDati.Location = new Point(4, 31);
            tabDati.Margin = new Padding(3, 4, 3, 4);
            tabDati.Name = "tabDati";
            tabDati.Size = new Size(1158, 620);
            tabDati.TabIndex = 0;
            tabDati.Text = "  DATI  ";
            // 
            // pnlBody
            // 
            pnlBody.AutoScroll = true;
            pnlBody.Controls.Add(grpTopClienti);
            pnlBody.Controls.Add(pnlSpacerBottom);
            pnlBody.Controls.Add(grpTopProdotti);
            pnlBody.Controls.Add(pnlSpacerMid);
            pnlBody.Controls.Add(pnlCards);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 0);
            pnlBody.Margin = new Padding(3, 4, 3, 4);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(11);
            pnlBody.Size = new Size(1158, 620);
            pnlBody.TabIndex = 0;
            // 
            // grpTopClienti
            // 
            grpTopClienti.Controls.Add(dgvTopClienti);
            grpTopClienti.Dock = DockStyle.Top;
            grpTopClienti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopClienti.Location = new Point(11, 557);
            grpTopClienti.Margin = new Padding(3, 4, 3, 4);
            grpTopClienti.Name = "grpTopClienti";
            grpTopClienti.Padding = new Padding(7, 5, 7, 8);
            grpTopClienti.Size = new Size(1115, 309);
            grpTopClienti.TabIndex = 0;
            grpTopClienti.TabStop = false;
            grpTopClienti.Text = "CLASSIFICA CLIENTI PIÙ FREQUENTI (TOP 10)";
            // 
            // dgvTopClienti
            // 
            dgvTopClienti.ColumnHeadersHeight = 29;
            dgvTopClienti.Dock = DockStyle.Fill;
            dgvTopClienti.Location = new Point(7, 24);
            dgvTopClienti.Margin = new Padding(3, 4, 3, 4);
            dgvTopClienti.Name = "dgvTopClienti";
            dgvTopClienti.RowHeadersWidth = 51;
            dgvTopClienti.Size = new Size(1101, 277);
            dgvTopClienti.TabIndex = 0;
            // 
            // pnlSpacerBottom
            // 
            pnlSpacerBottom.Dock = DockStyle.Top;
            pnlSpacerBottom.Location = new Point(11, 544);
            pnlSpacerBottom.Margin = new Padding(3, 4, 3, 4);
            pnlSpacerBottom.Name = "pnlSpacerBottom";
            pnlSpacerBottom.Size = new Size(1115, 13);
            pnlSpacerBottom.TabIndex = 1;
            // 
            // grpTopProdotti
            // 
            grpTopProdotti.Controls.Add(dgvTopProdotti);
            grpTopProdotti.Dock = DockStyle.Top;
            grpTopProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopProdotti.Location = new Point(11, 235);
            grpTopProdotti.Margin = new Padding(3, 4, 3, 4);
            grpTopProdotti.Name = "grpTopProdotti";
            grpTopProdotti.Padding = new Padding(7, 5, 7, 8);
            grpTopProdotti.Size = new Size(1115, 309);
            grpTopProdotti.TabIndex = 2;
            grpTopProdotti.TabStop = false;
            grpTopProdotti.Text = "CLASSIFICA PRODOTTI PIÙ VENDUTI (TOP 10)";
            // 
            // dgvTopProdotti
            // 
            dgvTopProdotti.ColumnHeadersHeight = 29;
            dgvTopProdotti.Dock = DockStyle.Fill;
            dgvTopProdotti.Location = new Point(7, 24);
            dgvTopProdotti.Margin = new Padding(3, 4, 3, 4);
            dgvTopProdotti.Name = "dgvTopProdotti";
            dgvTopProdotti.RowHeadersWidth = 51;
            dgvTopProdotti.Size = new Size(1101, 277);
            dgvTopProdotti.TabIndex = 0;
            // 
            // pnlSpacerMid
            // 
            pnlSpacerMid.Dock = DockStyle.Top;
            pnlSpacerMid.Location = new Point(11, 222);
            pnlSpacerMid.Margin = new Padding(3, 4, 3, 4);
            pnlSpacerMid.Name = "pnlSpacerMid";
            pnlSpacerMid.Size = new Size(1115, 13);
            pnlSpacerMid.TabIndex = 3;
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(grpProdotti);
            pnlCards.Controls.Add(grpInventario);
            pnlCards.Controls.Add(grpBilancio);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(11, 11);
            pnlCards.Margin = new Padding(3, 4, 3, 4);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(1115, 211);
            pnlCards.TabIndex = 4;
            pnlCards.WrapContents = false;
            // 
            // grpProdotti
            // 
            grpProdotti.Controls.Add(pnlProdContent);
            grpProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpProdotti.Location = new Point(5, 5);
            grpProdotti.Margin = new Padding(5);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Padding = new Padding(9, 11, 9, 11);
            grpProdotti.Size = new Size(354, 197);
            grpProdotti.TabIndex = 0;
            grpProdotti.TabStop = false;
            grpProdotti.Text = "PRODOTTI A CATALOGO";
            // 
            // pnlProdContent
            // 
            pnlProdContent.Controls.Add(lblNumProdottiSub);
            pnlProdContent.Controls.Add(lblNumProdotti);
            pnlProdContent.Dock = DockStyle.Fill;
            pnlProdContent.Location = new Point(9, 30);
            pnlProdContent.Margin = new Padding(3, 4, 3, 4);
            pnlProdContent.Name = "pnlProdContent";
            pnlProdContent.Padding = new Padding(9, 3, 9, 5);
            pnlProdContent.Size = new Size(336, 156);
            pnlProdContent.TabIndex = 0;
            // 
            // lblNumProdottiSub
            // 
            lblNumProdottiSub.Dock = DockStyle.Bottom;
            lblNumProdottiSub.Font = new Font("Segoe UI", 8.5F);
            lblNumProdottiSub.ForeColor = Color.Gray;
            lblNumProdottiSub.Location = new Point(9, 124);
            lblNumProdottiSub.Name = "lblNumProdottiSub";
            lblNumProdottiSub.Size = new Size(318, 27);
            lblNumProdottiSub.TabIndex = 0;
            lblNumProdottiSub.Text = "prodotti in catalogo";
            lblNumProdottiSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumProdotti
            // 
            lblNumProdotti.Dock = DockStyle.Fill;
            lblNumProdotti.Font = new Font("Segoe UI Semibold", 38F, FontStyle.Bold);
            lblNumProdotti.ForeColor = Color.FromArgb(90, 192, 192, 255);
            lblNumProdotti.Location = new Point(9, 3);
            lblNumProdotti.Name = "lblNumProdotti";
            lblNumProdotti.Size = new Size(318, 148);
            lblNumProdotti.TabIndex = 1;
            lblNumProdotti.Text = "0";
            lblNumProdotti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpInventario
            // 
            grpInventario.Controls.Add(pnlInvContent);
            grpInventario.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpInventario.Location = new Point(369, 5);
            grpInventario.Margin = new Padding(5);
            grpInventario.Name = "grpInventario";
            grpInventario.Padding = new Padding(9, 11, 9, 11);
            grpInventario.Size = new Size(389, 197);
            grpInventario.TabIndex = 1;
            grpInventario.TabStop = false;
            grpInventario.Text = "VALORE INVENTARIO (snapshot attuale)";
            // 
            // pnlInvContent
            // 
            pnlInvContent.Controls.Add(lblInvNetto);
            pnlInvContent.Dock = DockStyle.Fill;
            pnlInvContent.Location = new Point(9, 30);
            pnlInvContent.Margin = new Padding(3, 4, 3, 4);
            pnlInvContent.Name = "pnlInvContent";
            pnlInvContent.Padding = new Padding(9, 5, 9, 5);
            pnlInvContent.Size = new Size(371, 156);
            pnlInvContent.TabIndex = 0;
            // 
            // lblInvNetto
            // 
            lblInvNetto.Dock = DockStyle.Fill;
            lblInvNetto.Font = new Font("Segoe UI", 20F);
            lblInvNetto.ForeColor = Color.FromArgb(40, 120, 40);
            lblInvNetto.Location = new Point(9, 5);
            lblInvNetto.Name = "lblInvNetto";
            lblInvNetto.Size = new Size(353, 146);
            lblInvNetto.TabIndex = 1;
            lblInvNetto.Text = "0,00 €";
            lblInvNetto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpBilancio
            // 
            grpBilancio.Controls.Add(pnlBilancioContent);
            grpBilancio.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpBilancio.Location = new Point(768, 5);
            grpBilancio.Margin = new Padding(5);
            grpBilancio.Name = "grpBilancio";
            grpBilancio.Padding = new Padding(9, 11, 9, 11);
            grpBilancio.Size = new Size(377, 197);
            grpBilancio.TabIndex = 2;
            grpBilancio.TabStop = false;
            grpBilancio.Text = "BILANCIO PERIODO";
            // 
            // pnlBilancioContent
            // 
            pnlBilancioContent.Controls.Add(pnlUtileRow);
            pnlBilancioContent.Controls.Add(pnlSepUtile);
            pnlBilancioContent.Controls.Add(pnlUsciteRow);
            pnlBilancioContent.Controls.Add(pnlEntrateRow);
            pnlBilancioContent.Dock = DockStyle.Fill;
            pnlBilancioContent.Location = new Point(9, 30);
            pnlBilancioContent.Margin = new Padding(3, 4, 3, 4);
            pnlBilancioContent.Name = "pnlBilancioContent";
            pnlBilancioContent.Padding = new Padding(9, 3, 9, 3);
            pnlBilancioContent.Size = new Size(359, 156);
            pnlBilancioContent.TabIndex = 0;
            // 
            // pnlUtileRow
            // 
            pnlUtileRow.Controls.Add(lblUtileVal);
            pnlUtileRow.Controls.Add(lblUtile);
            pnlUtileRow.Dock = DockStyle.Top;
            pnlUtileRow.Location = new Point(9, 84);
            pnlUtileRow.Margin = new Padding(3, 4, 3, 4);
            pnlUtileRow.Name = "pnlUtileRow";
            pnlUtileRow.Size = new Size(341, 45);
            pnlUtileRow.TabIndex = 0;
            // 
            // lblUtileVal
            // 
            lblUtileVal.Dock = DockStyle.Right;
            lblUtileVal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtileVal.Location = new Point(131, 0);
            lblUtileVal.Name = "lblUtileVal";
            lblUtileVal.Size = new Size(210, 45);
            lblUtileVal.TabIndex = 0;
            lblUtileVal.Text = "0,00 €";
            lblUtileVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUtile
            // 
            lblUtile.AutoSize = true;
            lblUtile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtile.Location = new Point(0, 11);
            lblUtile.Name = "lblUtile";
            lblUtile.Size = new Size(63, 23);
            lblUtile.TabIndex = 1;
            lblUtile.Text = "SALDO";
            // 
            // pnlSepUtile
            // 
            pnlSepUtile.BackColor = Color.DarkGray;
            pnlSepUtile.Dock = DockStyle.Top;
            pnlSepUtile.Location = new Point(9, 83);
            pnlSepUtile.Margin = new Padding(3, 4, 3, 4);
            pnlSepUtile.Name = "pnlSepUtile";
            pnlSepUtile.Size = new Size(341, 1);
            pnlSepUtile.TabIndex = 1;
            // 
            // pnlUsciteRow
            // 
            pnlUsciteRow.Controls.Add(lblUsciteVal);
            pnlUsciteRow.Controls.Add(lblUscite);
            pnlUsciteRow.Dock = DockStyle.Top;
            pnlUsciteRow.Location = new Point(9, 43);
            pnlUsciteRow.Margin = new Padding(3, 4, 3, 4);
            pnlUsciteRow.Name = "pnlUsciteRow";
            pnlUsciteRow.Size = new Size(341, 40);
            pnlUsciteRow.TabIndex = 2;
            // 
            // lblUsciteVal
            // 
            lblUsciteVal.Dock = DockStyle.Right;
            lblUsciteVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsciteVal.ForeColor = Color.FromArgb(180, 60, 60);
            lblUsciteVal.Location = new Point(131, 0);
            lblUsciteVal.Name = "lblUsciteVal";
            lblUsciteVal.Size = new Size(210, 40);
            lblUsciteVal.TabIndex = 0;
            lblUsciteVal.Text = "0,00 €";
            lblUsciteVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUscite
            // 
            lblUscite.AutoSize = true;
            lblUscite.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUscite.ForeColor = Color.FromArgb(180, 60, 60);
            lblUscite.Location = new Point(0, 9);
            lblUscite.Name = "lblUscite";
            lblUscite.Size = new Size(57, 20);
            lblUscite.TabIndex = 1;
            lblUscite.Text = "USCITE";
            // 
            // pnlEntrateRow
            // 
            pnlEntrateRow.Controls.Add(lblEntrateVal);
            pnlEntrateRow.Controls.Add(lblEntrate);
            pnlEntrateRow.Dock = DockStyle.Top;
            pnlEntrateRow.Location = new Point(9, 3);
            pnlEntrateRow.Margin = new Padding(3, 4, 3, 4);
            pnlEntrateRow.Name = "pnlEntrateRow";
            pnlEntrateRow.Size = new Size(341, 40);
            pnlEntrateRow.TabIndex = 3;
            // 
            // lblEntrateVal
            // 
            lblEntrateVal.Dock = DockStyle.Right;
            lblEntrateVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEntrateVal.ForeColor = Color.FromArgb(40, 130, 40);
            lblEntrateVal.Location = new Point(131, 0);
            lblEntrateVal.Name = "lblEntrateVal";
            lblEntrateVal.Size = new Size(210, 40);
            lblEntrateVal.TabIndex = 0;
            lblEntrateVal.Text = "0,00 €";
            lblEntrateVal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEntrate
            // 
            lblEntrate.AutoSize = true;
            lblEntrate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEntrate.ForeColor = Color.FromArgb(40, 130, 40);
            lblEntrate.Location = new Point(0, 9);
            lblEntrate.Name = "lblEntrate";
            lblEntrate.Size = new Size(71, 20);
            lblEntrate.TabIndex = 1;
            lblEntrate.Text = "ENTRATE";
            // 
            // tabGrafici
            // 
            tabGrafici.BackColor = SystemColors.Control;
            tabGrafici.Controls.Add(pnlGrafici);
            tabGrafici.Location = new Point(4, 31);
            tabGrafici.Margin = new Padding(3, 4, 3, 4);
            tabGrafici.Name = "tabGrafici";
            tabGrafici.Size = new Size(1158, 620);
            tabGrafici.TabIndex = 1;
            tabGrafici.Text = "  GRAFICI  ";
            // 
            // pnlGrafici
            // 
            pnlGrafici.AutoScroll = true;
            pnlGrafici.Controls.Add(grpGrClienti);
            pnlGrafici.Controls.Add(pnlGrSpacerC);
            pnlGrafici.Controls.Add(grpGrProdotti);
            pnlGrafici.Controls.Add(pnlGrSpacerP);
            pnlGrafici.Controls.Add(grpGrBilancio);
            pnlGrafici.Dock = DockStyle.Fill;
            pnlGrafici.Location = new Point(0, 0);
            pnlGrafici.Margin = new Padding(3, 4, 3, 4);
            pnlGrafici.Name = "pnlGrafici";
            pnlGrafici.Padding = new Padding(11);
            pnlGrafici.Size = new Size(1158, 620);
            pnlGrafici.TabIndex = 0;
            // 
            // grpGrClienti
            // 
            grpGrClienti.Controls.Add(pnlGrClientiToggle);
            grpGrClienti.Dock = DockStyle.Top;
            grpGrClienti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrClienti.Location = new Point(11, 810);
            grpGrClienti.Margin = new Padding(3, 4, 3, 4);
            grpGrClienti.Name = "grpGrClienti";
            grpGrClienti.Padding = new Padding(9, 8, 9, 11);
            grpGrClienti.Size = new Size(1115, 413);
            grpGrClienti.TabIndex = 0;
            grpGrClienti.TabStop = false;
            grpGrClienti.Text = "CLIENTI PIÙ FREQUENTI";
            // 
            // pnlGrClientiToggle
            // 
            pnlGrClientiToggle.Controls.Add(btnGrClientiBarre);
            pnlGrClientiToggle.Controls.Add(btnGrClientiTorta);
            pnlGrClientiToggle.Dock = DockStyle.Top;
            pnlGrClientiToggle.Location = new Point(9, 27);
            pnlGrClientiToggle.Margin = new Padding(3, 4, 3, 4);
            pnlGrClientiToggle.Name = "pnlGrClientiToggle";
            pnlGrClientiToggle.Padding = new Padding(0, 5, 0, 0);
            pnlGrClientiToggle.Size = new Size(1097, 45);
            pnlGrClientiToggle.TabIndex = 0;
            // 
            // btnGrClientiBarre
            // 
            btnGrClientiBarre.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnGrClientiBarre.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrClientiBarre.FlatStyle = FlatStyle.Flat;
            btnGrClientiBarre.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrClientiBarre.ForeColor = Color.White;
            btnGrClientiBarre.Location = new Point(0, 0);
            btnGrClientiBarre.Margin = new Padding(0, 0, 7, 0);
            btnGrClientiBarre.Name = "btnGrClientiBarre";
            btnGrClientiBarre.Size = new Size(103, 35);
            btnGrClientiBarre.TabIndex = 0;
            btnGrClientiBarre.Text = "■  BARRE";
            btnGrClientiBarre.UseVisualStyleBackColor = false;
            btnGrClientiBarre.Click += btnGrClientiBarre_Click;
            // 
            // btnGrClientiTorta
            // 
            btnGrClientiTorta.BackColor = Color.White;
            btnGrClientiTorta.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrClientiTorta.FlatStyle = FlatStyle.Flat;
            btnGrClientiTorta.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrClientiTorta.ForeColor = Color.Black;
            btnGrClientiTorta.Location = new Point(0, 0);
            btnGrClientiTorta.Margin = new Padding(0, 0, 7, 0);
            btnGrClientiTorta.Name = "btnGrClientiTorta";
            btnGrClientiTorta.Size = new Size(103, 35);
            btnGrClientiTorta.TabIndex = 1;
            btnGrClientiTorta.Text = "◎  TORTA";
            btnGrClientiTorta.UseVisualStyleBackColor = false;
            btnGrClientiTorta.Click += btnGrClientiTorta_Click;
            // 
            // pnlGrSpacerC
            // 
            pnlGrSpacerC.Dock = DockStyle.Top;
            pnlGrSpacerC.Location = new Point(11, 797);
            pnlGrSpacerC.Margin = new Padding(3, 4, 3, 4);
            pnlGrSpacerC.Name = "pnlGrSpacerC";
            pnlGrSpacerC.Size = new Size(1115, 13);
            pnlGrSpacerC.TabIndex = 1;
            // 
            // grpGrProdotti
            // 
            grpGrProdotti.Controls.Add(pnlGrProdottiToggle);
            grpGrProdotti.Dock = DockStyle.Top;
            grpGrProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrProdotti.Location = new Point(11, 384);
            grpGrProdotti.Margin = new Padding(3, 4, 3, 4);
            grpGrProdotti.Name = "grpGrProdotti";
            grpGrProdotti.Padding = new Padding(9, 8, 9, 11);
            grpGrProdotti.Size = new Size(1115, 413);
            grpGrProdotti.TabIndex = 2;
            grpGrProdotti.TabStop = false;
            grpGrProdotti.Text = "PRODOTTI PIÙ VENDUTI";
            // 
            // pnlGrProdottiToggle
            // 
            pnlGrProdottiToggle.Controls.Add(btnGrProdottiBarre);
            pnlGrProdottiToggle.Controls.Add(btnGrProdottiTorta);
            pnlGrProdottiToggle.Dock = DockStyle.Top;
            pnlGrProdottiToggle.Location = new Point(9, 27);
            pnlGrProdottiToggle.Margin = new Padding(3, 4, 3, 4);
            pnlGrProdottiToggle.Name = "pnlGrProdottiToggle";
            pnlGrProdottiToggle.Padding = new Padding(0, 5, 0, 0);
            pnlGrProdottiToggle.Size = new Size(1097, 45);
            pnlGrProdottiToggle.TabIndex = 0;
            // 
            // btnGrProdottiBarre
            // 
            btnGrProdottiBarre.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnGrProdottiBarre.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrProdottiBarre.FlatStyle = FlatStyle.Flat;
            btnGrProdottiBarre.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrProdottiBarre.ForeColor = Color.White;
            btnGrProdottiBarre.Location = new Point(0, 0);
            btnGrProdottiBarre.Margin = new Padding(0, 0, 7, 0);
            btnGrProdottiBarre.Name = "btnGrProdottiBarre";
            btnGrProdottiBarre.Size = new Size(103, 35);
            btnGrProdottiBarre.TabIndex = 0;
            btnGrProdottiBarre.Text = "■  BARRE";
            btnGrProdottiBarre.UseVisualStyleBackColor = false;
            btnGrProdottiBarre.Click += btnGrProdottiBarre_Click;
            // 
            // btnGrProdottiTorta
            // 
            btnGrProdottiTorta.BackColor = Color.White;
            btnGrProdottiTorta.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 200);
            btnGrProdottiTorta.FlatStyle = FlatStyle.Flat;
            btnGrProdottiTorta.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnGrProdottiTorta.ForeColor = Color.Black;
            btnGrProdottiTorta.Location = new Point(0, 0);
            btnGrProdottiTorta.Margin = new Padding(0, 0, 7, 0);
            btnGrProdottiTorta.Name = "btnGrProdottiTorta";
            btnGrProdottiTorta.Size = new Size(103, 35);
            btnGrProdottiTorta.TabIndex = 1;
            btnGrProdottiTorta.Text = "◎  TORTA";
            btnGrProdottiTorta.UseVisualStyleBackColor = false;
            btnGrProdottiTorta.Click += btnGrProdottiTorta_Click;
            // 
            // pnlGrSpacerP
            // 
            pnlGrSpacerP.Dock = DockStyle.Top;
            pnlGrSpacerP.Location = new Point(11, 371);
            pnlGrSpacerP.Margin = new Padding(3, 4, 3, 4);
            pnlGrSpacerP.Name = "pnlGrSpacerP";
            pnlGrSpacerP.Size = new Size(1115, 13);
            pnlGrSpacerP.TabIndex = 3;
            // 
            // grpGrBilancio
            // 
            grpGrBilancio.Controls.Add(pnlGrBilancioToggle);
            grpGrBilancio.Dock = DockStyle.Top;
            grpGrBilancio.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpGrBilancio.Location = new Point(11, 11);
            grpGrBilancio.Margin = new Padding(3, 4, 3, 4);
            grpGrBilancio.Name = "grpGrBilancio";
            grpGrBilancio.Padding = new Padding(9, 8, 9, 11);
            grpGrBilancio.Size = new Size(1115, 360);
            grpGrBilancio.TabIndex = 4;
            grpGrBilancio.TabStop = false;
            grpGrBilancio.Text = "BILANCIO ENTRATE / USCITE";
            // 
            // pnlGrBilancioToggle
            // 
            pnlGrBilancioToggle.Dock = DockStyle.Top;
            pnlGrBilancioToggle.Location = new Point(9, 27);
            pnlGrBilancioToggle.Margin = new Padding(3, 4, 3, 4);
            pnlGrBilancioToggle.Name = "pnlGrBilancioToggle";
            pnlGrBilancioToggle.Size = new Size(1097, 0);
            pnlGrBilancioToggle.TabIndex = 0;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 853);
            Controls.Add(tabControl);
            Controls.Add(pnlSepFiltri);
            Controls.Add(pnlFiltri);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1184, 900);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistiche";
            WindowState = FormWindowState.Maximized;
            Load += StatsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltri.ResumeLayout(false);
            pnlFiltri.PerformLayout();
            tabControl.ResumeLayout(false);
            tabDati.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpTopClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopClienti).EndInit();
            grpTopProdotti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopProdotti).EndInit();
            pnlCards.ResumeLayout(false);
            grpProdotti.ResumeLayout(false);
            pnlProdContent.ResumeLayout(false);
            grpInventario.ResumeLayout(false);
            pnlInvContent.ResumeLayout(false);
            grpBilancio.ResumeLayout(false);
            pnlBilancioContent.ResumeLayout(false);
            pnlUtileRow.ResumeLayout(false);
            pnlUtileRow.PerformLayout();
            pnlUsciteRow.ResumeLayout(false);
            pnlUsciteRow.PerformLayout();
            pnlEntrateRow.ResumeLayout(false);
            pnlEntrateRow.PerformLayout();
            tabGrafici.ResumeLayout(false);
            pnlGrafici.ResumeLayout(false);
            grpGrClienti.ResumeLayout(false);
            pnlGrClientiToggle.ResumeLayout(false);
            grpGrProdotti.ResumeLayout(false);
            pnlGrProdottiToggle.ResumeLayout(false);
            grpGrBilancio.ResumeLayout(false);
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
