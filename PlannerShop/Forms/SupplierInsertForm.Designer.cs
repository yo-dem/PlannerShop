namespace PlannerShop.Forms
{
    partial class SupplierInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierInsertForm));
            lblNome = new Label();
            txtNome = new TextBox();
            lblIndirizzo = new Label();
            txtIndirizzo = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnOk = new Button();
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
            txtNome.TextChanged += TxtNome_TextChanged;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(14, 143);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(87, 20);
            lblIndirizzo.TabIndex = 0;
            lblIndirizzo.Text = "INDIRIZZO*";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(14, 165);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(202, 103);
            txtIndirizzo.TabIndex = 2;
            txtIndirizzo.TextChanged += TxtIndirizzo_TextChanged;
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
            txtNote.Size = new Size(842, 460);
            txtNote.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 271);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(169, 20);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "RECAPITO TELEFONICO*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 327);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 350);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(14, 576);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(1052, 91);
            btnOk.TabIndex = 10;
            btnOk.Text = "CARICA FORNITORE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
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
            txtTelefono.Location = new Point(14, 294);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(202, 27);
            txtTelefono.TabIndex = 4;
            txtTelefono.TextAlign = HorizontalAlignment.Right;
            txtTelefono.KeyPress += txtTelefonoMobile_KeyPress;
            // 
            // SupplierInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 689);
            Controls.Add(txtTelefono);
            Controls.Add(chkRipeti);
            Controls.Add(btnOk);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(lblIndirizzo);
            Controls.Add(txtIndirizzo);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 736);
            Name = "SupplierInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO FORNITORE";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lblNome;
        private TextBox txtNome;
        private Label lblIndirizzo;
        private TextBox txtIndirizzo;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnOk;
        private CheckBox chkRipeti;
        private TextBox txtTelefono;
    }
}