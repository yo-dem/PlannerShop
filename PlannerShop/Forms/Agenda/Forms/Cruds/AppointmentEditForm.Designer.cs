namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    partial class AppointmentEditForm
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
            lblTitolo    = new Label();
            txtTitolo    = new TextBox();
            lblCliente   = new Label();
            txtCliente   = new TextBox();
            lblOperatore = new Label();
            txtOperatore = new TextBox();
            lblServizio  = new Label();
            txtServizio  = new TextBox();
            lblData      = new Label();
            dtpData      = new DateTimePicker();
            lblOraInizio = new Label();
            dtpOraInizio = new DateTimePicker();
            lblOraFine   = new Label();
            dtpOraFine   = new DateTimePicker();
            lblStato     = new Label();
            cmbStato     = new ComboBox();
            lblColore    = new Label();
            pnlColore    = new Panel();
            btnColore    = new Button();
            lblNote      = new Label();
            txtNote      = new TextBox();
            btnOk        = new Button();
            btnDelete    = new Button();
            btnAnnulla   = new Button();
            grpDatiBase  = new GroupBox();
            grpOrari     = new GroupBox();
            grpAltro     = new GroupBox();

            grpDatiBase.SuspendLayout();
            grpOrari.SuspendLayout();
            grpAltro.SuspendLayout();
            SuspendLayout();

            // ── grpDatiBase ─────────────────────────────────────────
            grpDatiBase.Text     = "DATI APPUNTAMENTO";
            grpDatiBase.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatiBase.Location = new Point(12, 12);
            grpDatiBase.Size     = new Size(510, 220);
            grpDatiBase.TabIndex = 0;

            lblCliente.AutoSize = true;
            lblCliente.Font     = new Font("Segoe UI", 9F);
            lblCliente.Location = new Point(12, 28);
            lblCliente.Text     = "CLIENTE*";

            txtCliente.Location    = new Point(12, 46);
            txtCliente.Size        = new Size(230, 23);
            txtCliente.TabIndex    = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;

            lblOperatore.AutoSize = true;
            lblOperatore.Font     = new Font("Segoe UI", 9F);
            lblOperatore.Location = new Point(258, 28);
            lblOperatore.Text     = "OPERATORE";

            txtOperatore.Location = new Point(258, 46);
            txtOperatore.Size     = new Size(235, 23);
            txtOperatore.TabIndex = 2;

            lblServizio.AutoSize = true;
            lblServizio.Font     = new Font("Segoe UI", 9F);
            lblServizio.Location = new Point(12, 76);
            lblServizio.Text     = "SERVIZIO / TRATTAMENTO";

            txtServizio.Location = new Point(12, 94);
            txtServizio.Size     = new Size(480, 23);
            txtServizio.TabIndex = 3;

            lblTitolo.AutoSize = true;
            lblTitolo.Font     = new Font("Segoe UI", 9F);
            lblTitolo.Location = new Point(12, 124);
            lblTitolo.Text     = "TITOLO APPUNTAMENTO*";

            txtTitolo.Location    = new Point(12, 142);
            txtTitolo.Size        = new Size(480, 23);
            txtTitolo.TabIndex    = 4;
            txtTitolo.TextChanged += txtTitolo_TextChanged2;

            lblStato.AutoSize = true;
            lblStato.Font     = new Font("Segoe UI", 9F);
            lblStato.Location = new Point(12, 172);
            lblStato.Text     = "STATO";

            cmbStato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStato.Location      = new Point(12, 190);
            cmbStato.Size          = new Size(200, 23);
            cmbStato.TabIndex      = 5;

            grpDatiBase.Controls.AddRange(new Control[]
            {
                lblCliente, txtCliente,
                lblOperatore, txtOperatore,
                lblServizio, txtServizio,
                lblTitolo, txtTitolo,
                lblStato, cmbStato
            });

            // ── grpOrari ────────────────────────────────────────────
            grpOrari.Text     = "DATA E ORARI";
            grpOrari.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOrari.Location = new Point(12, 242);
            grpOrari.Size     = new Size(510, 100);
            grpOrari.TabIndex = 1;

            lblData.AutoSize = true;
            lblData.Font     = new Font("Segoe UI", 9F);
            lblData.Location = new Point(12, 24);
            lblData.Text     = "DATA";

            dtpData.Format   = DateTimePickerFormat.Short;
            dtpData.Location = new Point(12, 42);
            dtpData.Size     = new Size(150, 23);
            dtpData.TabIndex = 6;

            lblOraInizio.AutoSize = true;
            lblOraInizio.Font     = new Font("Segoe UI", 9F);
            lblOraInizio.Location = new Point(175, 24);
            lblOraInizio.Text     = "ORA INIZIO";

            dtpOraInizio.Format     = DateTimePickerFormat.Time;
            dtpOraInizio.ShowUpDown = true;
            dtpOraInizio.Location   = new Point(175, 42);
            dtpOraInizio.Size       = new Size(100, 23);
            dtpOraInizio.TabIndex   = 7;

            lblOraFine.AutoSize = true;
            lblOraFine.Font     = new Font("Segoe UI", 9F);
            lblOraFine.Location = new Point(290, 24);
            lblOraFine.Text     = "ORA FINE";

            dtpOraFine.Format          = DateTimePickerFormat.Time;
            dtpOraFine.ShowUpDown      = true;
            dtpOraFine.Location        = new Point(290, 42);
            dtpOraFine.Size            = new Size(100, 23);
            dtpOraFine.TabIndex        = 8;
            dtpOraFine.ValueChanged   += dtpOraFine_ValueChanged;

            grpOrari.Controls.AddRange(new Control[]
            {
                lblData, dtpData,
                lblOraInizio, dtpOraInizio,
                lblOraFine, dtpOraFine
            });

            // ── grpAltro ────────────────────────────────────────────
            grpAltro.Text     = "COLORE E NOTE";
            grpAltro.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAltro.Location = new Point(12, 352);
            grpAltro.Size     = new Size(510, 170);
            grpAltro.TabIndex = 2;

            lblColore.AutoSize = true;
            lblColore.Font     = new Font("Segoe UI", 9F);
            lblColore.Location = new Point(12, 24);
            lblColore.Text     = "COLORE";

            pnlColore.Location    = new Point(12, 42);
            pnlColore.Size        = new Size(40, 23);
            pnlColore.BorderStyle = BorderStyle.FixedSingle;

            btnColore.Location = new Point(58, 40);
            btnColore.Size     = new Size(130, 27);
            btnColore.TabIndex = 9;
            btnColore.Text     = "Scegli colore…";
            btnColore.UseVisualStyleBackColor = true;
            btnColore.Click   += btnColore_Click;

            lblNote.AutoSize = true;
            lblNote.Font     = new Font("Segoe UI", 9F);
            lblNote.Location = new Point(12, 74);
            lblNote.Text     = "NOTE";

            txtNote.Location   = new Point(12, 92);
            txtNote.Multiline  = true;
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size       = new Size(480, 60);
            txtNote.TabIndex   = 10;
            txtNote.Enter     += txtNote_Enter;
            txtNote.Leave     += txtNote_Leave;

            grpAltro.Controls.AddRange(new Control[]
            {
                lblColore, pnlColore, btnColore,
                lblNote, txtNote
            });

            // ── btnOk ────────────────────────────────────────────────
            btnOk.Font     = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Location = new Point(12, 534);
            btnOk.Size     = new Size(300, 45);
            btnOk.TabIndex = 11;
            btnOk.Text     = "SALVA MODIFICHE";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click   += btnOk_Click;

            // ── btnDelete ────────────────────────────────────────────
            btnDelete.Font      = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location  = new Point(318, 534);
            btnDelete.Size      = new Size(110, 45);
            btnDelete.TabIndex  = 12;
            btnDelete.TabStop   = false;
            btnDelete.Text      = "ELIMINA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click    += btnDelete_Click;

            // ── btnAnnulla ───────────────────────────────────────────
            btnAnnulla.Font      = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.ForeColor = Color.Gray;
            btnAnnulla.Location  = new Point(434, 534);
            btnAnnulla.Size      = new Size(88, 45);
            btnAnnulla.TabIndex  = 13;
            btnAnnulla.Text      = "ANNULLA";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click    += btnAnnulla_Click;

            // ── Form ─────────────────────────────────────────────────
            AcceptButton        = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(534, 591);
            FormBorderStyle     = FormBorderStyle.FixedDialog;
            MaximizeBox         = false;
            MinimizeBox         = false;
            Name                = "AppointmentEditForm";
            StartPosition       = FormStartPosition.CenterParent;
            Text                = "MODIFICA APPUNTAMENTO";

            Controls.AddRange(new Control[]
            {
                grpDatiBase,
                grpOrari,
                grpAltro,
                btnOk,
                btnDelete,
                btnAnnulla
            });

            grpDatiBase.ResumeLayout(false);
            grpDatiBase.PerformLayout();
            grpOrari.ResumeLayout(false);
            grpOrari.PerformLayout();
            grpAltro.ResumeLayout(false);
            grpAltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatiBase;
        private GroupBox grpOrari;
        private GroupBox grpAltro;

        private Label    lblTitolo;
        private TextBox  txtTitolo;
        private Label    lblCliente;
        private TextBox  txtCliente;
        private Label    lblOperatore;
        private TextBox  txtOperatore;
        private Label    lblServizio;
        private TextBox  txtServizio;
        private Label    lblStato;
        private ComboBox cmbStato;

        private Label          lblData;
        private DateTimePicker dtpData;
        private Label          lblOraInizio;
        private DateTimePicker dtpOraInizio;
        private Label          lblOraFine;
        private DateTimePicker dtpOraFine;

        private Label   lblColore;
        private Panel   pnlColore;
        private Button  btnColore;
        private Label   lblNote;
        private TextBox txtNote;

        private Button btnOk;
        private Button btnDelete;
        private Button btnAnnulla;
    }
}
