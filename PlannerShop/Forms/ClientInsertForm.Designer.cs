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
            btnAnnulla = new Button();
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
            dtpCompleanno.Location = new Point(12, 404);
            dtpCompleanno.Margin = new Padding(3, 2, 3, 2);
            dtpCompleanno.MaxDate = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            dtpCompleanno.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCompleanno.Name = "dtpCompleanno";
            dtpCompleanno.ShowUpDown = true;
            dtpCompleanno.Size = new Size(177, 23);
            dtpCompleanno.TabIndex = 6;
            dtpCompleanno.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(195, 65);
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
            txtNote.Size = new Size(737, 345);
            txtNote.TabIndex = 7;
            txtNote.Enter += txtNote_Enter;
            txtNote.Leave += txtNote_Leave;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(195, 431);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(737, 68);
            btnOk.TabIndex = 8;
            btnOk.Text = "CARICA CLIENTE";
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
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 147);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(138, 15);
            lblTelefono.TabIndex = 15;
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
            txtEmail.Location = new Point(10, 204);
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
            // chkRipeti
            // 
            chkRipeti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkRipeti.AutoSize = true;
            chkRipeti.CheckAlign = ContentAlignment.MiddleRight;
            chkRipeti.Location = new Point(800, 9);
            chkRipeti.Margin = new Padding(3, 2, 3, 2);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(137, 19);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
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
            // btnAnnulla
            // 
            btnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.ForeColor = SystemColors.ControlText;
            btnAnnulla.Image = Properties.Resources.annulla_24;
            btnAnnulla.Location = new Point(12, 431);
            btnAnnulla.Margin = new Padding(3, 2, 3, 2);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(176, 68);
            btnAnnulla.TabIndex = 21;
            btnAnnulla.TabStop = false;
            btnAnnulla.Text = "ANNULLA";
            btnAnnulla.TextAlign = ContentAlignment.BottomCenter;
            btnAnnulla.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // ClientInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 523);
            Controls.Add(btnAnnulla);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
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
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIndirizzo;
        private TextBox txtIndirizzo;
        private CheckBox chkRipeti;
        private TextBox txtTelefono;
        private Button btnAnnulla;
    }
}