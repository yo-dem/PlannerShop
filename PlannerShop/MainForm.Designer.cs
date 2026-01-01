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
            btnStatistiche = new Button();
            btnStampa = new Button();
            searchImage = new PictureBox();
            txtSearch = new TextBox();
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
            pnlTop = new Panel();
            button1 = new Button();
            btnOpzioni = new Button();
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
            dgvData.Location = new Point(12, 145);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1059, 410);
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
            btnProdotti.Location = new Point(384, 85);
            btnProdotti.Margin = new Padding(3, 2, 3, 2);
            btnProdotti.Name = "btnProdotti";
            btnProdotti.Size = new Size(180, 55);
            btnProdotti.TabIndex = 2;
            btnProdotti.Text = "PRODOTTI";
            btnProdotti.TextAlign = ContentAlignment.BottomCenter;
            btnProdotti.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProdotti.UseVisualStyleBackColor = true;
            btnProdotti.Click += btnProdotti_Click;
            // 
            // btnFornitori
            // 
            btnFornitori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFornitori.Image = Properties.Resources.fornitore_24;
            btnFornitori.Location = new Point(198, 85);
            btnFornitori.Margin = new Padding(3, 2, 3, 2);
            btnFornitori.Name = "btnFornitori";
            btnFornitori.Size = new Size(180, 55);
            btnFornitori.TabIndex = 1;
            btnFornitori.Text = "FORNITORI";
            btnFornitori.TextAlign = ContentAlignment.BottomCenter;
            btnFornitori.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFornitori.UseVisualStyleBackColor = true;
            btnFornitori.Click += btnFornitori_Click;
            // 
            // btnStatistiche
            // 
            btnStatistiche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStatistiche.FlatAppearance.BorderColor = Color.White;
            btnStatistiche.FlatAppearance.BorderSize = 0;
            btnStatistiche.FlatAppearance.CheckedBackColor = Color.White;
            btnStatistiche.FlatAppearance.MouseDownBackColor = Color.White;
            btnStatistiche.FlatAppearance.MouseOverBackColor = Color.White;
            btnStatistiche.FlatStyle = FlatStyle.Flat;
            btnStatistiche.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStatistiche.Image = (Image)resources.GetObject("btnStatistiche.Image");
            btnStatistiche.Location = new Point(941, 15);
            btnStatistiche.Margin = new Padding(3, 2, 3, 2);
            btnStatistiche.Name = "btnStatistiche";
            btnStatistiche.Size = new Size(28, 28);
            btnStatistiche.TabIndex = 12;
            btnStatistiche.TextAlign = ContentAlignment.BottomCenter;
            btnStatistiche.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStatistiche.UseVisualStyleBackColor = true;
            btnStatistiche.Click += btnStatistiche_Click;
            // 
            // btnStampa
            // 
            btnStampa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStampa.FlatAppearance.BorderColor = Color.White;
            btnStampa.FlatAppearance.BorderSize = 0;
            btnStampa.FlatAppearance.CheckedBackColor = Color.White;
            btnStampa.FlatAppearance.MouseDownBackColor = Color.White;
            btnStampa.FlatAppearance.MouseOverBackColor = Color.White;
            btnStampa.FlatStyle = FlatStyle.Flat;
            btnStampa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStampa.Image = Properties.Resources.printerImage;
            btnStampa.Location = new Point(975, 15);
            btnStampa.Margin = new Padding(3, 2, 3, 2);
            btnStampa.Name = "btnStampa";
            btnStampa.Size = new Size(28, 28);
            btnStampa.TabIndex = 13;
            btnStampa.TextAlign = ContentAlignment.BottomCenter;
            btnStampa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStampa.UseVisualStyleBackColor = true;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(12, 57);
            searchImage.Margin = new Padding(3, 2, 3, 2);
            searchImage.Name = "searchImage";
            searchImage.Size = new Size(24, 24);
            searchImage.SizeMode = PictureBoxSizeMode.AutoSize;
            searchImage.TabIndex = 22;
            searchImage.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Corbel", 14F);
            txtSearch.Location = new Point(12, 58);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1059, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnClienti
            // 
            btnClienti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClienti.Image = Properties.Resources.clienti;
            btnClienti.Location = new Point(12, 85);
            btnClienti.Margin = new Padding(3, 2, 3, 2);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new Size(180, 55);
            btnClienti.TabIndex = 0;
            btnClienti.Text = "CLIENTI";
            btnClienti.TextAlign = ContentAlignment.BottomCenter;
            btnClienti.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClienti.UseVisualStyleBackColor = true;
            btnClienti.Click += btnClienti_Click;
            // 
            // btnServizi
            // 
            btnServizi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnServizi.Image = Properties.Resources.serviziEstetici;
            btnServizi.Location = new Point(570, 85);
            btnServizi.Margin = new Padding(3, 2, 3, 2);
            btnServizi.Name = "btnServizi";
            btnServizi.Size = new Size(180, 55);
            btnServizi.TabIndex = 3;
            btnServizi.Text = "SERVIZI";
            btnServizi.TextAlign = ContentAlignment.BottomCenter;
            btnServizi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnServizi.UseVisualStyleBackColor = true;
            btnServizi.Click += btnServizi_Click;
            // 
            // pnlLine
            // 
            pnlLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = Color.DarkGray;
            pnlLine.Location = new Point(12, 554);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(1059, 1);
            pnlLine.TabIndex = 25;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRight.BackColor = Color.DarkGray;
            pnlRight.Location = new Point(1070, 146);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1, 408);
            pnlRight.TabIndex = 26;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeft.BackColor = Color.DarkGray;
            pnlLeft.Location = new Point(12, 146);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1, 408);
            pnlLeft.TabIndex = 28;
            // 
            // pnlUp
            // 
            pnlUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUp.BackColor = Color.DarkGray;
            pnlUp.Location = new Point(12, 145);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(1059, 1);
            pnlUp.TabIndex = 26;
            // 
            // btnGift
            // 
            btnGift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGift.FlatAppearance.BorderColor = Color.White;
            btnGift.FlatAppearance.BorderSize = 0;
            btnGift.FlatAppearance.MouseDownBackColor = Color.White;
            btnGift.FlatAppearance.MouseOverBackColor = Color.White;
            btnGift.FlatStyle = FlatStyle.Flat;
            btnGift.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGift.Image = Properties.Resources.gift_black;
            btnGift.Location = new Point(1009, 15);
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
            btnZoomOut.FlatAppearance.BorderColor = Color.White;
            btnZoomOut.FlatAppearance.BorderSize = 0;
            btnZoomOut.FlatAppearance.MouseDownBackColor = Color.White;
            btnZoomOut.FlatAppearance.MouseOverBackColor = Color.White;
            btnZoomOut.FlatStyle = FlatStyle.Flat;
            btnZoomOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnZoomOut.Image = Properties.Resources.zoomOut;
            btnZoomOut.Location = new Point(873, 15);
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
            btnZoomIn.FlatAppearance.BorderColor = Color.White;
            btnZoomIn.FlatAppearance.BorderSize = 0;
            btnZoomIn.FlatAppearance.MouseDownBackColor = Color.White;
            btnZoomIn.FlatAppearance.MouseOverBackColor = Color.White;
            btnZoomIn.FlatStyle = FlatStyle.Flat;
            btnZoomIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnZoomIn.Image = Properties.Resources.zoomIn;
            btnZoomIn.Location = new Point(907, 15);
            btnZoomIn.Margin = new Padding(3, 2, 3, 2);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(28, 28);
            btnZoomIn.TabIndex = 11;
            btnZoomIn.TextAlign = ContentAlignment.BottomCenter;
            btnZoomIn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1084, 10);
            pnlTop.TabIndex = 33;
            pnlTop.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1009, 85);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(63, 55);
            button1.TabIndex = 4;
            button1.Text = "AGENDA";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnOpzioni
            // 
            btnOpzioni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpzioni.FlatAppearance.BorderColor = Color.White;
            btnOpzioni.FlatAppearance.BorderSize = 0;
            btnOpzioni.FlatAppearance.CheckedBackColor = Color.White;
            btnOpzioni.FlatAppearance.MouseDownBackColor = Color.White;
            btnOpzioni.FlatAppearance.MouseOverBackColor = Color.White;
            btnOpzioni.FlatStyle = FlatStyle.Flat;
            btnOpzioni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpzioni.Image = Properties.Resources.settingsImage;
            btnOpzioni.Location = new Point(1043, 15);
            btnOpzioni.Margin = new Padding(3, 2, 3, 2);
            btnOpzioni.Name = "btnOpzioni";
            btnOpzioni.Size = new Size(28, 28);
            btnOpzioni.TabIndex = 15;
            btnOpzioni.TextAlign = ContentAlignment.BottomCenter;
            btnOpzioni.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOpzioni.UseVisualStyleBackColor = true;
            btnOpzioni.Click += btnOpzioni_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 631);
            Controls.Add(btnOpzioni);
            Controls.Add(button1);
            Controls.Add(pnlTop);
            Controls.Add(btnZoomIn);
            Controls.Add(btnZoomOut);
            Controls.Add(btnGift);
            Controls.Add(pnlLine);
            Controls.Add(pnlUp);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(searchImage);
            Controls.Add(btnServizi);
            Controls.Add(txtSearch);
            Controls.Add(dgvData);
            Controls.Add(btnClienti);
            Controls.Add(btnStatistiche);
            Controls.Add(btnStampa);
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
        private Button btnStatistiche;
        private Button btnStampa;
        private PictureBox searchImage;
        private TextBox txtSearch;
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
        private Panel pnlTop;
        private Button button1;
        private Button btnOpzioni;
    }
}
