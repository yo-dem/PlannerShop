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
            dtpCompleanno = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            btnOk = new Button();
            txtCognome = new TextBox();
            lblCompleanno = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIndirizzo = new Label();
            txtIndirizzo = new TextBox();
            btnDelete = new Button();
            btnPurchase = new Button();
            btnViewPurchase = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 65);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME*";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 82);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(12, 107);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(72, 15);
            lblCognome.TabIndex = 0;
            lblCognome.Text = "COGNOME*";
            // 
            // dtpCompleanno
            // 
            dtpCompleanno.CustomFormat = " dd-MM";
            dtpCompleanno.Format = DateTimePickerFormat.Custom;
            dtpCompleanno.Location = new Point(12, 405);
            dtpCompleanno.Margin = new Padding(3, 2, 3, 2);
            dtpCompleanno.MaxDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            dtpCompleanno.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.Name = "dtpCompleanno";
            dtpCompleanno.RightToLeft = RightToLeft.No;
            dtpCompleanno.ShowUpDown = true;
            dtpCompleanno.Size = new Size(177, 23);
            dtpCompleanno.TabIndex = 6;
            dtpCompleanno.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.ValueChanged += dtpDataNascita_ValueChanged;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(194, 65);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(37, 15);
            lblNote.TabIndex = 0;
            lblNote.Text = "NOTE";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(195, 82);
            txtNote.Margin = new Padding(3, 2, 3, 2);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Both;
            txtNote.Size = new Size(736, 303);
            txtNote.TabIndex = 7;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(195, 432);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(738, 68);
            btnOk.TabIndex = 10;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(12, 124);
            txtCognome.Margin = new Padding(3, 2, 3, 2);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(177, 23);
            txtCognome.TabIndex = 2;
            txtCognome.TextChanged += txtCognome_TextChanged;
            // 
            // lblCompleanno
            // 
            lblCompleanno.AutoSize = true;
            lblCompleanno.Location = new Point(12, 387);
            lblCompleanno.Name = "lblCompleanno";
            lblCompleanno.Size = new Size(89, 15);
            lblCompleanno.TabIndex = 12;
            lblCompleanno.Text = "COMPLEANNO";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 164);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 23);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 147);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(138, 15);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "RECAPITO TELEFONICO*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 205);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(12, 229);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(63, 15);
            lblIndirizzo.TabIndex = 19;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(12, 246);
            txtIndirizzo.Margin = new Padding(3, 2, 3, 2);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(177, 139);
            txtIndirizzo.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = Properties.Resources.trashImage;
            btnDelete.Location = new Point(12, 432);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 68);
            btnDelete.TabIndex = 0;
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
            btnPurchase.Location = new Point(195, 391);
            btnPurchase.Margin = new Padding(3, 2, 3, 2);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(242, 37);
            btnPurchase.TabIndex = 8;
            btnPurchase.Text = "ACQUISTA PRODOTTO";
            btnPurchase.TextAlign = ContentAlignment.MiddleRight;
            btnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnViewPurchase
            // 
            btnViewPurchase.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViewPurchase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnViewPurchase.ForeColor = SystemColors.ControlText;
            btnViewPurchase.Image = Properties.Resources.calculatotImage;
            btnViewPurchase.Location = new Point(691, 391);
            btnViewPurchase.Margin = new Padding(3, 2, 3, 2);
            btnViewPurchase.Name = "btnViewPurchase";
            btnViewPurchase.Size = new Size(242, 37);
            btnViewPurchase.TabIndex = 9;
            btnViewPurchase.Text = "VISUALIZZA ACQUISTI";
            btnViewPurchase.TextAlign = ContentAlignment.MiddleRight;
            btnViewPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewPurchase.UseVisualStyleBackColor = true;
            btnViewPurchase.Click += btnViewPurchase_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = Properties.Resources.serviziEstetici;
            button1.Location = new Point(443, 391);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(242, 37);
            button1.TabIndex = 20;
            button1.Text = "ACQUISTA SERVIZIO";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // ClientEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 523);
            Controls.Add(button1);
            Controls.Add(btnViewPurchase);
            Controls.Add(btnPurchase);
            Controls.Add(btnDelete);
            Controls.Add(lblIndirizzo);
            Controls.Add(txtIndirizzo);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblCompleanno);
            Controls.Add(txtCognome);
            Controls.Add(btnOk);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpCompleanno);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
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
        private DateTimePicker dtpCompleanno;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnOk;
        private TextBox txtCognome;
        private Label lblCompleanno;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIndirizzo;
        private TextBox txtIndirizzo;
        private Button btnDelete;
        private Button btnPurchase;
        private Button btnViewPurchase;
        private Button button1;
    }
}