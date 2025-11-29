namespace PlannerShop.Forms
{
    partial class ClientInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInsertForm));
            lblNome = new Label();
            txtNome = new TextBox();
            lblCognome = new Label();
            dtpCompleanno = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            btnOk = new Button();
            txtCognome = new TextBox();
            lblCompleanno = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIndirizzo = new Label();
            txtIndirizzo = new TextBox();
            chkRipeti = new CheckBox();
            txtTelefono = new TextBox();
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
            dtpCompleanno.Location = new Point(14, 550);
            dtpCompleanno.MaxDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            dtpCompleanno.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.Name = "dtpCompleanno";
            dtpCompleanno.ShowUpDown = true;
            dtpCompleanno.Size = new Size(202, 27);
            dtpCompleanno.TabIndex = 0;
            dtpCompleanno.TabStop = false;
            dtpCompleanno.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            txtNote.Size = new Size(842, 468);
            txtNote.TabIndex = 7;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(14, 584);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(1052, 91);
            btnOk.TabIndex = 8;
            btnOk.Text = "CARICA CLIENTE";
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
            lblCompleanno.Location = new Point(14, 526);
            lblCompleanno.Name = "lblCompleanno";
            lblCompleanno.Size = new Size(108, 20);
            lblCompleanno.TabIndex = 12;
            lblCompleanno.Text = "COMPLEANNO";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 195);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(169, 20);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "RECAPITO TELEFONICO*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 248);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(14, 302);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(81, 20);
            lblIndirizzo.TabIndex = 19;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(14, 325);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(202, 198);
            txtIndirizzo.TabIndex = 6;
            // 
            // chkRipeti
            // 
            chkRipeti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkRipeti.AutoSize = true;
            chkRipeti.CheckAlign = ContentAlignment.MiddleRight;
            chkRipeti.Location = new Point(900, 12);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(170, 24);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(14, 218);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(202, 27);
            txtTelefono.TabIndex = 20;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // ClientInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 689);
            Controls.Add(txtTelefono);
            Controls.Add(lblIndirizzo);
            Controls.Add(txtIndirizzo);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblCompleanno);
            Controls.Add(txtCognome);
            Controls.Add(chkRipeti);
            Controls.Add(btnOk);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpCompleanno);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 736);
            Name = "ClientInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO CLIENTE";
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
        private TextBox txtTelefonoFisso;
        private Label lblTelefonoFisso;
        private TextBox txtTelefonoMobile;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIndirizzo;
        private TextBox txtIndirizzo;
        private CheckBox chkRipeti;
        private TextBox txtTelefono;
    }
}