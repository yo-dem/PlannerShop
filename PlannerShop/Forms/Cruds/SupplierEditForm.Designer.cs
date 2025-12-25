namespace PlannerShop.Forms
{
    partial class SupplierEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEditForm));
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
            txtTelefono = new TextBox();
            btnDelete = new Button();
            lblIban = new Label();
            txtIban = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 65);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 82);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += TxtNome_TextChanged;
            txtNome.KeyDown += txtMarca_KeyDown;
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Location = new Point(12, 107);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(63, 15);
            lblIndirizzo.TabIndex = 0;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // txtIndirizzo
            // 
            txtIndirizzo.Location = new Point(12, 124);
            txtIndirizzo.Margin = new Padding(3, 2, 3, 2);
            txtIndirizzo.Multiline = true;
            txtIndirizzo.Name = "txtIndirizzo";
            txtIndirizzo.Size = new Size(177, 78);
            txtIndirizzo.TabIndex = 2;
            txtIndirizzo.TextChanged += TxtIndirizzo_TextChanged;
            txtIndirizzo.Enter += txtIndirizzo_Enter;
            txtIndirizzo.Leave += txtIndirizzo_Leave;
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
            txtNote.Size = new Size(737, 346);
            txtNote.TabIndex = 6;
            txtNote.Enter += txtNote_Enter;
            txtNote.Leave += txtNote_Leave;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 203);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(138, 15);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "RECAPITO TELEFONICO*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 262);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            txtEmail.TextChanged += TxtEmail_TextChanged;
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
            btnOk.TabIndex = 7;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 220);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 23);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextAlign = HorizontalAlignment.Right;
            txtTelefono.TextChanged += TxtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefonoMobile_KeyPress;
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
            btnDelete.Text = "ELIMINA IL FORNITORE";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblIban
            // 
            lblIban.AutoSize = true;
            lblIban.Location = new Point(12, 287);
            lblIban.Name = "lblIban";
            lblIban.Size = new Size(34, 15);
            lblIban.TabIndex = 13;
            lblIban.Text = "IBAN";
            // 
            // txtIban
            // 
            txtIban.Location = new Point(12, 304);
            txtIban.Margin = new Padding(3, 2, 3, 2);
            txtIban.Name = "txtIban";
            txtIban.Size = new Size(177, 23);
            txtIban.TabIndex = 5;
            txtIban.TextAlign = HorizontalAlignment.Right;
            txtIban.TextChanged += TxtIban_TextChanged;
            // 
            // SupplierEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 523);
            Controls.Add(lblIban);
            Controls.Add(txtIban);
            Controls.Add(btnDelete);
            Controls.Add(txtTelefono);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
            Name = "SupplierEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MODIFICA FORNITORE";
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
        private TextBox txtTelefono;
        private Button btnDelete;
        private Label lblIban;
        private TextBox txtIban;
    }
}