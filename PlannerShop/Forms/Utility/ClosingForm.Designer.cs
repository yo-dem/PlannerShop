namespace PlannerShop.Forms.Utility
{
    partial class ClosingForm
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
            btnOk = new Button();
            btnAnnulla = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(438, 10);
            pnlTop.TabIndex = 24;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.ForeColor = Color.Red;
            btnOk.Image = Properties.Resources.trashImage;
            btnOk.Location = new Point(298, 69);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(128, 41);
            btnOk.TabIndex = 26;
            btnOk.Text = "OK";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.Location = new Point(12, 69);
            btnAnnulla.Margin = new Padding(3, 2, 3, 2);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(280, 41);
            btnAnnulla.TabIndex = 25;
            btnAnnulla.Text = "ANNULLA";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(12, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 21);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "USCIRA DALL'APPLICAZIONE?";
            // 
            // ClosingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 121);
            Controls.Add(lblTitle);
            Controls.Add(btnOk);
            Controls.Add(btnAnnulla);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClosingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CONFERMA USCITA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Button btnOk;
        private Button btnAnnulla;
        private Label lblTitle;
    }
}