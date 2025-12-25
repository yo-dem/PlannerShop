namespace PlannerShop.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnOk = new Button();
            btnNo = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlTop = new Panel();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Location = new Point(193, 82);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 41);
            btnOk.TabIndex = 2;
            btnOk.Text = "CONTINUA";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnNo
            // 
            btnNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNo.Location = new Point(10, 82);
            btnNo.Margin = new Padding(3, 2, 3, 2);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(178, 41);
            btnNo.TabIndex = 1;
            btnNo.Text = "ESCI";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(10, 46);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(270, 31);
            txtPassword.TabIndex = 0;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 30);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(290, 10);
            pnlTop.TabIndex = 24;
            // 
            // LoginForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 133);
            Controls.Add(pnlTop);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnNo);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnOk;
        private Button btnNo;
        private TextBox txtPassword;
        private Label lblPassword;
        private Panel pnlTop;
    }
}