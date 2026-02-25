namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    partial class AppointmentEditForm
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
            lblTitolo = new Label();
            txtTitolo = new TextBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblOperatore = new Label();
            txtOperatore = new TextBox();
            lblServizio = new Label();
            txtServizio = new TextBox();
            lblData = new Label();
            dtpData = new DateTimePicker();
            lblOraInizio = new Label();
            dtpOraInizio = new DateTimePicker();
            lblOraFine = new Label();
            dtpOraFine = new DateTimePicker();
            lblStato = new Label();
            cmbStato = new ComboBox();
            lblColore = new Label();
            pnlColore = new Panel();
            btnColor1 = new Button();
            btnColor2 = new Button();
            btnColor3 = new Button();
            btnColor4 = new Button();
            btnColor5 = new Button();
            btnColor6 = new Button();
            lblNote = new Label();
            txtNote = new TextBox();
            btnOk = new Button();
            btnDelete = new Button();
            btnAnnulla = new Button();
            grpDatiBase = new GroupBox();
            grpOrari = new GroupBox();
            grpAltro = new GroupBox();
            grpDatiBase.SuspendLayout();
            grpOrari.SuspendLayout();
            grpAltro.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI", 9F);
            lblTitolo.Location = new Point(12, 124);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(149, 15);
            lblTitolo.TabIndex = 4;
            lblTitolo.Text = "TITOLO APPUNTAMENTO*";
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(6, 142);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(498, 23);
            txtTitolo.TabIndex = 4;
            txtTitolo.TextChanged += txtTitolo_TextChanged2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F);
            lblCliente.Location = new Point(12, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(57, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "CLIENTE*";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 46);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(236, 23);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // lblOperatore
            // 
            lblOperatore.AutoSize = true;
            lblOperatore.Font = new Font("Segoe UI", 9F);
            lblOperatore.Location = new Point(258, 28);
            lblOperatore.Name = "lblOperatore";
            lblOperatore.Size = new Size(71, 15);
            lblOperatore.TabIndex = 2;
            lblOperatore.Text = "OPERATORE";
            // 
            // txtOperatore
            // 
            txtOperatore.Location = new Point(258, 46);
            txtOperatore.Name = "txtOperatore";
            txtOperatore.Size = new Size(246, 23);
            txtOperatore.TabIndex = 2;
            // 
            // lblServizio
            // 
            lblServizio.AutoSize = true;
            lblServizio.Font = new Font("Segoe UI", 9F);
            lblServizio.Location = new Point(12, 76);
            lblServizio.Name = "lblServizio";
            lblServizio.Size = new Size(149, 15);
            lblServizio.TabIndex = 3;
            lblServizio.Text = "SERVIZIO / TRATTAMENTO";
            // 
            // txtServizio
            // 
            txtServizio.Location = new Point(6, 94);
            txtServizio.Name = "txtServizio";
            txtServizio.Size = new Size(498, 23);
            txtServizio.TabIndex = 3;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F);
            lblData.Location = new Point(12, 24);
            lblData.Name = "lblData";
            lblData.Size = new Size(36, 15);
            lblData.TabIndex = 0;
            lblData.Text = "DATA";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(6, 42);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(156, 23);
            dtpData.TabIndex = 6;
            // 
            // lblOraInizio
            // 
            lblOraInizio.AutoSize = true;
            lblOraInizio.Font = new Font("Segoe UI", 9F);
            lblOraInizio.Location = new Point(175, 24);
            lblOraInizio.Name = "lblOraInizio";
            lblOraInizio.Size = new Size(68, 15);
            lblOraInizio.TabIndex = 7;
            lblOraInizio.Text = "ORA INIZIO";
            // 
            // dtpOraInizio
            // 
            dtpOraInizio.Format = DateTimePickerFormat.Time;
            dtpOraInizio.Location = new Point(175, 42);
            dtpOraInizio.Name = "dtpOraInizio";
            dtpOraInizio.ShowUpDown = true;
            dtpOraInizio.Size = new Size(100, 23);
            dtpOraInizio.TabIndex = 7;
            // 
            // lblOraFine
            // 
            lblOraFine.AutoSize = true;
            lblOraFine.Font = new Font("Segoe UI", 9F);
            lblOraFine.Location = new Point(290, 24);
            lblOraFine.Name = "lblOraFine";
            lblOraFine.Size = new Size(58, 15);
            lblOraFine.TabIndex = 8;
            lblOraFine.Text = "ORA FINE";
            // 
            // dtpOraFine
            // 
            dtpOraFine.Format = DateTimePickerFormat.Time;
            dtpOraFine.Location = new Point(290, 42);
            dtpOraFine.Name = "dtpOraFine";
            dtpOraFine.ShowUpDown = true;
            dtpOraFine.Size = new Size(100, 23);
            dtpOraFine.TabIndex = 8;
            dtpOraFine.ValueChanged += dtpOraFine_ValueChanged;
            // 
            // lblStato
            // 
            lblStato.AutoSize = true;
            lblStato.Font = new Font("Segoe UI", 9F);
            lblStato.Location = new Point(12, 172);
            lblStato.Name = "lblStato";
            lblStato.Size = new Size(41, 15);
            lblStato.TabIndex = 5;
            lblStato.Text = "STATO";
            // 
            // cmbStato
            // 
            cmbStato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStato.Location = new Point(6, 190);
            cmbStato.Name = "cmbStato";
            cmbStato.Size = new Size(206, 23);
            cmbStato.TabIndex = 5;
            // 
            // lblColore
            // 
            lblColore.AutoSize = true;
            lblColore.Font = new Font("Segoe UI", 9F);
            lblColore.Location = new Point(6, 24);
            lblColore.Name = "lblColore";
            lblColore.Size = new Size(52, 15);
            lblColore.TabIndex = 0;
            lblColore.Text = "COLORE";
            // 
            // pnlColore
            // 
            pnlColore.Location = new Point(6, 42);
            pnlColore.Name = "pnlColore";
            pnlColore.Size = new Size(24, 26);
            pnlColore.TabIndex = 1;
            // 
            // btnColor1
            // 
            btnColor1.BackColor = Color.MediumSlateBlue;
            btnColor1.FlatStyle = FlatStyle.Flat;
            btnColor1.Location = new Point(36, 42);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(46, 26);
            btnColor1.TabIndex = 2;
            btnColor1.TabStop = false;
            btnColor1.UseVisualStyleBackColor = false;
            // 
            // btnColor2
            // 
            btnColor2.BackColor = Color.FromArgb(26, 35, 126);
            btnColor2.FlatStyle = FlatStyle.Flat;
            btnColor2.Location = new Point(84, 42);
            btnColor2.Name = "btnColor2";
            btnColor2.Size = new Size(46, 26);
            btnColor2.TabIndex = 3;
            btnColor2.TabStop = false;
            btnColor2.UseVisualStyleBackColor = false;
            // 
            // btnColor3
            // 
            btnColor3.BackColor = Color.DarkOrange;
            btnColor3.FlatStyle = FlatStyle.Flat;
            btnColor3.Location = new Point(132, 42);
            btnColor3.Name = "btnColor3";
            btnColor3.Size = new Size(46, 26);
            btnColor3.TabIndex = 4;
            btnColor3.TabStop = false;
            btnColor3.UseVisualStyleBackColor = false;
            // 
            // btnColor4
            // 
            btnColor4.BackColor = Color.SeaGreen;
            btnColor4.FlatStyle = FlatStyle.Flat;
            btnColor4.Location = new Point(180, 42);
            btnColor4.Name = "btnColor4";
            btnColor4.Size = new Size(46, 26);
            btnColor4.TabIndex = 5;
            btnColor4.TabStop = false;
            btnColor4.UseVisualStyleBackColor = false;
            // 
            // btnColor5
            // 
            btnColor5.BackColor = Color.FromArgb(178, 34, 34);
            btnColor5.FlatStyle = FlatStyle.Flat;
            btnColor5.Location = new Point(228, 42);
            btnColor5.Name = "btnColor5";
            btnColor5.Size = new Size(46, 26);
            btnColor5.TabIndex = 6;
            btnColor5.TabStop = false;
            btnColor5.UseVisualStyleBackColor = false;
            // 
            // btnColor6
            // 
            btnColor6.BackColor = Color.FromArgb(184, 134, 11);
            btnColor6.FlatStyle = FlatStyle.Flat;
            btnColor6.Location = new Point(276, 42);
            btnColor6.Name = "btnColor6";
            btnColor6.Size = new Size(46, 26);
            btnColor6.TabIndex = 7;
            btnColor6.TabStop = false;
            btnColor6.UseVisualStyleBackColor = false;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.Location = new Point(12, 78);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(37, 15);
            lblNote.TabIndex = 6;
            lblNote.Text = "NOTE";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(6, 96);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(498, 60);
            txtNote.TabIndex = 10;
            txtNote.Enter += txtNote_Enter;
            txtNote.Leave += txtNote_Leave;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Location = new Point(12, 534);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(300, 45);
            btnOk.TabIndex = 11;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(318, 534);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 45);
            btnDelete.TabIndex = 12;
            btnDelete.TabStop = false;
            btnDelete.Text = "ELIMINA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.ForeColor = Color.Gray;
            btnAnnulla.Location = new Point(434, 534);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(88, 45);
            btnAnnulla.TabIndex = 13;
            btnAnnulla.Text = "ANNULLA";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // grpDatiBase
            // 
            grpDatiBase.Controls.Add(lblCliente);
            grpDatiBase.Controls.Add(txtCliente);
            grpDatiBase.Controls.Add(lblOperatore);
            grpDatiBase.Controls.Add(txtOperatore);
            grpDatiBase.Controls.Add(lblServizio);
            grpDatiBase.Controls.Add(txtServizio);
            grpDatiBase.Controls.Add(lblTitolo);
            grpDatiBase.Controls.Add(txtTitolo);
            grpDatiBase.Controls.Add(lblStato);
            grpDatiBase.Controls.Add(cmbStato);
            grpDatiBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDatiBase.Location = new Point(12, 12);
            grpDatiBase.Name = "grpDatiBase";
            grpDatiBase.Size = new Size(510, 220);
            grpDatiBase.TabIndex = 0;
            grpDatiBase.TabStop = false;
            grpDatiBase.Text = "DATI APPUNTAMENTO";
            // 
            // grpOrari
            // 
            grpOrari.Controls.Add(lblData);
            grpOrari.Controls.Add(dtpData);
            grpOrari.Controls.Add(lblOraInizio);
            grpOrari.Controls.Add(dtpOraInizio);
            grpOrari.Controls.Add(lblOraFine);
            grpOrari.Controls.Add(dtpOraFine);
            grpOrari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOrari.Location = new Point(12, 242);
            grpOrari.Name = "grpOrari";
            grpOrari.Size = new Size(510, 100);
            grpOrari.TabIndex = 1;
            grpOrari.TabStop = false;
            grpOrari.Text = "DATA E ORARI";
            // 
            // grpAltro
            // 
            grpAltro.Controls.Add(lblColore);
            grpAltro.Controls.Add(pnlColore);
            grpAltro.Controls.Add(btnColor1);
            grpAltro.Controls.Add(btnColor2);
            grpAltro.Controls.Add(btnColor3);
            grpAltro.Controls.Add(btnColor4);
            grpAltro.Controls.Add(btnColor5);
            grpAltro.Controls.Add(btnColor6);
            grpAltro.Controls.Add(lblNote);
            grpAltro.Controls.Add(txtNote);
            grpAltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAltro.Location = new Point(12, 352);
            grpAltro.Name = "grpAltro";
            grpAltro.Size = new Size(510, 170);
            grpAltro.TabIndex = 2;
            grpAltro.TabStop = false;
            grpAltro.Text = "COLORE E NOTE";
            // 
            // AppointmentEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 591);
            Controls.Add(grpDatiBase);
            Controls.Add(grpOrari);
            Controls.Add(grpAltro);
            Controls.Add(btnOk);
            Controls.Add(btnDelete);
            Controls.Add(btnAnnulla);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MODIFICA APPUNTAMENTO";
            grpDatiBase.ResumeLayout(false);
            grpDatiBase.PerformLayout();
            grpOrari.ResumeLayout(false);
            grpOrari.PerformLayout();
            grpAltro.ResumeLayout(false);
            grpAltro.PerformLayout();
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
        private Button btnColor1, btnColor2, btnColor3, btnColor4, btnColor5, btnColor6;
        private TextBox txtNote;
        private Button btnOk, btnDelete, btnAnnulla;
    }
}