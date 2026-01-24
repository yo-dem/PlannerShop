namespace PlannerShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dgvData = new DataGridView();
            btnDelete = new Button();
            btnLogout = new Button();
            btnEdit = new Button();
            btnInsert = new Button();
            btnProdotti = new Button();
            btnFornitori = new Button();
            btnClienti = new Button();
            btnServizi = new Button();
            pnlLine = new Panel();
            pnlRight = new Panel();
            pnlLeft = new Panel();
            pnlUp = new Panel();
            btnGift = new Button();
            timerGift = new System.Windows.Forms.Timer(components);
            btnZoomOut = new Button();
            btnZoomIn = new Button();
            btnAgenda = new Button();
            btnOpzioni = new Button();
            txtSearch = new TextBox();
            searchImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = SystemColors.Control;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 100);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1059, 450);
            dgvData.TabIndex = 5;
            dgvData.CellFormatting += dgvData_CellFormatting;
            dgvData.DataBindingComplete += DgvData_DataBindingComplete;
            dgvData.KeyDown += dgvData_KeyDown;
            dgvData.MouseClick += dgvData_MouseClick;
            dgvData.MouseDoubleClick += dgvData_MouseDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.Image = Properties.Resources.trashImage;
            btnDelete.Location = new Point(384, 559);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 60);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "ELIMINA";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.Image = Properties.Resources.shutdown_orange;
            btnLogout.Location = new Point(570, 559);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(502, 60);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "LOGOUT";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
            btnLogout.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEdit.Image = Properties.Resources.editPageImage;
            btnEdit.Location = new Point(198, 559);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 60);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "MODIFICA";
            btnEdit.TextAlign = ContentAlignment.BottomCenter;
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInsert.Image = Properties.Resources.addLiteImage;
            btnInsert.Location = new Point(12, 559);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(180, 60);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "INSERISCI";
            btnInsert.TextAlign = ContentAlignment.BottomCenter;
            btnInsert.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnProdotti
            // 
            btnProdotti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnProdotti.Image = Properties.Resources.prodotti_24;
            btnProdotti.ImageAlign = ContentAlignment.MiddleRight;
            btnProdotti.Location = new Point(384, 54);
            btnProdotti.Margin = new Padding(3, 2, 3, 2);
            btnProdotti.Name = "btnProdotti";
            btnProdotti.Size = new Size(180, 40);
            btnProdotti.TabIndex = 2;
            btnProdotti.Text = " PRODOTTI";
            btnProdotti.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProdotti.UseVisualStyleBackColor = true;
            btnProdotti.Click += btnProdotti_Click;
            // 
            // btnFornitori
            // 
            btnFornitori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFornitori.Image = Properties.Resources.fornitore_24;
            btnFornitori.ImageAlign = ContentAlignment.MiddleRight;
            btnFornitori.Location = new Point(198, 54);
            btnFornitori.Margin = new Padding(3, 2, 3, 2);
            btnFornitori.Name = "btnFornitori";
            btnFornitori.Size = new Size(180, 40);
            btnFornitori.TabIndex = 1;
            btnFornitori.Text = " FORNITORI";
            btnFornitori.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornitori.UseVisualStyleBackColor = true;
            btnFornitori.Click += btnFornitori_Click;
            // 
            // btnClienti
            // 
            btnClienti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClienti.Image = Properties.Resources.clienti;
            btnClienti.ImageAlign = ContentAlignment.MiddleRight;
            btnClienti.Location = new Point(12, 54);
            btnClienti.Margin = new Padding(3, 2, 3, 2);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new Size(180, 40);
            btnClienti.TabIndex = 0;
            btnClienti.Text = " CLIENTI";
            btnClienti.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClienti.UseVisualStyleBackColor = true;
            btnClienti.Click += btnClienti_Click;
            // 
            // btnServizi
            // 
            btnServizi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnServizi.Image = Properties.Resources.serviziEstetici;
            btnServizi.ImageAlign = ContentAlignment.MiddleRight;
            btnServizi.Location = new Point(570, 54);
            btnServizi.Margin = new Padding(3, 2, 3, 2);
            btnServizi.Name = "btnServizi";
            btnServizi.Size = new Size(180, 40);
            btnServizi.TabIndex = 3;
            btnServizi.Text = " SERVIZI";
            btnServizi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServizi.UseVisualStyleBackColor = true;
            btnServizi.Click += btnServizi_Click;
            // 
            // pnlLine
            // 
            pnlLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = Color.DarkGray;
            pnlLine.Location = new Point(12, 550);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(1059, 1);
            pnlLine.TabIndex = 25;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRight.BackColor = Color.DarkGray;
            pnlRight.Location = new Point(1070, 100);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1, 450);
            pnlRight.TabIndex = 26;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeft.BackColor = Color.DarkGray;
            pnlLeft.Location = new Point(12, 100);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1, 450);
            pnlLeft.TabIndex = 28;
            // 
            // pnlUp
            // 
            pnlUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUp.BackColor = Color.DarkGray;
            pnlUp.Location = new Point(12, 100);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(1059, 1);
            pnlUp.TabIndex = 26;
            // 
            // btnGift
            // 
            btnGift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGift.FlatAppearance.BorderColor = SystemColors.Control;
            btnGift.FlatAppearance.BorderSize = 0;
            btnGift.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGift.FlatAppearance.MouseOverBackColor = Color.White;
            btnGift.FlatStyle = FlatStyle.Flat;
            btnGift.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGift.Image = Properties.Resources.gift_black;
            btnGift.Location = new Point(1010, 67);
            btnGift.Margin = new Padding(3, 2, 3, 2);
            btnGift.Name = "btnGift";
            btnGift.Size = new Size(28, 28);
            btnGift.TabIndex = 14;
            btnGift.TextAlign = ContentAlignment.BottomCenter;
            btnGift.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGift.UseVisualStyleBackColor = true;
            btnGift.Click += btnGift_Click;
            // 
            // timerGift
            // 
            timerGift.Enabled = true;
            timerGift.Interval = 1000;
            timerGift.Tick += timerGift_Tick;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoomOut.FlatAppearance.BorderColor = SystemColors.Control;
            btnZoomOut.FlatAppearance.BorderSize = 0;
            btnZoomOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnZoomOut.FlatAppearance.MouseOverBackColor = Color.White;
            btnZoomOut.FlatStyle = FlatStyle.Flat;
            btnZoomOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnZoomOut.Image = Properties.Resources.zoomOut;
            btnZoomOut.Location = new Point(908, 67);
            btnZoomOut.Margin = new Padding(3, 2, 3, 2);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(28, 28);
            btnZoomOut.TabIndex = 10;
            btnZoomOut.TextAlign = ContentAlignment.BottomCenter;
            btnZoomOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoomIn.FlatAppearance.BorderColor = SystemColors.Control;
            btnZoomIn.FlatAppearance.BorderSize = 0;
            btnZoomIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnZoomIn.FlatAppearance.MouseOverBackColor = Color.White;
            btnZoomIn.FlatStyle = FlatStyle.Flat;
            btnZoomIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnZoomIn.Image = Properties.Resources.zoomIn;
            btnZoomIn.Location = new Point(942, 67);
            btnZoomIn.Margin = new Padding(3, 2, 3, 2);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(28, 28);
            btnZoomIn.TabIndex = 11;
            btnZoomIn.TextAlign = ContentAlignment.BottomCenter;
            btnZoomIn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgenda.FlatAppearance.BorderColor = SystemColors.Control;
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.White;
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.Location = new Point(1044, 67);
            btnAgenda.Margin = new Padding(3, 2, 3, 2);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(28, 28);
            btnAgenda.TabIndex = 4;
            btnAgenda.TextAlign = ContentAlignment.BottomCenter;
            btnAgenda.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnOpzioni
            // 
            btnOpzioni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpzioni.FlatAppearance.BorderColor = SystemColors.Control;
            btnOpzioni.FlatAppearance.BorderSize = 0;
            btnOpzioni.FlatAppearance.CheckedBackColor = Color.White;
            btnOpzioni.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOpzioni.FlatAppearance.MouseOverBackColor = Color.White;
            btnOpzioni.FlatStyle = FlatStyle.Flat;
            btnOpzioni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpzioni.Image = Properties.Resources.settingsImage;
            btnOpzioni.Location = new Point(976, 67);
            btnOpzioni.Margin = new Padding(3, 2, 3, 2);
            btnOpzioni.Name = "btnOpzioni";
            btnOpzioni.Size = new Size(28, 28);
            btnOpzioni.TabIndex = 15;
            btnOpzioni.TextAlign = ContentAlignment.BottomCenter;
            btnOpzioni.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOpzioni.UseVisualStyleBackColor = true;
            btnOpzioni.Click += btnOpzioni_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Corbel", 16F);
            txtSearch.Location = new Point(12, 9);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1060, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(14, 9);
            searchImage.Margin = new Padding(3, 2, 3, 2);
            searchImage.Name = "searchImage";
            searchImage.Size = new Size(24, 24);
            searchImage.SizeMode = PictureBoxSizeMode.AutoSize;
            searchImage.TabIndex = 22;
            searchImage.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 631);
            Controls.Add(searchImage);
            Controls.Add(txtSearch);
            Controls.Add(btnOpzioni);
            Controls.Add(btnAgenda);
            Controls.Add(btnZoomIn);
            Controls.Add(btnZoomOut);
            Controls.Add(btnGift);
            Controls.Add(pnlLine);
            Controls.Add(pnlUp);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(btnServizi);
            Controls.Add(dgvData);
            Controls.Add(btnClienti);
            Controls.Add(btnProdotti);
            Controls.Add(btnFornitori);
            Controls.Add(btnDelete);
            Controls.Add(btnLogout);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1100, 670);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlannerShop 1.0";
            FormClosing += MainForm_FormClosing;
            KeyPress += MainForm_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvData;
        private Button btnDelete;
        private Button btnLogout;
        private Button btnEdit;
        private Button btnInsert;
        private Button btnProdotti;
        private Button btnFornitori;
        private Button btnClienti;
        private Button btnServizi;
        private Panel pnlLine;
        private Panel pnlRight;
        private Panel pnlLeft;
        private Panel pnlUp;
        private Button btnGift;
        private System.Windows.Forms.Timer timerGift;
        private Button btnZoomOut;
        private Button btnZoomIn;
        private Button btnAgenda;
        private Button btnOpzioni;
        private TextBox txtSearch;
        private PictureBox searchImage;
    }
}
