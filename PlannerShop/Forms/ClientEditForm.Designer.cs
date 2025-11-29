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
            // dtpCompleanno
            // 
            dtpCompleanno.CustomFormat = " dd-MM";
            dtpCompleanno.Format = DateTimePickerFormat.Custom;
            dtpCompleanno.Location = new Point(14, 540);
            dtpCompleanno.MaxDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            dtpCompleanno.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.Name = "dtpCompleanno";
            dtpCompleanno.RightToLeft = RightToLeft.No;
            dtpCompleanno.ShowUpDown = true;
            dtpCompleanno.Size = new Size(202, 27);
            dtpCompleanno.TabIndex = 0;
            dtpCompleanno.TabStop = false;
            dtpCompleanno.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.ValueChanged += dtpDataNascita_ValueChanged;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(222, 87);
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
            txtNote.Size = new Size(840, 403);
            txtNote.TabIndex = 7;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(223, 576);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(841, 91);
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
            // lblCompleanno
            // 
            lblCompleanno.AutoSize = true;
            lblCompleanno.Location = new Point(14, 516);
            lblCompleanno.Name = "lblCompleanno";
            lblCompleanno.Size = new Size(108, 20);
            lblCompleanno.TabIndex = 12;
            lblCompleanno.Text = "COMPLEANNO";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(14, 219);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(202, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(169, 20);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "RECAPITO TELEFONICO*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(14, 303);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(81, 20);
            lblIndirizzo.TabIndex = 19;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(14, 326);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(202, 186);
            txtIndirizzo.TabIndex = 6;
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
            btnPurchase.Location = new Point(223, 521);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(584, 49);
            btnPurchase.TabIndex = 8;
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
            button1.Location = new Point(813, 521);
            button1.Name = "button1";
            button1.Size = new Size(251, 49);
            button1.TabIndex = 9;
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
            ClientSize = new Size(1082, 689);
            Controls.Add(button1);
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
            MinimumSize = new Size(1100, 736);
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
        private Button button1;
    }
}