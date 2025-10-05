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
            dgvData.Location = new Point(17, 245);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1046, 181);
            dgvData.TabIndex = 6;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(8, 11);
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
            pnlSearch.Location = new Point(17, 193);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1045, 45);
            pnlSearch.TabIndex = 23;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Corbel", 14F);
            txtSearch.Location = new Point(43, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(997, 29);
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
            grpCliente.Location = new Point(17, 20);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(1053, 141);
            grpCliente.TabIndex = 24;
            grpCliente.TabStop = false;
            grpCliente.Text = "CLIENTE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 113);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(6, 93);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(138, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "TELEFONO_MOBILE";
            // 
            // lblIndirizzo
            // 
            lblIndirizzo.AutoSize = true;
            lblIndirizzo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblIndirizzo.Location = new Point(6, 73);
            lblIndirizzo.Name = "lblIndirizzo";
            lblIndirizzo.Size = new Size(80, 19);
            lblIndirizzo.TabIndex = 2;
            lblIndirizzo.Text = "INDIRIZZO";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "NOME";
            // 
            // grpProdotti
            // 
            grpProdotti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpProdotti.Location = new Point(11, 167);
            grpProdotti.Name = "grpProdotti";
            grpProdotti.Size = new Size(1059, 265);
            grpProdotti.TabIndex = 25;
            grpProdotti.TabStop = false;
            grpProdotti.Text = "PRODOTTI";
            // 
            // grpAcquisti
            // 
            grpAcquisti.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAcquisti.Controls.Add(dgvDataAcquisto);
            grpAcquisti.Location = new Point(11, 438);
            grpAcquisti.Name = "grpAcquisti";
            grpAcquisti.Size = new Size(1059, 230);
            grpAcquisti.TabIndex = 25;
            grpAcquisti.TabStop = false;
            grpAcquisti.Text = "ACQUISTI";
            // 
            // dgvDataAcquisto
            // 
            dgvDataAcquisto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDataAcquisto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataAcquisto.Location = new Point(6, 27);
            dgvDataAcquisto.Name = "dgvDataAcquisto";
            dgvDataAcquisto.RowHeadersWidth = 51;
            dgvDataAcquisto.Size = new Size(1048, 198);
            dgvDataAcquisto.TabIndex = 7;
            dgvDataAcquisto.CellDoubleClick += dgvDataAcquisto_CellDoubleClick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1082, 13);
            pnlTop.TabIndex = 26;
            // 
            // PurchaseEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 689);
            Controls.Add(pnlTop);
            Controls.Add(grpAcquisti);
            Controls.Add(grpCliente);
            Controls.Add(pnlSearch);
            Controls.Add(dgvData);
            Controls.Add(grpProdotti);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 736);
            Name = "PurchaseEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GESTIONE ACQUISTI";
            FormClosed += PurchaseEditForm_FormClosed;
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
    }
}