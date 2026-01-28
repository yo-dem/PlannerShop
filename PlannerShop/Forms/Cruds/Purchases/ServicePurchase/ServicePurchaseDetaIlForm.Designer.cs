namespace PlannerShop.Forms
{
    partial class ServicePurchaseDetaIlForm
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
            grpPurchaseDetail = new GroupBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblIndirizzo = new Label();
            lblName = new Label();
            groupBox1 = new GroupBox();
            lblCustomPrice = new Label();
            txtCustomPrice = new TextBox();
            nudSconto = new NumericUpDown();
            lblTotaleCalcolato = new Label();
            lblTotale = new Label();
            groupBox2 = new GroupBox();
            lblPrezzoVendita = new Label();
            lblDescrizione = new Label();
            lblNome = new Label();
            grpPurchaseDetail.SuspendLayout();
            groupBox1.SuspendLayout();
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
            lblSconto.Location = new Point(6, 19);
            lblSconto.Name = "lblSconto";
            lblSconto.Size = new Size(57, 15);
            lblSconto.TabIndex = 0;
            lblSconto.Text = "Sconto %";
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
            groupBox1.Controls.Add(lblCustomPrice);
            groupBox1.Controls.Add(txtCustomPrice);
            groupBox1.Controls.Add(nudSconto);
            groupBox1.Controls.Add(lblTotaleCalcolato);
            groupBox1.Controls.Add(lblTotale);
            groupBox1.Controls.Add(lblSconto);
            groupBox1.Location = new Point(450, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblCustomPrice
            // 
            lblCustomPrice.AutoSize = true;
            lblCustomPrice.Location = new Point(6, 79);
            lblCustomPrice.Name = "lblCustomPrice";
            lblCustomPrice.Size = new Size(74, 15);
            lblCustomPrice.TabIndex = 6;
            lblCustomPrice.Text = "Prezzo libero";
            // 
            // txtCustomPrice
            // 
            txtCustomPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomPrice.Location = new Point(6, 96);
            txtCustomPrice.Name = "txtCustomPrice";
            txtCustomPrice.ReadOnly = true;
            txtCustomPrice.Size = new Size(204, 33);
            txtCustomPrice.TabIndex = 5;
            txtCustomPrice.Click += txtCustomPrice_Click;
            txtCustomPrice.TextChanged += txtCustomPrice_TextChanged;
            txtCustomPrice.KeyPress += txtCustomPrice_KeyPress;
            // 
            // nudSconto
            // 
            nudSconto.Font = new Font("Segoe UI", 18F);
            nudSconto.Location = new Point(6, 37);
            nudSconto.Name = "nudSconto";
            nudSconto.Size = new Size(204, 39);
            nudSconto.TabIndex = 2;
            nudSconto.ValueChanged += nudSconto_ValueChanged;
            nudSconto.Click += nudSconto_Click;
            nudSconto.KeyUp += nudSconto_KeyUp;
            nudSconto.Leave += nudSconto_Leave;
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
            groupBox2.Controls.Add(lblNome);
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "MARCA";
            // 
            // ServicePurchaseDetaIlForm
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
            Name = "ServicePurchaseDetaIlForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTIONE ACQUISTI - DETTAGLIO";
            grpPurchaseDetail.ResumeLayout(false);
            grpPurchaseDetail.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox grpPurchaseDetail;
        private GroupBox groupBox1;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblIndirizzo;
        private Label lblName;
        private GroupBox groupBox2;
        private Label lblDescrizione;
        private Label lblNome;
        private Label lblTotale;
        public NumericUpDown nudQnt;
        private NumericUpDown nudSconto;
        public Label lblTotaleCalcolato;
        private Label lblPrezzoVendita;
        private Label lblCustomPrice;
        private TextBox txtCustomPrice;
    }
}