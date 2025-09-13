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
            chkRipeti = new CheckBox();
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
            txtNote.Size = new Size(647, 460);
            txtNote.TabIndex = 8;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(14, 576);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(857, 91);
            btnOk.TabIndex = 10;
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
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL*";
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
            // chkRipeti
            // 
            chkRipeti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkRipeti.AutoSize = true;
            chkRipeti.CheckAlign = ContentAlignment.MiddleRight;
            chkRipeti.Location = new Point(705, 12);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(170, 24);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
            // 
            // ClientInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 681);
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
            Controls.Add(chkRipeti);
            Controls.Add(btnOk);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpDataNascita);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(903, 715);
            Name = "ClientInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO CLIENTE";
            WindowState = FormWindowState.Maximized;
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
        private CheckBox chkRipeti;
    }
}