namespace PlannerShop.Forms
{
    partial class ProductPurchaseEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPurchaseEditForm));
            dgvData = new DataGridView();
            grpCliente = new GroupBox();
            lblEmail = new Label();
            lblName = new Label();
            lblTelefono = new Label();
            lblIndirizzo = new Label();
            grpProdotti = new GroupBox();
            searchImage = new PictureBox();
            txtSearch = new TextBox();
            grpAcquisti = new GroupBox();
            dgvDataAcquisto = new DataGridView();
            pnlTop = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            grpCliente.SuspendLayout();
            grpProdotti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            grpAcquisti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataAcquisto).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(15, 184);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(950, 171);
            dgvData.TabIndex = 6;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            dgvData.CellFormatting += dgvDataAcquisto_CellFormatting;
            // 
            // grpCliente
            // 
            grpCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCliente.Controls.Add(lblEmail);
            grpCliente.Controls.Add(lblName);
            grpCliente.Controls.Add(lblTelefono);
            grpCliente.Controls.Add(lblIndirizzo);
            grpCliente.Location = new Point(10, 15);
            grpCliente.Margin = new Padding(3, 2, 3, 2);
            grpCliente.Name = "grpCliente";
            grpCliente.Padding = new Padding(3, 2, 3, 2);
            grpCliente.Size = new Size(962, 106);
            grpCliente.TabIndex = 24;
            grpCliente.TabStop = false;
            grpCliente.Text = "CLIENTE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(6, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 32;
            lblEmail.Text = "EMAIL";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(5, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 19);
            lblName.TabIndex = 29;
            lblName.Text = "NOME";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F);
            lblTelefono.Location = new Point(5, 66);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(76, 19);
            lblTelefono.TabIndex = 31;
            lblTelefono.Text = "TELEFONO";
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIndirizzo.Location = new Point(5, 47);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(80, 19);
            lblIndirizzo.TabIndex = 30;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // grpProdotti
            // 
            grpProdotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpProdotti.Controls.Add(searchImage);
            grpProdotti.Controls.Add(txtSearch);
            grpProdotti.Location = new Point(10, 125);
            grpProdotti.Margin = new Padding(3, 2, 3, 2);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Padding = new Padding(3, 2, 3, 2);
            grpProdotti.Size = new Size(962, 234);
            grpProdotti.TabIndex = 25;
            grpProdotti.TabStop = false;
            grpProdotti.Text = "PRODOTTI";
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(5, 19);
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
            txtSearch.Location = new Point(5, 20);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(949, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // grpAcquisti
            // 
            grpAcquisti.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAcquisti.Controls.Add(dgvDataAcquisto);
            grpAcquisti.Location = new Point(10, 363);
            grpAcquisti.Margin = new Padding(3, 2, 3, 2);
            grpAcquisti.Name = "grpAcquisti";
            grpAcquisti.Padding = new Padding(3, 2, 3, 2);
            grpAcquisti.Size = new Size(962, 189);
            grpAcquisti.TabIndex = 25;
            grpAcquisti.TabStop = false;
            grpAcquisti.Text = "ACQUISTI";
            // 
            // dgvDataAcquisto
            // 
            dgvDataAcquisto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDataAcquisto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataAcquisto.Location = new Point(5, 20);
            dgvDataAcquisto.Margin = new Padding(3, 2, 3, 2);
            dgvDataAcquisto.Name = "dgvDataAcquisto";
            dgvDataAcquisto.RowHeadersWidth = 51;
            dgvDataAcquisto.Size = new Size(952, 164);
            dgvDataAcquisto.TabIndex = 7;
            dgvDataAcquisto.CellDoubleClick += dgvDataAcquisto_CellDoubleClick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(984, 10);
            pnlTop.TabIndex = 26;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(10, 563);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 68);
            btnCancel.TabIndex = 27;
            btnCancel.TabStop = false;
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
            btnOk.Location = new Point(204, 563);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(768, 68);
            btnOk.TabIndex = 28;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ProductPurchaseEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 641);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(pnlTop);
            Controls.Add(grpAcquisti);
            Controls.Add(grpCliente);
            Controls.Add(dgvData);
            Controls.Add(grpProdotti);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(970, 680);
            Name = "ProductPurchaseEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTIONE ACQUISTI";
            KeyPress += PurchaseEditForm_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpProdotti.ResumeLayout(false);
            grpProdotti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            grpAcquisti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataAcquisto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private GroupBox grpCliente;
        private GroupBox grpProdotti;
        private GroupBox grpAcquisti;
        private DataGridView dgvDataAcquisto;
        private Panel pnlTop;
        private Button btnCancel;
        private Button btnOk;
        private PictureBox searchImage;
        private TextBox txtSearch;
        private Label lblEmail;
        private Label lblName;
        private Label lblTelefono;
        private Label lblIndirizzo;
    }
}