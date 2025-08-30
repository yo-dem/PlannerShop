namespace PlannerShop.Forms
{
    partial class ProductEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditForm));
            nudAliquota = new NumericUpDown();
            lblAliquota = new Label();
            nudQnt = new NumericUpDown();
            lblQnt = new Label();
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
            lblMarca = new Label();
            txtMarca = new TextBox();
            btnDelete = new Button();
            rdbPrezzoNetto = new RadioButton();
            rdbPrezzoIvato = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nudAliquota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQnt).BeginInit();
            SuspendLayout();
            // 
            // nudAliquota
            // 
            nudAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // lblAliquota
            // 
            lblAliquota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAliquota.AutoSize = true;
            lblAliquota.Location = new Point(650, 53);
            lblAliquota.Name = "lblAliquota";
            lblAliquota.Size = new Size(78, 20);
            lblAliquota.TabIndex = 0;
            lblAliquota.Text = "ALIQUOTA";
            // 
            // nudQnt
            // 
            nudQnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // lblQnt
            // 
            lblQnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQnt.AutoSize = true;
            lblQnt.Location = new Point(787, 53);
            lblQnt.Name = "lblQnt";
            lblQnt.Size = new Size(83, 20);
            lblQnt.TabIndex = 0;
            lblQnt.Text = "QUANTITA'";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(222, 443);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(649, 91);
            btnOk.TabIndex = 10;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
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
            txtPrezzoIvato.Size = new Size(178, 27);
            txtPrezzoIvato.TabIndex = 0;
            txtPrezzoIvato.TabStop = false;
            txtPrezzoIvato.TextAlign = HorizontalAlignment.Right;
            txtPrezzoIvato.TextChanged += txtPrezzoIvato_TextChanged;
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
            txtPrezzoNetto.Size = new Size(178, 27);
            txtPrezzoNetto.TabIndex = 5;
            txtPrezzoNetto.TextAlign = HorizontalAlignment.Right;
            txtPrezzoNetto.TextChanged += txtPrezzoNetto_TextChanged;
            txtPrezzoNetto.KeyPress += txtPrezzoNetto_KeyPress;
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
            txtDescrizione.TextChanged += txtDescrizione_TextChanged;
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
            txtMarca.TextChanged += txtMarca_TextChanged;
            txtMarca.KeyDown += txtMarca_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = Properties.Resources.trashImage;
            btnDelete.Location = new Point(14, 443);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 91);
            btnDelete.TabIndex = 0;
            btnDelete.TabStop = false;
            btnDelete.Text = "ELIMINA IL PRODOTTO";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rdbPrezzoNetto
            // 
            rdbPrezzoNetto.AutoSize = true;
            rdbPrezzoNetto.Checked = true;
            rdbPrezzoNetto.Location = new Point(198, 356);
            rdbPrezzoNetto.Name = "rdbPrezzoNetto";
            rdbPrezzoNetto.Size = new Size(17, 16);
            rdbPrezzoNetto.TabIndex = 11;
            rdbPrezzoNetto.TabStop = true;
            rdbPrezzoNetto.UseVisualStyleBackColor = true;
            rdbPrezzoNetto.CheckedChanged += rdbPrezzoNetto_CheckedChanged;
            // 
            // rdbPrezzoIvato
            // 
            rdbPrezzoIvato.AutoSize = true;
            rdbPrezzoIvato.Location = new Point(198, 412);
            rdbPrezzoIvato.Name = "rdbPrezzoIvato";
            rdbPrezzoIvato.Size = new Size(17, 16);
            rdbPrezzoIvato.TabIndex = 12;
            rdbPrezzoIvato.UseVisualStyleBackColor = true;
            rdbPrezzoIvato.CheckedChanged += rdbPrezzoIvato_CheckedChanged;
            // 
            // ProductEditForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 548);
            Controls.Add(rdbPrezzoIvato);
            Controls.Add(rdbPrezzoNetto);
            Controls.Add(btnDelete);
            Controls.Add(nudAliquota);
            Controls.Add(lblAliquota);
            Controls.Add(nudQnt);
            Controls.Add(lblQnt);
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
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MODIFICA PRODOTTO";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudAliquota).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQnt).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown nudAliquota;
        private Label lblAliquota;
        private NumericUpDown nudQnt;
        private Label lblQnt;
        private Button btnOk;
        private Label lblPrezzoIvato;
        private TextBox txtPrezzoIvato;
        private Label lblPrezzoNetto;
        private TextBox txtPrezzoNetto;
        private Label lblNote;
        private TextBox txtNote;
        private DateTimePicker dtpData;
        private Label lblDescrizione;
        private Label lblMarca;
        private TextBox txtMarca;
        private Button btnDelete;
        public TextBox txtDescrizione;
        private RadioButton rdbPrezzoNetto;
        private RadioButton rdbPrezzoIvato;
    }
}