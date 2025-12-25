namespace PlannerShop.Forms
{
    partial class ServiceEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceEditForm));
            btnOk = new Button();
            lblPrezzoIvato = new Label();
            txtPrezzoIvato = new TextBox();
            lblPrezzoNetto = new Label();
            txtPrezzoNetto = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            dtpData = new DateTimePicker();
            lblDescrizione = new Label();
            txtDescrizione = new TextBox();
            lblNome = new Label();
            txtMarca = new TextBox();
            btnDelete = new Button();
            rdbPrezzoNetto = new RadioButton();
            rdbPrezzoIvato = new RadioButton();
            lblPrezzoVendita = new Label();
            txtPrezzoVendita = new TextBox();
            lblAliquota = new Label();
            nudAliquota = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAliquota).BeginInit();
            SuspendLayout();
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
            btnOk.TabIndex = 6;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblPrezzoIvato
            // 
            lblPrezzoIvato.AutoSize = true;
            lblPrezzoIvato.Location = new Point(12, 288);
            lblPrezzoIvato.Name = "lblPrezzoIvato";
            lblPrezzoIvato.Size = new Size(89, 15);
            lblPrezzoIvato.TabIndex = 0;
            lblPrezzoIvato.Text = "PREZZO IVATO*";
            // 
            // txtPrezzoIvato
            // 
            txtPrezzoIvato.Location = new Point(12, 305);
            txtPrezzoIvato.Margin = new Padding(3, 2, 3, 2);
            txtPrezzoIvato.Name = "txtPrezzoIvato";
            txtPrezzoIvato.Size = new Size(156, 23);
            txtPrezzoIvato.TabIndex = 0;
            txtPrezzoIvato.TabStop = false;
            txtPrezzoIvato.TextAlign = HorizontalAlignment.Right;
            txtPrezzoIvato.TextChanged += txtPrezzoIvato_TextChanged;
            txtPrezzoIvato.KeyPress += txtPrezzoIvato_KeyPress;
            // 
            // lblPrezzoNetto
            // 
            lblPrezzoNetto.AutoSize = true;
            lblPrezzoNetto.Location = new Point(12, 246);
            lblPrezzoNetto.Name = "lblPrezzoNetto";
            lblPrezzoNetto.Size = new Size(95, 15);
            lblPrezzoNetto.TabIndex = 0;
            lblPrezzoNetto.Text = "PREZZO NETTO*";
            // 
            // txtPrezzoNetto
            // 
            txtPrezzoNetto.Location = new Point(12, 263);
            txtPrezzoNetto.Margin = new Padding(3, 2, 3, 2);
            txtPrezzoNetto.Name = "txtPrezzoNetto";
            txtPrezzoNetto.Size = new Size(156, 23);
            txtPrezzoNetto.TabIndex = 3;
            txtPrezzoNetto.TextAlign = HorizontalAlignment.Right;
            txtPrezzoNetto.TextChanged += txtPrezzoNetto_TextChanged;
            txtPrezzoNetto.KeyPress += txtPrezzoNetto_KeyPress;
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
            txtNote.TabIndex = 5;
            txtNote.Enter += txtNote_Enter;
            txtNote.Leave += txtNote_Leave;
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "";
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(12, 11);
            dtpData.Margin = new Padding(3, 2, 3, 2);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(177, 23);
            dtpData.TabIndex = 0;
            dtpData.TabStop = false;
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(12, 107);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(84, 15);
            lblDescrizione.TabIndex = 0;
            lblDescrizione.Text = "DESCRIZIONE*";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(12, 124);
            txtDescrizione.Margin = new Padding(3, 2, 3, 2);
            txtDescrizione.Multiline = true;
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(177, 121);
            txtDescrizione.TabIndex = 2;
            txtDescrizione.TextChanged += txtDescrizione_TextChanged;
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
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 82);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(177, 23);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += txtNome_TextChanged;
            txtMarca.KeyDown += txtNome_KeyDown;
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
            btnDelete.Text = "ELIMINA IL SERVIZIO";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rdbPrezzoNetto
            // 
            rdbPrezzoNetto.AutoSize = true;
            rdbPrezzoNetto.Checked = true;
            rdbPrezzoNetto.Location = new Point(173, 267);
            rdbPrezzoNetto.Margin = new Padding(3, 2, 3, 2);
            rdbPrezzoNetto.Name = "rdbPrezzoNetto";
            rdbPrezzoNetto.Size = new Size(14, 13);
            rdbPrezzoNetto.TabIndex = 11;
            rdbPrezzoNetto.TabStop = true;
            rdbPrezzoNetto.UseVisualStyleBackColor = true;
            rdbPrezzoNetto.CheckedChanged += rdbPrezzoNetto_CheckedChanged;
            // 
            // rdbPrezzoIvato
            // 
            rdbPrezzoIvato.AutoSize = true;
            rdbPrezzoIvato.Location = new Point(173, 309);
            rdbPrezzoIvato.Margin = new Padding(3, 2, 3, 2);
            rdbPrezzoIvato.Name = "rdbPrezzoIvato";
            rdbPrezzoIvato.Size = new Size(14, 13);
            rdbPrezzoIvato.TabIndex = 12;
            rdbPrezzoIvato.UseVisualStyleBackColor = true;
            rdbPrezzoIvato.CheckedChanged += rdbPrezzoIvato_CheckedChanged;
            // 
            // lblPrezzoVendita
            // 
            lblPrezzoVendita.AutoSize = true;
            lblPrezzoVendita.Location = new Point(12, 388);
            lblPrezzoVendita.Name = "lblPrezzoVendita";
            lblPrezzoVendita.Size = new Size(100, 15);
            lblPrezzoVendita.TabIndex = 13;
            lblPrezzoVendita.Text = "PREZZO VENDITA";
            // 
            // txtPrezzoVendita
            // 
            txtPrezzoVendita.Location = new Point(12, 405);
            txtPrezzoVendita.Margin = new Padding(3, 2, 3, 2);
            txtPrezzoVendita.Name = "txtPrezzoVendita";
            txtPrezzoVendita.Size = new Size(177, 23);
            txtPrezzoVendita.TabIndex = 4;
            txtPrezzoVendita.TextAlign = HorizontalAlignment.Right;
            txtPrezzoVendita.TextChanged += txtPrezzoVendita_TextChanged;
            // 
            // lblAliquota
            // 
            lblAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAliquota.AutoSize = true;
            lblAliquota.Location = new Point(863, 38);
            lblAliquota.Name = "lblAliquota";
            lblAliquota.Size = new Size(63, 15);
            lblAliquota.TabIndex = 0;
            lblAliquota.Text = "ALIQUOTA";
            // 
            // nudAliquota
            // 
            nudAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudAliquota.Location = new Point(813, 55);
            nudAliquota.Margin = new Padding(3, 2, 3, 2);
            nudAliquota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAliquota.Name = "nudAliquota";
            nudAliquota.Size = new Size(119, 23);
            nudAliquota.TabIndex = 0;
            nudAliquota.TabStop = false;
            nudAliquota.TextAlign = HorizontalAlignment.Right;
            nudAliquota.Value = new decimal(new int[] { 22, 0, 0, 0 });
            nudAliquota.ValueChanged += nudAliquota_ValueChanged;
            nudAliquota.KeyPress += nudAliquota_KeyPress;
            // 
            // ServiceEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 523);
            Controls.Add(lblPrezzoVendita);
            Controls.Add(txtPrezzoVendita);
            Controls.Add(rdbPrezzoIvato);
            Controls.Add(rdbPrezzoNetto);
            Controls.Add(btnDelete);
            Controls.Add(nudAliquota);
            Controls.Add(lblAliquota);
            Controls.Add(btnOk);
            Controls.Add(lblPrezzoIvato);
            Controls.Add(txtPrezzoIvato);
            Controls.Add(lblPrezzoNetto);
            Controls.Add(txtPrezzoNetto);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(dtpData);
            Controls.Add(lblDescrizione);
            Controls.Add(txtDescrizione);
            Controls.Add(lblNome);
            Controls.Add(txtMarca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
            Name = "ServiceEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MODIFICA SERVIZIO";
            ((System.ComponentModel.ISupportInitialize)nudAliquota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button btnOk;
        private Label lblPrezzoIvato;
        private TextBox txtPrezzoIvato;
        private Label lblPrezzoNetto;
        private TextBox txtPrezzoNetto;
        private Label lblNote;
        private TextBox txtNote;
        private DateTimePicker dtpData;
        private Label lblDescrizione;
        private Label lblNome;
        private TextBox txtMarca;
        private Button btnDelete;
        public TextBox txtDescrizione;
        private RadioButton rdbPrezzoNetto;
        private RadioButton rdbPrezzoIvato;
        private Label lblPrezzoVendita;
        private TextBox txtPrezzoVendita;
        private Label lblAliquota;
        private NumericUpDown nudAliquota;
    }
}