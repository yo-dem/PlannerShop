namespace PlannerShop.Forms
{
    partial class ClientEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEditForm));
            lblNome = new Label();
            txtNome = new TextBox();
            lblCognome = new Label();
            dtpDataNascita = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            btnOk = new Button();
            txtCognome = new TextBox();
            lblDataNascita = new Label();
            txtTelefonoFisso = new TextBox();
            lblTelefonoFisso = new Label();
            txtTelefonoMobile = new TextBox();
            lblTelefonoMobile = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIndirizzo = new Label();
            txtIndirizzo = new TextBox();
            btnDelete = new Button();
            btnPurchase = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(14, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(58, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME*";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(14, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(14, 143);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(88, 20);
            lblCognome.TabIndex = 0;
            lblCognome.Text = "COGNOME*";
            // 
            // dtpDataNascita
            // 
            dtpDataNascita.CustomFormat = " ";
            dtpDataNascita.Format = DateTimePickerFormat.Short;
            dtpDataNascita.Location = new Point(14, 540);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(202, 27);
            dtpDataNascita.TabIndex = 7;
            dtpDataNascita.TabStop = false;
            dtpDataNascita.Value = new DateTime(1990, 5, 30, 0, 0, 0, 0);
            dtpDataNascita.ValueChanged += dtpDataNascita_ValueChanged;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(223, 87);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(46, 20);
            lblNote.TabIndex = 0;
            lblNote.Text = "NOTE";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(223, 109);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(647, 403);
            txtNote.TabIndex = 8;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(223, 576);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(648, 91);
            btnOk.TabIndex = 10;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(14, 165);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(202, 27);
            txtCognome.TabIndex = 2;
            txtCognome.TextChanged += txtCognome_TextChanged;
            // 
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Location = new Point(14, 516);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(134, 20);
            lblDataNascita.TabIndex = 12;
            lblDataNascita.Text = "DATA DI NASCITA*";
            // 
            // txtTelefonoFisso
            // 
            txtTelefonoFisso.Location = new Point(14, 219);
            txtTelefonoFisso.Name = "txtTelefonoFisso";
            txtTelefonoFisso.Size = new Size(202, 27);
            txtTelefonoFisso.TabIndex = 3;
            // 
            // lblTelefonoFisso
            // 
            lblTelefonoFisso.AutoSize = true;
            lblTelefonoFisso.Location = new Point(14, 196);
            lblTelefonoFisso.Name = "lblTelefonoFisso";
            lblTelefonoFisso.Size = new Size(122, 20);
            lblTelefonoFisso.TabIndex = 13;
            lblTelefonoFisso.Text = "TELEFONO FISSO";
            // 
            // txtTelefonoMobile
            // 
            txtTelefonoMobile.Location = new Point(14, 272);
            txtTelefonoMobile.Name = "txtTelefonoMobile";
            txtTelefonoMobile.Size = new Size(202, 27);
            txtTelefonoMobile.TabIndex = 4;
            txtTelefonoMobile.TextChanged += txtTelefonoMobile_TextChanged;
            // 
            // lblTelefonoMobile
            // 
            lblTelefonoMobile.AutoSize = true;
            lblTelefonoMobile.Location = new Point(14, 249);
            lblTelefonoMobile.Name = "lblTelefonoMobile";
            lblTelefonoMobile.Size = new Size(90, 20);
            lblTelefonoMobile.TabIndex = 15;
            lblTelefonoMobile.Text = "CELLULARE*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 305);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(14, 363);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(87, 20);
            lblIndirizzo.TabIndex = 19;
            lblIndirizzo.Text = "INDIRIZZO*";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(14, 385);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(202, 127);
            txtIndirizzo.TabIndex = 6;
            txtIndirizzo.TextChanged += txtIndirizzo_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = Properties.Resources.trashImage;
            btnDelete.Location = new Point(14, 576);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 91);
            btnDelete.TabIndex = 20;
            btnDelete.TabStop = false;
            btnDelete.Text = "ELIMINA IL CLIENTE";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPurchase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPurchase.ForeColor = SystemColors.ControlText;
            btnPurchase.Image = Properties.Resources.prodotti_24;
            btnPurchase.Location = new Point(223, 518);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(391, 52);
            btnPurchase.TabIndex = 21;
            btnPurchase.Text = "EFFETTUA ACQUISTO";
            btnPurchase.TextAlign = ContentAlignment.MiddleRight;
            btnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = Properties.Resources.statistiche_24;
            button1.Location = new Point(620, 518);
            button1.Name = "button1";
            button1.Size = new Size(250, 52);
            button1.TabIndex = 22;
            button1.Text = "VISUALIZZA ACQUISTI";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // ClientEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 681);
            Controls.Add(button1);
            Controls.Add(btnPurchase);
            Controls.Add(btnDelete);
            Controls.Add(lblIndirizzo);
            Controls.Add(txtIndirizzo);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefonoMobile);
            Controls.Add(lblTelefonoMobile);
            Controls.Add(txtTelefonoFisso);
            Controls.Add(lblTelefonoFisso);
            Controls.Add(lblDataNascita);
            Controls.Add(txtCognome);
            Controls.Add(btnOk);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpDataNascita);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(905, 728);
            Name = "ClientEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MODIFICA CLIENTE";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCognome;
        private DateTimePicker dtpDataNascita;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnOk;
        private TextBox txtCognome;
        private Label lblDataNascita;
        private TextBox txtTelefonoFisso;
        private Label lblTelefonoFisso;
        private TextBox txtTelefonoMobile;
        private Label lblTelefonoMobile;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIndirizzo;
        private TextBox txtIndirizzo;
        private Button btnDelete;
        private Button btnPurchase;
        private Button button1;
    }
}