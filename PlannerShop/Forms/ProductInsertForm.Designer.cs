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
            ((System.ComponentModel.ISupportInitialize)nudQnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAliquota).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(14, 87);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(66, 20);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "MARCA*";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(14, 109);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(202, 27);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += TxtMarca_TextChanged;
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Location = new Point(14, 143);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(107, 20);
            lblDescrizione.TabIndex = 0;
            lblDescrizione.Text = "DESCRIZIONE*";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(14, 165);
            txtDescrizione.Multiline = true;
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(202, 160);
            txtDescrizione.TabIndex = 2;
            txtDescrizione.TextChanged += TxtDescrizione_TextChanged;
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "";
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(14, 15);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(202, 27);
            dtpData.TabIndex = 0;
            dtpData.TabStop = false;
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
            txtNote.TabIndex = 9;
            // 
            // lblPrezzoNetto
            // 
            lblPrezzoNetto.AutoSize = true;
            lblPrezzoNetto.Location = new Point(14, 328);
            lblPrezzoNetto.Name = "lblPrezzoNetto";
            lblPrezzoNetto.Size = new Size(118, 20);
            lblPrezzoNetto.TabIndex = 0;
            lblPrezzoNetto.Text = "PREZZO NETTO*";
            // 
            // txtPrezzoNetto
            // 
            txtPrezzoNetto.Location = new Point(14, 351);
            txtPrezzoNetto.Name = "txtPrezzoNetto";
            txtPrezzoNetto.Size = new Size(180, 27);
            txtPrezzoNetto.TabIndex = 5;
            txtPrezzoNetto.TextAlign = HorizontalAlignment.Right;
            txtPrezzoNetto.TextChanged += txtPrezzoNetto_TextChanged;
            txtPrezzoNetto.KeyPress += txtPrezzoNetto_KeyPress;
            // 
            // lblPrezzoIvato
            // 
            lblPrezzoIvato.AutoSize = true;
            lblPrezzoIvato.Location = new Point(14, 384);
            lblPrezzoIvato.Name = "lblPrezzoIvato";
            lblPrezzoIvato.Size = new Size(112, 20);
            lblPrezzoIvato.TabIndex = 0;
            lblPrezzoIvato.Text = "PREZZO IVATO*";
            // 
            // txtPrezzoIvato
            // 
            txtPrezzoIvato.Location = new Point(14, 407);
            txtPrezzoIvato.Name = "txtPrezzoIvato";
            txtPrezzoIvato.Size = new Size(180, 27);
            txtPrezzoIvato.TabIndex = 0;
            txtPrezzoIvato.TabStop = false;
            txtPrezzoIvato.TextAlign = HorizontalAlignment.Right;
            txtPrezzoIvato.TextChanged += txtPrezzoIvato_TextChanged;
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
            chkRipeti.Location = new Point(703, 12);
            chkRipeti.Name = "chkRipeti";
            chkRipeti.Size = new Size(170, 24);
            chkRipeti.TabIndex = 0;
            chkRipeti.TabStop = false;
            chkRipeti.Text = "RIPETI INSERIMENTO";
            chkRipeti.UseVisualStyleBackColor = true;
            // 
            // lblQnt
            // 
            lblQnt.AutoSize = true;
            lblQnt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblQnt.Location = new Point(787, 53);
            lblQnt.Name = "lblQnt";
            lblQnt.Size = new Size(83, 20);
            lblQnt.TabIndex = 0;
            lblQnt.Text = "QUANTITA'";
            // 
            // nudQnt
            // 
            nudQnt.Location = new Point(734, 76);
            nudQnt.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudQnt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQnt.Name = "nudQnt";
            nudQnt.Size = new Size(136, 27);
            nudQnt.TabIndex = 0;
            nudQnt.TabStop = false;
            nudQnt.TextAlign = HorizontalAlignment.Right;
            nudQnt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAliquota
            // 
            lblAliquota.AutoSize = true;
            lblAliquota.Location = new Point(650, 53);
            lblAliquota.Name = "lblAliquota";
            lblAliquota.Size = new Size(78, 20);
            lblAliquota.TabIndex = 0;
            lblAliquota.Text = "ALIQUOTA";
            // 
            // nudAliquota
            // 
            nudAliquota.Location = new Point(592, 76);
            nudAliquota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAliquota.Name = "nudAliquota";
            nudAliquota.Size = new Size(136, 27);
            nudAliquota.TabIndex = 0;
            nudAliquota.TabStop = false;
            nudAliquota.TextAlign = HorizontalAlignment.Right;
            nudAliquota.Value = new decimal(new int[] { 22, 0, 0, 0 });
            nudAliquota.KeyPress += nudAliquota_KeyPress;
            // 
            // rdbPrezzoIvato
            // 
            rdbPrezzoIvato.AutoSize = true;
            rdbPrezzoIvato.Location = new Point(200, 412);
            rdbPrezzoIvato.Name = "rdbPrezzoIvato";
            rdbPrezzoIvato.Size = new Size(17, 16);
            rdbPrezzoIvato.TabIndex = 14;
            rdbPrezzoIvato.UseVisualStyleBackColor = true;
            rdbPrezzoIvato.CheckedChanged += rdbPrezzoIvato_CheckedChanged;
            // 
            // rdbPrezzoNetto
            // 
            rdbPrezzoNetto.AutoSize = true;
            rdbPrezzoNetto.Checked = true;
            rdbPrezzoNetto.Location = new Point(200, 356);
            rdbPrezzoNetto.Name = "rdbPrezzoNetto";
            rdbPrezzoNetto.Size = new Size(17, 16);
            rdbPrezzoNetto.TabIndex = 13;
            rdbPrezzoNetto.TabStop = true;
            rdbPrezzoNetto.UseVisualStyleBackColor = true;
            rdbPrezzoNetto.CheckedChanged += rdbPrezzoNetto_CheckedChanged;
            // 
            // ProductInsertForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 548);
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
            MinimumSize = new Size(903, 595);
            Name = "ProductInsertForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "INSERIMENTO PRODOTTO";
            WindowState = FormWindowState.Maximized;
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
    }
}