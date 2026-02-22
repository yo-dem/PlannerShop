namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    partial class AppointmentInsertForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitolo = new Label(); txtTitolo = new TextBox();
            lblCliente = new Label(); txtCliente = new TextBox();
            lblOperatore = new Label(); txtOperatore = new TextBox();
            lblServizio = new Label(); txtServizio = new TextBox();
            lblData = new Label(); dtpData = new DateTimePicker();
            lblOraInizio = new Label(); dtpOraInizio = new DateTimePicker();
            lblOraFine = new Label(); dtpOraFine = new DateTimePicker();
            lblStato = new Label(); cmbStato = new ComboBox();
            lblColore = new Label(); pnlColore = new Panel();
            btnColor1 = new Button(); btnColor2 = new Button();
            btnColor3 = new Button(); btnColor4 = new Button();
            lblNote = new Label(); txtNote = new TextBox();
            btnOk = new Button(); btnAnnulla = new Button();
            grpDatiBase = new GroupBox(); grpOrari = new GroupBox();
            grpAltro = new GroupBox();

            grpDatiBase.SuspendLayout(); grpOrari.SuspendLayout(); grpAltro.SuspendLayout();
            SuspendLayout();

            // ── grpDatiBase ─────────────────────────────────────────
            grpDatiBase.Text = "DATI APPUNTAMENTO";
            grpDatiBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatiBase.Location = new Point(12, 12); grpDatiBase.Size = new Size(510, 220); grpDatiBase.TabIndex = 0;

            lblCliente.AutoSize = true; lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.Location = new Point(12, 28); lblCliente.Text = "CLIENTE*";

            txtCliente.Location = new Point(12, 46); txtCliente.Size = new Size(230, 23); txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;

            lblOperatore.AutoSize = true; lblOperatore.Font = new Font("Segoe UI", 9F);
            lblOperatore.Location = new Point(258, 28); lblOperatore.Text = "OPERATORE";

            txtOperatore.Location = new Point(258, 46); txtOperatore.Size = new Size(235, 23); txtOperatore.TabIndex = 2;

            lblServizio.AutoSize = true; lblServizio.Font = new Font("Segoe UI", 9F);
            lblServizio.Location = new Point(12, 76); lblServizio.Text = "SERVIZIO / TRATTAMENTO";

            txtServizio.Location = new Point(12, 94); txtServizio.Size = new Size(480, 23); txtServizio.TabIndex = 3;

            lblTitolo.AutoSize = true; lblTitolo.Font = new Font("Segoe UI", 9F);
            lblTitolo.Location = new Point(12, 124); lblTitolo.Text = "TITOLO APPUNTAMENTO*";

            txtTitolo.Location = new Point(12, 142); txtTitolo.Size = new Size(480, 23); txtTitolo.TabIndex = 4;
            txtTitolo.TextChanged += txtTitolo_TextChanged2;

            lblStato.AutoSize = true; lblStato.Font = new Font("Segoe UI", 9F);
            lblStato.Location = new Point(12, 172); lblStato.Text = "STATO";

            cmbStato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStato.Location = new Point(12, 190); cmbStato.Size = new Size(200, 23); cmbStato.TabIndex = 5;

            grpDatiBase.Controls.AddRange(new Control[] {
                lblCliente, txtCliente, lblOperatore, txtOperatore,
                lblServizio, txtServizio, lblTitolo, txtTitolo, lblStato, cmbStato });

            // ── grpOrari ────────────────────────────────────────────
            grpOrari.Text = "DATA E ORARI"; grpOrari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOrari.Location = new Point(12, 242); grpOrari.Size = new Size(510, 100); grpOrari.TabIndex = 1;

            lblData.AutoSize = true; lblData.Font = new Font("Segoe UI", 9F);
            lblData.Location = new Point(12, 24); lblData.Text = "DATA";
            dtpData.Format = DateTimePickerFormat.Short; dtpData.Location = new Point(12, 42);
            dtpData.Size = new Size(150, 23); dtpData.TabIndex = 6;

            lblOraInizio.AutoSize = true; lblOraInizio.Font = new Font("Segoe UI", 9F);
            lblOraInizio.Location = new Point(175, 24); lblOraInizio.Text = "ORA INIZIO";
            dtpOraInizio.Format = DateTimePickerFormat.Time; dtpOraInizio.ShowUpDown = true;
            dtpOraInizio.Location = new Point(175, 42); dtpOraInizio.Size = new Size(100, 23); dtpOraInizio.TabIndex = 7;

            lblOraFine.AutoSize = true; lblOraFine.Font = new Font("Segoe UI", 9F);
            lblOraFine.Location = new Point(290, 24); lblOraFine.Text = "ORA FINE";
            dtpOraFine.Format = DateTimePickerFormat.Time; dtpOraFine.ShowUpDown = true;
            dtpOraFine.Location = new Point(290, 42); dtpOraFine.Size = new Size(100, 23); dtpOraFine.TabIndex = 8;
            dtpOraFine.ValueChanged += dtpOraFine_ValueChanged;

            grpOrari.Controls.AddRange(new Control[] { lblData, dtpData, lblOraInizio, dtpOraInizio, lblOraFine, dtpOraFine });

            // ── grpAltro ────────────────────────────────────────────
            grpAltro.Text = "COLORE E NOTE"; grpAltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAltro.Location = new Point(12, 352); grpAltro.Size = new Size(510, 170); grpAltro.TabIndex = 2;

            lblColore.AutoSize = true; lblColore.Font = new Font("Segoe UI", 9F);
            lblColore.Location = new Point(12, 24); lblColore.Text = "COLORE";

            // Pannello indicatore colore selezionato (piccolo quadratino)
            pnlColore.Location = new Point(12, 44); pnlColore.Size = new Size(18, 18);
            pnlColore.BorderStyle = BorderStyle.None;

            // 4 pulsanti colore affiancati
            int btnY = 42; int btnH = 26; int btnW = 54; int btnSpacing = 6;
            int startX = 36;

            btnColor1.Location = new Point(startX + 0 * (btnW + btnSpacing), btnY);
            btnColor1.Size = new Size(btnW, btnH); btnColor1.TabStop = false;
            btnColor1.BackColor = AppointmentInsertForm.Palette[0]; btnColor1.FlatStyle = FlatStyle.Flat;
            btnColor1.FlatAppearance.BorderSize = 1; btnColor1.Text = "";

            btnColor2.Location = new Point(startX + 1 * (btnW + btnSpacing), btnY);
            btnColor2.Size = new Size(btnW, btnH); btnColor2.TabStop = false;
            btnColor2.BackColor = AppointmentInsertForm.Palette[1]; btnColor2.FlatStyle = FlatStyle.Flat;
            btnColor2.FlatAppearance.BorderSize = 1; btnColor2.Text = "";

            btnColor3.Location = new Point(startX + 2 * (btnW + btnSpacing), btnY);
            btnColor3.Size = new Size(btnW, btnH); btnColor3.TabStop = false;
            btnColor3.BackColor = AppointmentInsertForm.Palette[2]; btnColor3.FlatStyle = FlatStyle.Flat;
            btnColor3.FlatAppearance.BorderSize = 1; btnColor3.Text = "";

            btnColor4.Location = new Point(startX + 3 * (btnW + btnSpacing), btnY);
            btnColor4.Size = new Size(btnW, btnH); btnColor4.TabStop = false;
            btnColor4.BackColor = AppointmentInsertForm.Palette[3]; btnColor4.FlatStyle = FlatStyle.Flat;
            btnColor4.FlatAppearance.BorderSize = 1; btnColor4.Text = "";

            lblNote.AutoSize = true; lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.Location = new Point(12, 78); lblNote.Text = "NOTE";

            txtNote.Location = new Point(12, 96); txtNote.Multiline = true;
            txtNote.ScrollBars = ScrollBars.Vertical; txtNote.Size = new Size(480, 60); txtNote.TabIndex = 10;
            txtNote.Enter += txtNote_Enter; txtNote.Leave += txtNote_Leave;

            grpAltro.Controls.AddRange(new Control[] {
                lblColore, pnlColore, btnColor1, btnColor2, btnColor3, btnColor4,
                lblNote, txtNote });

            // ── Bottoni ──────────────────────────────────────────────
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Location = new Point(12, 534); btnOk.Size = new Size(415, 45); btnOk.TabIndex = 11;
            btnOk.Text = "SALVA APPUNTAMENTO"; btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;

            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.ForeColor = Color.Red;
            btnAnnulla.Location = new Point(433, 534); btnAnnulla.Size = new Size(89, 45); btnAnnulla.TabIndex = 12;
            btnAnnulla.Text = "ANNULLA"; btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;

            // ── Form ─────────────────────────────────────────────────
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 591); FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            Name = "AppointmentInsertForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "NUOVO APPUNTAMENTO";

            Controls.AddRange(new Control[] { grpDatiBase, grpOrari, grpAltro, btnOk, btnAnnulla });

            grpDatiBase.ResumeLayout(false); grpDatiBase.PerformLayout();
            grpOrari.ResumeLayout(false); grpOrari.PerformLayout();
            grpAltro.ResumeLayout(false); grpAltro.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox grpDatiBase, grpOrari, grpAltro;
        private Label lblTitolo, lblCliente, lblOperatore, lblServizio, lblStato;
        private TextBox txtTitolo, txtCliente, txtOperatore, txtServizio;
        private ComboBox cmbStato;
        private Label lblData, lblOraInizio, lblOraFine;
        private DateTimePicker dtpData, dtpOraInizio, dtpOraFine;
        private Label lblColore, lblNote;
        private Panel pnlColore;
        private Button btnColor1, btnColor2, btnColor3, btnColor4;
        private TextBox txtNote;
        private Button btnOk, btnAnnulla;
    }
}