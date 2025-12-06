namespace PlannerShop.Forms
{
    partial class ProductInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInsertForm));
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblDescrizione = new Label();
            txtDescrizione = new TextBox();
            dtpData = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            lblPrezzoNetto = new Label();
            txtPrezzoNetto = new TextBox();
            lblPrezzoIvato = new Label();
            txtPrezzoIvato = new TextBox();
            btnOk = new Button();
            chkRipeti = new CheckBox();
            lblQnt = new Label();
            nudQnt = new NumericUpDown();
            lblAliquota = new Label();
            nudAliquota = new NumericUpDown();
            rdbPrezzoIvato = new RadioButton();
            rdbPrezzoNetto = new RadioButton();
            lblPrezzoVendita = new Label();
            txtPrezzoVendita = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudQnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAliquota).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 65);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(54, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "MARCA*";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 82);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(177, 23);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += TxtMarca_TextChanged;
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
            txtDescrizione.TextChanged += TxtDescrizione_TextChanged;
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
            txtNote.Size = new Size(737, 345);
            txtNote.TabIndex = 5;
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
            txtPrezzoNetto.Size = new Size(158, 23);
            txtPrezzoNetto.TabIndex = 3;
            txtPrezzoNetto.TextAlign = HorizontalAlignment.Right;
            txtPrezzoNetto.TextChanged += txtPrezzoNetto_TextChanged;
            txtPrezzoNetto.KeyPress += txtPrezzoNetto_KeyPress;
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
            txtPrezzoIvato.Size = new Size(158, 23);
            txtPrezzoIvato.TabIndex = 0;
            txtPrezzoIvato.TabStop = false;
            txtPrezzoIvato.TextAlign = HorizontalAlignment.Right;
            txtPrezzoIvato.TextChanged += txtPrezzoIvato_TextChanged;
            txtPrezzoIvato.KeyPress += txtPrezzoIvato_KeyPress;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(12, 431);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(920, 68);
            btnOk.TabIndex = 6;
            btnOk.Text = "CARICA PRODOTTO";
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
            chkRipeti.Location = new Point(799, 9);
            chkRipeti.Margin = new Padding(3, 2, 3, 2);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(137, 19);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
            // 
            // lblQnt
            // 
            lblQnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQnt.AutoSize = true;
            lblQnt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblQnt.Location = new Point(859, 40);
            lblQnt.Name = "lblQnt";
            lblQnt.Size = new Size(68, 15);
            lblQnt.TabIndex = 0;
            lblQnt.Text = "QUANTITA'";
            // 
            // nudQnt
            // 
            nudQnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudQnt.Location = new Point(813, 57);
            nudQnt.Margin = new Padding(3, 2, 3, 2);
            nudQnt.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudQnt.Name = "nudQnt";
            nudQnt.Size = new Size(119, 23);
            nudQnt.TabIndex = 0;
            nudQnt.TabStop = false;
            nudQnt.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAliquota
            // 
            lblAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAliquota.AutoSize = true;
            lblAliquota.Location = new Point(739, 40);
            lblAliquota.Name = "lblAliquota";
            lblAliquota.Size = new Size(63, 15);
            lblAliquota.TabIndex = 0;
            lblAliquota.Text = "ALIQUOTA";
            // 
            // nudAliquota
            // 
            nudAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudAliquota.Location = new Point(689, 57);
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
            // rdbPrezzoIvato
            // 
            rdbPrezzoIvato.AutoSize = true;
            rdbPrezzoIvato.Location = new Point(175, 309);
            rdbPrezzoIvato.Margin = new Padding(3, 2, 3, 2);
            rdbPrezzoIvato.Name = "rdbPrezzoIvato";
            rdbPrezzoIvato.Size = new Size(14, 13);
            rdbPrezzoIvato.TabIndex = 14;
            rdbPrezzoIvato.UseVisualStyleBackColor = true;
            rdbPrezzoIvato.CheckedChanged += rdbPrezzoIvato_CheckedChanged;
            // 
            // rdbPrezzoNetto
            // 
            rdbPrezzoNetto.AutoSize = true;
            rdbPrezzoNetto.Checked = true;
            rdbPrezzoNetto.Location = new Point(175, 267);
            rdbPrezzoNetto.Margin = new Padding(3, 2, 3, 2);
            rdbPrezzoNetto.Name = "rdbPrezzoNetto";
            rdbPrezzoNetto.Size = new Size(14, 13);
            rdbPrezzoNetto.TabIndex = 13;
            rdbPrezzoNetto.TabStop = true;
            rdbPrezzoNetto.UseVisualStyleBackColor = true;
            rdbPrezzoNetto.CheckedChanged += rdbPrezzoNetto_CheckedChanged;
            // 
            // lblPrezzoVendita
            // 
            lblPrezzoVendita.AutoSize = true;
            lblPrezzoVendita.Location = new Point(12, 387);
            lblPrezzoVendita.Name = "lblPrezzoVendita";
            lblPrezzoVendita.Size = new Size(105, 15);
            lblPrezzoVendita.TabIndex = 15;
            lblPrezzoVendita.Text = "PREZZO VENDITA*";
            // 
            // txtPrezzoVendita
            // 
            txtPrezzoVendita.Location = new Point(12, 404);
            txtPrezzoVendita.Margin = new Padding(3, 2, 3, 2);
            txtPrezzoVendita.Name = "txtPrezzoVendita";
            txtPrezzoVendita.Size = new Size(177, 23);
            txtPrezzoVendita.TabIndex = 4;
            txtPrezzoVendita.TextAlign = HorizontalAlignment.Right;
            txtPrezzoVendita.TextChanged += txtPrezzoVendita_TextChanged;
            // 
            // ProductInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 523);
            Controls.Add(lblPrezzoVendita);
            Controls.Add(txtPrezzoVendita);
            Controls.Add(rdbPrezzoIvato);
            Controls.Add(rdbPrezzoNetto);
            Controls.Add(nudAliquota);
            Controls.Add(lblAliquota);
            Controls.Add(nudQnt);
            Controls.Add(lblQnt);
            Controls.Add(chkRipeti);
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
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
            Name = "ProductInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO PRODOTTO";
            ((System.ComponentModel.ISupportInitialize)nudQnt).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAliquota).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblDescrizione;
        private TextBox txtDescrizione;
        private DateTimePicker dtpData;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblPrezzoNetto;
        private TextBox txtPrezzoNetto;
        private Label lblPrezzoIvato;
        private TextBox txtPrezzoIvato;
        private Button btnOk;
        private CheckBox chkRipeti;
        private Label lblQnt;
        private NumericUpDown nudQnt;
        private Label lblAliquota;
        private NumericUpDown nudAliquota;
        private RadioButton rdbPrezzoIvato;
        private RadioButton rdbPrezzoNetto;
        private Label lblPrezzoVendita;
        private TextBox txtPrezzoVendita;
    }
}