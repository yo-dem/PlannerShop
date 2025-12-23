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
            btnOpzioni = new Button();
            searchImage = new PictureBox();
            txtSearch = new TextBox();
            pnlTop = new Panel();
            btnClienti = new Button();
            btnServizi = new Button();
            pnlLine = new Panel();
            pnlRight = new Panel();
            pnlLeft = new Panel();
            pnlUp = new Panel();
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
            dgvData.Location = new Point(12, 123);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1059, 425);
            dgvData.TabIndex = 5;
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
            btnDelete.Location = new Point(384, 553);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 52);
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
            btnLogout.Location = new Point(756, 553);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(315, 52);
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
            btnEdit.Location = new Point(198, 553);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 52);
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
            btnInsert.Location = new Point(12, 553);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(180, 52);
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
            btnProdotti.Location = new Point(384, 59);
            btnProdotti.Margin = new Padding(3, 2, 3, 2);
            btnProdotti.Name = "btnProdotti";
            btnProdotti.Size = new Size(180, 52);
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
            btnFornitori.Location = new Point(198, 59);
            btnFornitori.Margin = new Padding(3, 2, 3, 2);
            btnFornitori.Name = "btnFornitori";
            btnFornitori.Size = new Size(180, 52);
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
            btnStatistiche.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStatistiche.Image = Properties.Resources.statistiche_24;
            btnStatistiche.Location = new Point(804, 59);
            btnStatistiche.Margin = new Padding(3, 2, 3, 2);
            btnStatistiche.Name = "btnStatistiche";
            btnStatistiche.Size = new Size(131, 52);
            btnStatistiche.TabIndex = 3;
            btnStatistiche.Text = "STATISTICHE";
            btnStatistiche.TextAlign = ContentAlignment.BottomCenter;
            btnStatistiche.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStatistiche.UseVisualStyleBackColor = true;
            btnStatistiche.Click += btnStatistiche_Click;
            // 
            // btnStampa
            // 
            btnStampa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStampa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStampa.Image = Properties.Resources.printerImage;
            btnStampa.Location = new Point(941, 59);
            btnStampa.Margin = new Padding(3, 2, 3, 2);
            btnStampa.Name = "btnStampa";
            btnStampa.Size = new Size(131, 52);
            btnStampa.TabIndex = 4;
            btnStampa.Text = "STAMPE";
            btnStampa.TextAlign = ContentAlignment.BottomCenter;
            btnStampa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStampa.UseVisualStyleBackColor = true;
            // 
            // btnOpzioni
            // 
            btnOpzioni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOpzioni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOpzioni.Image = Properties.Resources.settingsImage;
            btnOpzioni.Location = new Point(570, 553);
            btnOpzioni.Margin = new Padding(3, 2, 3, 2);
            btnOpzioni.Name = "btnOpzioni";
            btnOpzioni.Size = new Size(180, 52);
            btnOpzioni.TabIndex = 5;
            btnOpzioni.Text = "OPZIONI";
            btnOpzioni.TextAlign = ContentAlignment.BottomCenter;
            btnOpzioni.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOpzioni.UseVisualStyleBackColor = true;
            btnOpzioni.Click += btnOpzioni_Click;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(12, 27);
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
            txtSearch.Location = new Point(12, 27);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1060, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1084, 10);
            pnlTop.TabIndex = 23;
            // 
            // btnClienti
            // 
            btnClienti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClienti.Image = Properties.Resources.clienti;
            btnClienti.Location = new Point(12, 59);
            btnClienti.Margin = new Padding(3, 2, 3, 2);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new Size(180, 52);
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
            btnServizi.Location = new Point(570, 59);
            btnServizi.Margin = new Padding(3, 2, 3, 2);
            btnServizi.Name = "btnServizi";
            btnServizi.Size = new Size(180, 52);
            btnServizi.TabIndex = 24;
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
            pnlLine.Location = new Point(12, 547);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(1059, 1);
            pnlLine.TabIndex = 25;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRight.BackColor = Color.DarkGray;
            pnlRight.Location = new Point(1070, 123);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1, 425);
            pnlRight.TabIndex = 26;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeft.BackColor = Color.DarkGray;
            pnlLeft.Location = new Point(12, 123);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1, 425);
            pnlLeft.TabIndex = 28;
            // 
            // pnlUp
            // 
            pnlUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUp.BackColor = Color.DarkGray;
            pnlUp.Location = new Point(12, 123);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(1059, 1);
            pnlUp.TabIndex = 26;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 614);
            Controls.Add(pnlLine);
            Controls.Add(pnlUp);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(searchImage);
            Controls.Add(btnServizi);
            Controls.Add(txtSearch);
            Controls.Add(dgvData);
            Controls.Add(btnClienti);
            Controls.Add(pnlTop);
            Controls.Add(btnOpzioni);
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
            MinimumSize = new Size(1100, 396);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlannerShop 1.0";
            WindowState = FormWindowState.Maximized;
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
        private Button btnOpzioni;
        private PictureBox searchImage;
        private TextBox txtSearch;
        private Panel pnlTop;
        private Button btnClienti;
        private Button btnServizi;
        private Panel pnlLine;
        private Panel pnlRight;
        private Panel pnlLeft;
        private Panel pnlUp;
    }
}
