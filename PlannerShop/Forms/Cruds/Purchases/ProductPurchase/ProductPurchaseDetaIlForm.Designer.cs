namespace PlannerShop.Forms
{
    partial class ProductPurchaseDetaIlForm
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
            pnlTop = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            lblSconto = new Label();
            lblQnt = new Label();
            grpPurchaseDetail = new GroupBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblIndirizzo = new Label();
            lblName = new Label();
            groupBox1 = new GroupBox();
            nudQnt = new NumericUpDown();
            nudSconto = new NumericUpDown();
            lblTotaleCalcolato = new Label();
            lblTotale = new Label();
            groupBox2 = new GroupBox();
            lblPrezzoVendita = new Label();
            lblDescrizione = new Label();
            lblMarca = new Label();
            grpPurchaseDetail.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQnt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSconto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(678, 10);
            pnlTop.TabIndex = 27;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(12, 302);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(432, 68);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "ANNULLA";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(450, 302);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(216, 68);
            btnOk.TabIndex = 3;
            btnOk.Text = "COMPLETA ACQUISTO";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblSconto
            // 
            lblSconto.AutoSize = true;
            lblSconto.Location = new Point(6, 79);
            lblSconto.Name = "lblSconto";
            lblSconto.Size = new Size(57, 15);
            lblSconto.TabIndex = 0;
            lblSconto.Text = "Sconto %";
            // 
            // lblQnt
            // 
            lblQnt.AutoSize = true;
            lblQnt.Location = new Point(6, 19);
            lblQnt.Name = "lblQnt";
            lblQnt.Size = new Size(53, 15);
            lblQnt.TabIndex = 0;
            lblQnt.Text = "Quantità";
            // 
            // grpPurchaseDetail
            // 
            grpPurchaseDetail.Controls.Add(lblEmail);
            grpPurchaseDetail.Controls.Add(lblTelefono);
            grpPurchaseDetail.Controls.Add(lblIndirizzo);
            grpPurchaseDetail.Controls.Add(lblName);
            grpPurchaseDetail.Location = new Point(12, 16);
            grpPurchaseDetail.Name = "grpPurchaseDetail";
            grpPurchaseDetail.Size = new Size(432, 138);
            grpPurchaseDetail.TabIndex = 0;
            grpPurchaseDetail.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(6, 64);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 15);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "TELEFONO";
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblIndirizzo.Location = new Point(6, 49);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(62, 13);
            lblIndirizzo.TabIndex = 0;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "NOME";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudQnt);
            groupBox1.Controls.Add(nudSconto);
            groupBox1.Controls.Add(lblTotaleCalcolato);
            groupBox1.Controls.Add(lblTotale);
            groupBox1.Controls.Add(lblSconto);
            groupBox1.Controls.Add(lblQnt);
            groupBox1.Location = new Point(450, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // nudQnt
            // 
            nudQnt.Font = new Font("Segoe UI", 18F);
            nudQnt.Location = new Point(6, 37);
            nudQnt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQnt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQnt.Name = "nudQnt";
            nudQnt.Size = new Size(204, 39);
            nudQnt.TabIndex = 1;
            nudQnt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQnt.ValueChanged += nudQnt_ValueChanged;
            nudQnt.KeyUp += nudQnt_KeyUp;
            // 
            // nudSconto
            // 
            nudSconto.Font = new Font("Segoe UI", 18F);
            nudSconto.Location = new Point(6, 97);
            nudSconto.Name = "nudSconto";
            nudSconto.Size = new Size(204, 39);
            nudSconto.TabIndex = 2;
            nudSconto.ValueChanged += nudSconto_ValueChanged;
            nudSconto.KeyUp += nudSconto_KeyUp;
            // 
            // lblTotaleCalcolato
            // 
            lblTotaleCalcolato.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotaleCalcolato.Location = new Point(6, 235);
            lblTotaleCalcolato.Name = "lblTotaleCalcolato";
            lblTotaleCalcolato.Size = new Size(204, 34);
            lblTotaleCalcolato.TabIndex = 0;
            lblTotaleCalcolato.Text = "TOTALE";
            lblTotaleCalcolato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotale
            // 
            lblTotale.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotale.Location = new Point(6, 201);
            lblTotale.Name = "lblTotale";
            lblTotale.Size = new Size(204, 34);
            lblTotale.TabIndex = 0;
            lblTotale.Text = "TOTALE";
            lblTotale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPrezzoVendita);
            groupBox2.Controls.Add(lblDescrizione);
            groupBox2.Controls.Add(lblMarca);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 137);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // lblPrezzoVendita
            // 
            lblPrezzoVendita.AutoSize = true;
            lblPrezzoVendita.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrezzoVendita.Location = new Point(6, 61);
            lblPrezzoVendita.Name = "lblPrezzoVendita";
            lblPrezzoVendita.Size = new Size(165, 21);
            lblPrezzoVendita.TabIndex = 0;
            lblPrezzoVendita.Text = "PREZZO DI VENDITA";
            // 
            // lblDescrizione
            // 
            lblDescrizione.AutoSize = true;
            lblDescrizione.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescrizione.Location = new Point(6, 40);
            lblDescrizione.Name = "lblDescrizione";
            lblDescrizione.Size = new Size(114, 21);
            lblDescrizione.TabIndex = 0;
            lblDescrizione.Text = "DESCRIZIONE";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(6, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(67, 21);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "MARCA";
            // 
            // PurchaseDetaIlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 381);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpPurchaseDetail);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PurchaseDetaIlForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTIONE ACQUISTI - DETTAGLIO";
            grpPurchaseDetail.ResumeLayout(false);
            grpPurchaseDetail.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQnt).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSconto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnCancel;
        private Button btnOk;
        private Label lblSconto;
        private Label lblQnt;
        private GroupBox grpPurchaseDetail;
        private GroupBox groupBox1;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblIndirizzo;
        private Label lblName;
        private GroupBox groupBox2;
        private Label lblDescrizione;
        private Label lblMarca;
        private Label lblTotale;
        public NumericUpDown nudQnt;
        private NumericUpDown nudSconto;
        public Label lblTotaleCalcolato;
        private Label lblPrezzoVendita;
    }
}