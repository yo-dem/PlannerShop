namespace PlannerShop.Forms
{
    partial class ProductPurchaseClientEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPurchaseClientEditForm));
            pnlTop = new Panel();
            grpCliente = new GroupBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblIndirizzo = new Label();
            lblName = new Label();
            grpAcquisti = new GroupBox();
            pnlSearch = new Panel();
            searchImage = new PictureBox();
            txtSearch = new TextBox();
            dgvDataAcquisto = new DataGridView();
            grpCliente.SuspendLayout();
            grpAcquisti.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataAcquisto).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(948, 10);
            pnlTop.TabIndex = 27;
            // 
            // grpCliente
            // 
            grpCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCliente.Controls.Add(lblEmail);
            grpCliente.Controls.Add(lblTelefono);
            grpCliente.Controls.Add(lblIndirizzo);
            grpCliente.Controls.Add(lblName);
            grpCliente.Location = new Point(10, 15);
            grpCliente.Margin = new Padding(3, 2, 3, 2);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(3, 2, 3, 2);
            grpCliente.Size = new Size(926, 106);
            grpCliente.TabIndex = 28;
            grpCliente.TabStop = false;
            grpCliente.Text = "CLIENTE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(6, 46);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "TELEFONO";
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblIndirizzo.Location = new Point(6, 33);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(62, 13);
            lblIndirizzo.TabIndex = 2;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "NOME";
            // 
            // grpAcquisti
            // 
            grpAcquisti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAcquisti.Controls.Add(pnlSearch);
            grpAcquisti.Controls.Add(dgvDataAcquisto);
            grpAcquisti.Location = new Point(10, 125);
            grpAcquisti.Margin = new Padding(3, 2, 3, 2);
            grpAcquisti.Name = "grpAcquisti";
            grpAcquisti.Padding = new Padding(3, 2, 3, 2);
            grpAcquisti.Size = new Size(926, 428);
            grpAcquisti.TabIndex = 29;
            grpAcquisti.TabStop = false;
            grpAcquisti.Text = "ACQUISTI";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(searchImage);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(6, 21);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(914, 34);
            pnlSearch.TabIndex = 24;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(7, 4);
            searchImage.Margin = new Padding(3, 2, 3, 2);
            searchImage.Name = "searchImage";
            searchImage.Size = new Size(24, 24);
            searchImage.SizeMode = PictureBoxSizeMode.AutoSize;
            searchImage.TabIndex = 22;
            searchImage.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Corbel", 14F);
            txtSearch.Location = new Point(37, 5);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(872, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvDataAcquisto
            // 
            dgvDataAcquisto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDataAcquisto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataAcquisto.Location = new Point(6, 60);
            dgvDataAcquisto.Margin = new Padding(3, 2, 3, 2);
            dgvDataAcquisto.Name = "dgvDataAcquisto";
            dgvDataAcquisto.RowHeadersWidth = 51;
            dgvDataAcquisto.Size = new Size(914, 364);
            dgvDataAcquisto.TabIndex = 7;
            // 
            // PurchaseClientEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 640);
            Controls.Add(grpAcquisti);
            Controls.Add(grpCliente);
            Controls.Add(pnlTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(964, 679);
            Name = "PurchaseClientEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ACQUISTI CLIENTE";
            WindowState = FormWindowState.Maximized;
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpAcquisti.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataAcquisto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private GroupBox grpCliente;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblIndirizzo;
        private Label lblName;
        private GroupBox grpAcquisti;
        private DataGridView dgvDataAcquisto;
        private Panel pnlSearch;
        private PictureBox searchImage;
        private TextBox txtSearch;
    }
}