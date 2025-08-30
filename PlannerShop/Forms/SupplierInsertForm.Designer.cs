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
            lblTelefonoMobile = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnOk = new Button();
            chkRipeti = new CheckBox();
            lblTelefonoFisso = new Label();
            txtTelefonoFisso = new TextBox();
            txtTelefonoMobile = new TextBox();
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
            txtNote.Size = new Size(647, 327);
            txtNote.TabIndex = 6;
            // 
            // lblTelefonoMobile
            // 
            lblTelefonoMobile.AutoSize = true;
            lblTelefonoMobile.Location = new Point(14, 328);
            lblTelefonoMobile.Name = "lblTelefonoMobile";
            lblTelefonoMobile.Size = new Size(90, 20);
            lblTelefonoMobile.TabIndex = 0;
            lblTelefonoMobile.Text = "CELLULARE*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 384);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 407);
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
            btnOk.Location = new Point(14, 443);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(857, 91);
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
            chkRipeti.Location = new Point(704, 12);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(170, 24);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
            // 
            // lblTelefonoFisso
            // 
            lblTelefonoFisso.AutoSize = true;
            lblTelefonoFisso.Location = new Point(14, 272);
            lblTelefonoFisso.Name = "lblTelefonoFisso";
            lblTelefonoFisso.Size = new Size(128, 20);
            lblTelefonoFisso.TabIndex = 11;
            lblTelefonoFisso.Text = "TELEFONO FISSO*";
            // 
            // txtTelefonoFisso
            // 
            txtTelefonoFisso.Location = new Point(14, 295);
            txtTelefonoFisso.Name = "txtTelefonoFisso";
            txtTelefonoFisso.Size = new Size(202, 27);
            txtTelefonoFisso.TabIndex = 3;
            txtTelefonoFisso.TextAlign = HorizontalAlignment.Right;
            txtTelefonoFisso.TextChanged += TxtTelefonoFisso_TextChanged;
            txtTelefonoFisso.KeyPress += txtTelefonoFisso_KeyPress;
            // 
            // txtTelefonoMobile
            // 
            txtTelefonoMobile.Location = new Point(14, 351);
            txtTelefonoMobile.Name = "txtTelefonoMobile";
            txtTelefonoMobile.Size = new Size(202, 27);
            txtTelefonoMobile.TabIndex = 4;
            txtTelefonoMobile.TextAlign = HorizontalAlignment.Right;
            txtTelefonoMobile.TextChanged += TxtTelefonoMobile_TextChanged;
            txtTelefonoMobile.KeyPress += txtTelefonoMobile_KeyPress;
            // 
            // SupplierInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 556);
            Controls.Add(txtTelefonoMobile);
            Controls.Add(lblTelefonoFisso);
            Controls.Add(txtTelefonoFisso);
            Controls.Add(chkRipeti);
            Controls.Add(btnOk);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTelefonoMobile);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(lblIndirizzo);
            Controls.Add(txtIndirizzo);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(903, 592);
            Name = "SupplierInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO FORNITORE";
            WindowState = FormWindowState.Maximized;
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
        private Label lblTelefonoMobile;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnOk;
        private CheckBox chkRipeti;
        private Label lblTelefonoFisso;
        private TextBox txtTelefonoFisso;
        private TextBox txtTelefonoMobile;
    }
}