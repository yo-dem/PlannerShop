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

            pnlAccent.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlFiltri.SuspendLayout();
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
            SuspendLayout();

            // pnlAccent
            pnlAccent.BackColor = Color.FromArgb(192, 192, 255);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(1020, 8);
            pnlAccent.TabIndex = 0;

            // pnlHeader
            pnlHeader.BackColor = Color.White;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 8);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(14, 10, 14, 0);
            pnlHeader.Size = new Size(1020, 52);
            pnlHeader.TabIndex = 1;
            pnlHeader.Controls.Add(lblTitolo);

            // lblTitolo
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitolo.ForeColor = Color.FromArgb(90, 192, 192, 255);
            lblTitolo.Location = new Point(14, 10);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "STATISTICHE";

            // pnlFiltri
            pnlFiltri.BackColor = Color.White;
            pnlFiltri.Dock = DockStyle.Top;
            pnlFiltri.Location = new Point(0, 60);
            pnlFiltri.Name = "pnlFiltri";
            pnlFiltri.Size = new Size(1020, 88);
            pnlFiltri.TabIndex = 2;

            // lblPeriodo
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPeriodo.Location = new Point(14, 14);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.TabIndex = 0;
            lblPeriodo.Text = "PERIODO:";

            // rdbDaSempre
            rdbDaSempre.AutoSize = true;
            rdbDaSempre.Font = new Font("Segoe UI", 9F);
            rdbDaSempre.Location = new Point(98, 12);
            rdbDaSempre.Name = "rdbDaSempre";
            rdbDaSempre.Size = new Size(85, 19);
            rdbDaSempre.TabIndex = 1;
            rdbDaSempre.Text = "Da sempre";
            rdbDaSempre.UseVisualStyleBackColor = true;

            // rdbUltimoAnno
            rdbUltimoAnno.AutoSize = true;
            rdbUltimoAnno.Font = new Font("Segoe UI", 9F);
            rdbUltimoAnno.Location = new Point(200, 12);
            rdbUltimoAnno.Name = "rdbUltimoAnno";
            rdbUltimoAnno.Size = new Size(90, 19);
            rdbUltimoAnno.TabIndex = 2;
            rdbUltimoAnno.Text = "Ultimo anno";
            rdbUltimoAnno.UseVisualStyleBackColor = true;

            // rdbUltimaSettimana
            rdbUltimaSettimana.AutoSize = true;
            rdbUltimaSettimana.Font = new Font("Segoe UI", 9F);
            rdbUltimaSettimana.Location = new Point(310, 12);
            rdbUltimaSettimana.Name = "rdbUltimaSettimana";
            rdbUltimaSettimana.Size = new Size(111, 19);
            rdbUltimaSettimana.TabIndex = 3;
            rdbUltimaSettimana.Text = "Ultima settimana";
            rdbUltimaSettimana.UseVisualStyleBackColor = true;

            // rdbPersonalizzato
            rdbPersonalizzato.AutoSize = true;
            rdbPersonalizzato.Font = new Font("Segoe UI", 9F);
            rdbPersonalizzato.Location = new Point(440, 12);
            rdbPersonalizzato.Name = "rdbPersonalizzato";
            rdbPersonalizzato.Size = new Size(105, 19);
            rdbPersonalizzato.TabIndex = 4;
            rdbPersonalizzato.Text = "Personalizzato";
            rdbPersonalizzato.UseVisualStyleBackColor = true;
            rdbPersonalizzato.CheckedChanged += rdbPersonalizzato_CheckedChanged;

            // lblDa
            lblDa.AutoSize = true;
            lblDa.Font = new Font("Segoe UI", 9F);
            lblDa.Location = new Point(98, 48);
            lblDa.Name = "lblDa";
            lblDa.TabIndex = 5;
            lblDa.Text = "Da:";
            lblDa.Visible = false;

            // dtpDa
            dtpDa.Format = DateTimePickerFormat.Short;
            dtpDa.Location = new Point(118, 44);
            dtpDa.Name = "dtpDa";
            dtpDa.Size = new Size(140, 23);
            dtpDa.TabIndex = 6;
            dtpDa.Visible = false;

            // lblA
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 9F);
            lblA.Location = new Point(274, 48);
            lblA.Name = "lblA";
            lblA.TabIndex = 7;
            lblA.Text = "A:";
            lblA.Visible = false;

            // dtpA
            dtpA.Format = DateTimePickerFormat.Short;
            dtpA.Location = new Point(294, 44);
            dtpA.Name = "dtpA";
            dtpA.Size = new Size(140, 23);
            dtpA.TabIndex = 8;
            dtpA.Visible = false;

            // btnAggiorna
            btnAggiorna.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggiorna.BackColor = Color.FromArgb(90, 192, 192, 255);
            btnAggiorna.FlatAppearance.BorderSize = 0;
            btnAggiorna.FlatStyle = FlatStyle.Flat;
            btnAggiorna.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAggiorna.Location = new Point(870, 28);
            btnAggiorna.Name = "btnAggiorna";
            btnAggiorna.Size = new Size(130, 30);
            btnAggiorna.TabIndex = 9;
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

            // pnlSepFiltri
            pnlSepFiltri.BackColor = Color.DarkGray;
            pnlSepFiltri.Dock = DockStyle.Top;
            pnlSepFiltri.Location = new Point(0, 148);
            pnlSepFiltri.Name = "pnlSepFiltri";
            pnlSepFiltri.Size = new Size(1020, 1);
            pnlSepFiltri.TabIndex = 3;

            // ---- CARDS ----

            // grpProdotti
            grpProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpProdotti.Location = new Point(4, 4);
            grpProdotti.Margin = new Padding(4);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Padding = new Padding(8);
            grpProdotti.Size = new Size(310, 148);
            grpProdotti.TabIndex = 0;
            grpProdotti.TabStop = false;
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
            lblNumProdotti.TabIndex = 0;
            lblNumProdotti.Text = "0";
            lblNumProdotti.TextAlign = ContentAlignment.MiddleCenter;

            lblNumProdottiSub.AutoSize = false;
            lblNumProdottiSub.Dock = DockStyle.Bottom;
            lblNumProdottiSub.Font = new Font("Segoe UI", 8.5F);
            lblNumProdottiSub.ForeColor = Color.Gray;
            lblNumProdottiSub.Height = 20;
            lblNumProdottiSub.Name = "lblNumProdottiSub";
            lblNumProdottiSub.TabIndex = 1;
            lblNumProdottiSub.Text = "prodotti in catalogo";
            lblNumProdottiSub.TextAlign = ContentAlignment.MiddleCenter;

            // grpInventario
            grpInventario.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpInventario.Location = new Point(322, 4);
            grpInventario.Margin = new Padding(4);
            grpInventario.Name = "grpInventario";
            grpInventario.Padding = new Padding(8);
            grpInventario.Size = new Size(340, 148);
            grpInventario.TabIndex = 1;
            grpInventario.TabStop = false;
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
            lblInvNetto.TabIndex = 0;
            lblInvNetto.Text = "Netto: 0,00 €";
            lblInvNetto.TextAlign = ContentAlignment.MiddleLeft;

            lblInvIvato.AutoSize = false;
            lblInvIvato.Dock = DockStyle.Top;
            lblInvIvato.Font = new Font("Segoe UI", 14F);
            lblInvIvato.ForeColor = Color.FromArgb(70, 70, 70);
            lblInvIvato.Height = 40;
            lblInvIvato.Name = "lblInvIvato";
            lblInvIvato.TabIndex = 1;
            lblInvIvato.Text = "IVA incl.: 0,00 €";
            lblInvIvato.TextAlign = ContentAlignment.MiddleLeft;

            // grpBilancio
            grpBilancio.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpBilancio.Location = new Point(670, 4);
            grpBilancio.Margin = new Padding(4);
            grpBilancio.Name = "grpBilancio";
            grpBilancio.Padding = new Padding(8);
            grpBilancio.Size = new Size(330, 148);
            grpBilancio.TabIndex = 2;
            grpBilancio.TabStop = false;
            grpBilancio.Text = "BILANCIO PERIODO";
            grpBilancio.Controls.Add(pnlBilancioContent);

            pnlBilancioContent.Dock = DockStyle.Fill;
            pnlBilancioContent.Name = "pnlBilancioContent";
            pnlBilancioContent.Padding = new Padding(8, 2, 8, 2);
            pnlBilancioContent.Controls.Add(pnlUtileRow);
            pnlBilancioContent.Controls.Add(pnlSepUtile);
            pnlBilancioContent.Controls.Add(pnlUsciteRow);
            pnlBilancioContent.Controls.Add(pnlEntrateRow);

            // Entrate row
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
            lblEntrate.TabIndex = 0;
            lblEntrate.Text = "ENTRATE";

            lblEntrateVal.AutoSize = true;
            lblEntrateVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEntrateVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEntrateVal.ForeColor = Color.FromArgb(40, 130, 40);
            lblEntrateVal.Location = new Point(190, 7);
            lblEntrateVal.Name = "lblEntrateVal";
            lblEntrateVal.TabIndex = 1;
            lblEntrateVal.Text = "0,00 €";

            // Uscite row
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
            lblUscite.TabIndex = 0;
            lblUscite.Text = "USCITE";

            lblUsciteVal.AutoSize = true;
            lblUsciteVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsciteVal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsciteVal.ForeColor = Color.FromArgb(180, 60, 60);
            lblUsciteVal.Location = new Point(190, 7);
            lblUsciteVal.Name = "lblUsciteVal";
            lblUsciteVal.TabIndex = 1;
            lblUsciteVal.Text = "0,00 €";

            // Separatore utile
            pnlSepUtile.BackColor = Color.DarkGray;
            pnlSepUtile.Dock = DockStyle.Top;
            pnlSepUtile.Height = 1;
            pnlSepUtile.Margin = new Padding(0, 2, 0, 2);
            pnlSepUtile.Name = "pnlSepUtile";

            // Utile row
            pnlUtileRow.Dock = DockStyle.Top;
            pnlUtileRow.Height = 34;
            pnlUtileRow.Name = "pnlUtileRow";
            pnlUtileRow.Controls.Add(lblUtileVal);
            pnlUtileRow.Controls.Add(lblUtile);

            lblUtile.AutoSize = true;
            lblUtile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtile.Location = new Point(0, 8);
            lblUtile.Name = "lblUtile";
            lblUtile.TabIndex = 0;
            lblUtile.Text = "SALDO";

            lblUtileVal.AutoSize = true;
            lblUtileVal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUtileVal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUtileVal.Location = new Point(190, 8);
            lblUtileVal.Name = "lblUtileVal";
            lblUtileVal.TabIndex = 1;
            lblUtileVal.Text = "0,00 €";

            // pnlCards (FlowLayoutPanel)
            pnlCards.AutoSize = false;
            pnlCards.Dock = DockStyle.Top;
            pnlCards.FlowDirection = FlowDirection.LeftToRight;
            pnlCards.Height = 158;
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(0);
            pnlCards.WrapContents = false;
            pnlCards.Controls.Add(grpProdotti);
            pnlCards.Controls.Add(grpInventario);
            pnlCards.Controls.Add(grpBilancio);

            // pnlSpacerMid
            pnlSpacerMid.Dock = DockStyle.Top;
            pnlSpacerMid.Height = 10;
            pnlSpacerMid.Name = "pnlSpacerMid";

            // grpTopProdotti
            grpTopProdotti.Dock = DockStyle.Top;
            grpTopProdotti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopProdotti.Height = 232;
            grpTopProdotti.Name = "grpTopProdotti";
            grpTopProdotti.Padding = new Padding(6, 4, 6, 6);
            grpTopProdotti.TabIndex = 1;
            grpTopProdotti.TabStop = false;
            grpTopProdotti.Text = "CLASSIFICA PRODOTTI PIÙ VENDUTI (TOP 10)";
            grpTopProdotti.Controls.Add(dgvTopProdotti);

            dgvTopProdotti.Dock = DockStyle.Fill;
            dgvTopProdotti.Name = "dgvTopProdotti";
            dgvTopProdotti.TabIndex = 0;

            // pnlSpacerBottom
            pnlSpacerBottom.Dock = DockStyle.Top;
            pnlSpacerBottom.Height = 10;
            pnlSpacerBottom.Name = "pnlSpacerBottom";

            // grpTopClienti
            grpTopClienti.Dock = DockStyle.Top;
            grpTopClienti.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            grpTopClienti.Height = 232;
            grpTopClienti.Name = "grpTopClienti";
            grpTopClienti.Padding = new Padding(6, 4, 6, 6);
            grpTopClienti.TabIndex = 2;
            grpTopClienti.TabStop = false;
            grpTopClienti.Text = "CLASSIFICA CLIENTI PIÙ FREQUENTI (TOP 10)";
            grpTopClienti.Controls.Add(dgvTopClienti);

            dgvTopClienti.Dock = DockStyle.Fill;
            dgvTopClienti.Name = "dgvTopClienti";
            dgvTopClienti.TabIndex = 0;

            // pnlBody – aggiungo i figli in ordine INVERSO per il Dock=Top
            pnlBody.AutoScroll = true;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(10, 8, 10, 8);
            pnlBody.TabIndex = 4;

            // L'ordine di Controls.Add con Dock=Top: l'ULTIMO aggiunto sta IN CIMA
            pnlBody.Controls.Add(grpTopClienti);
            pnlBody.Controls.Add(pnlSpacerBottom);
            pnlBody.Controls.Add(grpTopProdotti);
            pnlBody.Controls.Add(pnlSpacerMid);
            pnlBody.Controls.Add(pnlCards);

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 790);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(900, 680);
            Name = "StatsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistiche";
            Load += StatsForm_Load;

            Controls.Add(pnlBody);
            Controls.Add(pnlSepFiltri);
            Controls.Add(pnlFiltri);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAccent);

            pnlAccent.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFiltri.ResumeLayout(false);
            pnlFiltri.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

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
    }
}
