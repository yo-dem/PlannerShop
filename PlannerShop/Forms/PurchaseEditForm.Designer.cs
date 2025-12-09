namespace PlannerShop.Forms
{
    partial class PurchaseEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseEditForm));
            dgvData = new DataGridView();
            searchImage = new PictureBox();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            grpCliente = new GroupBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblIndirizzo = new Label();
            lblName = new Label();
            grpProdotti = new GroupBox();
            grpAcquisti = new GroupBox();
            dgvDataAcquisto = new DataGridView();
            pnlTop = new Panel();
            btnCancel = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            pnlSearch.SuspendLayout();
            grpCliente.SuspendLayout();
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
            dgvData.Size = new Size(914, 170);
            dgvData.TabIndex = 6;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
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
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(searchImage);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(15, 145);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(914, 34);
            pnlSearch.TabIndex = 23;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Corbel", 14F);
            txtSearch.Location = new Point(38, 5);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(872, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            grpCliente.TabIndex = 24;
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
            // grpProdotti
            // 
            grpProdotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpProdotti.Location = new Point(10, 125);
            grpProdotti.Margin = new Padding(3, 2, 3, 2);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Padding = new Padding(3, 2, 3, 2);
            grpProdotti.Size = new Size(926, 233);
            grpProdotti.TabIndex = 25;
            grpProdotti.TabStop = false;
            grpProdotti.Text = "PRODOTTI";
            // 
            // grpAcquisti
            // 
            grpAcquisti.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAcquisti.Controls.Add(dgvDataAcquisto);
            grpAcquisti.Location = new Point(10, 362);
            grpAcquisti.Margin = new Padding(3, 2, 3, 2);
            grpAcquisti.Name = "grpAcquisti";
            grpAcquisti.Padding = new Padding(3, 2, 3, 2);
            grpAcquisti.Size = new Size(926, 189);
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
            dgvDataAcquisto.Size = new Size(916, 164);
            dgvDataAcquisto.TabIndex = 7;
            dgvDataAcquisto.CellDoubleClick += dgvDataAcquisto_CellDoubleClick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(948, 10);
            pnlTop.TabIndex = 26;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(12, 562);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(186, 68);
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
            btnOk.Location = new Point(204, 562);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(732, 68);
            btnOk.TabIndex = 28;
            btnOk.Text = "SALVA MODIFICHE";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // PurchaseEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 640);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(pnlTop);
            Controls.Add(grpAcquisti);
            Controls.Add(grpCliente);
            Controls.Add(pnlSearch);
            Controls.Add(dgvData);
            Controls.Add(grpProdotti);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 562);
            Name = "PurchaseEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTIONE ACQUISTI";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpAcquisti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataAcquisto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private PictureBox searchImage;
        private Panel pnlSearch;
        private TextBox txtSearch;
        private GroupBox grpCliente;
        private GroupBox grpProdotti;
        private GroupBox grpAcquisti;
        private DataGridView dgvDataAcquisto;
        private Label lblName;
        private Label lblIndirizzo;
        private Label lblTelefono;
        private Label lblEmail;
        private Panel pnlTop;
        private Button btnCancel;
        private Button btnOk;
    }
}