﻿namespace PlannerShop
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
            pnlSearch = new Panel();
            searchImage = new PictureBox();
            txtSearch = new TextBox();
            pnlTop = new Panel();
            btnClienti = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(14, 162);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1211, 469);
            dgvData.TabIndex = 5;
            dgvData.KeyDown += dgvData_KeyDown;
            dgvData.MouseClick += dgvData_MouseClick;
            dgvData.MouseDoubleClick += dgvData_MouseDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.Image = Properties.Resources.trashImage;
            btnDelete.Location = new Point(327, 637);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 69);
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
            btnLogout.Location = new Point(640, 637);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(584, 69);
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
            btnEdit.Location = new Point(170, 637);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 69);
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
            btnInsert.Location = new Point(14, 637);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(150, 69);
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
            btnProdotti.Location = new Point(327, 87);
            btnProdotti.Name = "btnProdotti";
            btnProdotti.Size = new Size(150, 69);
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
            btnFornitori.Location = new Point(170, 87);
            btnFornitori.Name = "btnFornitori";
            btnFornitori.Size = new Size(150, 69);
            btnFornitori.TabIndex = 1;
            btnFornitori.Text = "FORNITORI";
            btnFornitori.TextAlign = ContentAlignment.BottomCenter;
            btnFornitori.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFornitori.UseVisualStyleBackColor = true;
            btnFornitori.Click += btnFornitori_Click;
            // 
            // btnStatistiche
            // 
            btnStatistiche.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStatistiche.Image = Properties.Resources.statistiche_24;
            btnStatistiche.Location = new Point(483, 87);
            btnStatistiche.Name = "btnStatistiche";
            btnStatistiche.Size = new Size(150, 69);
            btnStatistiche.TabIndex = 3;
            btnStatistiche.Text = "STATISTICHE";
            btnStatistiche.TextAlign = ContentAlignment.BottomCenter;
            btnStatistiche.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStatistiche.UseVisualStyleBackColor = true;
            btnStatistiche.Click += btnStatistiche_Click;
            // 
            // btnStampa
            // 
            btnStampa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnStampa.Image = Properties.Resources.printerImage;
            btnStampa.Location = new Point(640, 87);
            btnStampa.Name = "btnStampa";
            btnStampa.Size = new Size(150, 69);
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
            btnOpzioni.Location = new Point(483, 637);
            btnOpzioni.Name = "btnOpzioni";
            btnOpzioni.Size = new Size(150, 69);
            btnOpzioni.TabIndex = 5;
            btnOpzioni.Text = "OPZIONI";
            btnOpzioni.TextAlign = ContentAlignment.BottomCenter;
            btnOpzioni.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOpzioni.UseVisualStyleBackColor = true;
            btnOpzioni.Click += btnOpzioni_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(searchImage);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(14, 21);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1211, 58);
            pnlSearch.TabIndex = 22;
            // 
            // searchImage
            // 
            searchImage.BackColor = Color.White;
            searchImage.Image = Properties.Resources.searchWhiteImage;
            searchImage.Location = new Point(9, 17);
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
            txtSearch.Location = new Point(38, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1168, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.KeyPress += txtSearch_KeyPress;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1239, 13);
            pnlTop.TabIndex = 23;
            // 
            // btnClienti
            // 
            btnClienti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClienti.Image = Properties.Resources.fornitore_24;
            btnClienti.Location = new Point(14, 87);
            btnClienti.Name = "btnClienti";
            btnClienti.Size = new Size(150, 69);
            btnClienti.TabIndex = 0;
            btnClienti.Text = "CLIENTI";
            btnClienti.TextAlign = ContentAlignment.BottomCenter;
            btnClienti.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClienti.UseVisualStyleBackColor = true;
            btnClienti.Click += btnClienti_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 719);
            Controls.Add(dgvData);
            Controls.Add(btnClienti);
            Controls.Add(pnlTop);
            Controls.Add(pnlSearch);
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
            MinimumSize = new Size(1255, 515);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlannerShop 1.0";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchImage).EndInit();
            ResumeLayout(false);
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
        private Panel pnlSearch;
        private PictureBox searchImage;
        private TextBox txtSearch;
        private Panel pnlTop;
        private Button btnClienti;
    }
}
