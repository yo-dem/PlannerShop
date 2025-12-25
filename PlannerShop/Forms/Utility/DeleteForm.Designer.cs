namespace PlannerShop.Forms
{
    partial class DeleteForm
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
            btnAnnulla = new Button();
            btnOk = new Button();
            lblTitle = new Label();
            lblText = new Label();
            SuspendLayout();
            // 
            // btnAnnulla
            // 
            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.Location = new Point(14, 92);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(320, 55);
            btnAnnulla.TabIndex = 0;
            btnAnnulla.Text = "ANNULLA";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            btnAnnulla.KeyDown += btnAnnulla_KeyDown;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.ForeColor = Color.Red;
            btnOk.Image = PlannerShop.Properties.Resources.trashImage;
            btnOk.Location = new Point(341, 92);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(146, 55);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(14, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "ELIMINARE DEFINITIVAMENTE";
            // 
            // lblText
            // 
            lblText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblText.ForeColor = SystemColors.ControlText;
            lblText.Location = new Point(14, 40);
            lblText.Name = "lblText";
            lblText.Size = new Size(473, 31);
            lblText.TabIndex = 3;
            lblText.Text = "LABEL";
            lblText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DeleteForm
            // 
            AcceptButton = btnAnnulla;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 161);
            Controls.Add(lblText);
            Controls.Add(lblTitle);
            Controls.Add(btnOk);
            Controls.Add(btnAnnulla);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DeleteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ELIMINA ELEMENTO";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnAnnulla;
        private Button btnOk;
        private Label lblTitle;
        private Label lblText;
    }
}