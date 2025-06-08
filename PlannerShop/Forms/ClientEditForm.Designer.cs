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
            chkRipeti = new CheckBox();
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
            // dtpDataNascita
            // 
            dtpDataNascita.CustomFormat = " ";
            dtpDataNascita.Format = DateTimePickerFormat.Short;
            dtpDataNascita.Location = new Point(12, 405);
            dtpDataNascita.Margin = new Padding(3, 2, 3, 2);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(177, 23);
            dtpDataNascita.TabIndex = 7;
            dtpDataNascita.TabStop = false;
            dtpDataNascita.Value = new DateTime(1990, 5, 30, 0, 0, 0, 0);
            dtpDataNascita.ValueChanged += dtpDataNascita_ValueChanged;
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
            txtNote.Size = new Size(567, 346);
            txtNote.TabIndex = 8;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(195, 432);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(567, 68);
            btnOk.TabIndex = 10;
            btnOk.Text = "SALVA MODIFICHE";
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
            chkRipeti.Location = new Point(627, 9);
            chkRipeti.Margin = new Padding(3, 2, 3, 2);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(137, 19);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
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
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Location = new Point(12, 387);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(106, 15);
            lblDataNascita.TabIndex = 12;
            lblDataNascita.Text = "DATA DI NASCITA*";
            // 
            // txtTelefonoFisso
            // 
            txtTelefonoFisso.Location = new Point(12, 164);
            txtTelefonoFisso.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoFisso.Name = "txtTelefonoFisso";
            txtTelefonoFisso.Size = new Size(177, 23);
            txtTelefonoFisso.TabIndex = 3;
            // 
            // lblTelefonoFisso
            // 
            lblTelefonoFisso.AutoSize = true;
            lblTelefonoFisso.Location = new Point(12, 147);
            lblTelefonoFisso.Name = "lblTelefonoFisso";
            lblTelefonoFisso.Size = new Size(98, 15);
            lblTelefonoFisso.TabIndex = 13;
            lblTelefonoFisso.Text = "TELEFONO FISSO";
            // 
            // txtTelefonoMobile
            // 
            txtTelefonoMobile.Location = new Point(12, 204);
            txtTelefonoMobile.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoMobile.Name = "txtTelefonoMobile";
            txtTelefonoMobile.Size = new Size(177, 23);
            txtTelefonoMobile.TabIndex = 4;
            txtTelefonoMobile.TextChanged += txtTelefonoMobile_TextChanged;
            // 
            // lblTelefonoMobile
            // 
            lblTelefonoMobile.AutoSize = true;
            lblTelefonoMobile.Location = new Point(12, 187);
            lblTelefonoMobile.Name = "lblTelefonoMobile";
            lblTelefonoMobile.Size = new Size(73, 15);
            lblTelefonoMobile.TabIndex = 15;
            lblTelefonoMobile.Text = "CELLULARE*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 229);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 247);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(12, 272);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(68, 15);
            lblIndirizzo.TabIndex = 19;
            lblIndirizzo.Text = "INDIRIZZO*";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(12, 289);
            txtIndirizzo.Margin = new Padding(3, 2, 3, 2);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(177, 96);
            txtIndirizzo.TabIndex = 6;
            txtIndirizzo.TextChanged += txtIndirizzo_TextChanged;
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
            btnDelete.TabIndex = 20;
            btnDelete.TabStop = false;
            btnDelete.Text = "ELIMINA IL CLIENTE";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ClientEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 511);
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
            Controls.Add(chkRipeti);
            Controls.Add(btnOk);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpDataNascita);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(792, 550);
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
        private CheckBox chkRipeti;
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
    }
}