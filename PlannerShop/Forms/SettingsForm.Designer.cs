namespace PlannerShop.Forms
{
    partial class SettingsForm
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
            lblOldPassword = new Label();
            Password = new GroupBox();
            lblPasswordResult = new Label();
            btnPasswordReset = new Button();
            btnPasswordChange = new Button();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtOldPassword = new TextBox();
            groupBox1 = new GroupBox();
            chkAccessMode = new CheckBox();
            btnOk = new Button();
            pnlTop = new Panel();
            Password.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(6, 18);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(120, 15);
            lblOldPassword.TabIndex = 0;
            lblOldPassword.Text = "PASSWORD ATTUALE";
            // 
            // Password
            // 
            Password.Controls.Add(lblPasswordResult);
            Password.Controls.Add(btnPasswordReset);
            Password.Controls.Add(btnPasswordChange);
            Password.Controls.Add(txtNewPassword);
            Password.Controls.Add(lblNewPassword);
            Password.Controls.Add(txtOldPassword);
            Password.Controls.Add(lblOldPassword);
            Password.Location = new Point(10, 26);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Padding = new Padding(3, 2, 3, 2);
            Password.Size = new Size(403, 241);
            Password.TabIndex = 0;
            Password.TabStop = false;
            Password.Text = "CAMBIO PASSWORD";
            // 
            // lblPasswordResult
            // 
            lblPasswordResult.Location = new Point(6, 137);
            lblPasswordResult.Name = "lblPasswordResult";
            lblPasswordResult.Size = new Size(391, 24);
            lblPasswordResult.TabIndex = 0;
            lblPasswordResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPasswordReset
            // 
            btnPasswordReset.Location = new Point(6, 202);
            btnPasswordReset.Margin = new Padding(3, 2, 3, 2);
            btnPasswordReset.Name = "btnPasswordReset";
            btnPasswordReset.Size = new Size(391, 35);
            btnPasswordReset.TabIndex = 3;
            btnPasswordReset.Text = "RESET";
            btnPasswordReset.UseVisualStyleBackColor = true;
            btnPasswordReset.Click += btnPasswordReset_Click;
            // 
            // btnPasswordChange
            // 
            btnPasswordChange.Location = new Point(6, 163);
            btnPasswordChange.Margin = new Padding(3, 2, 3, 2);
            btnPasswordChange.Name = "btnPasswordChange";
            btnPasswordChange.Size = new Size(391, 35);
            btnPasswordChange.TabIndex = 2;
            btnPasswordChange.Text = "CAMBIA PASSWORD";
            btnPasswordChange.UseVisualStyleBackColor = true;
            btnPasswordChange.Click += btnPasswordChange_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(6, 77);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(391, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(6, 60);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(111, 15);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "NUOVA PASSWORD";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(6, 35);
            txtOldPassword.Margin = new Padding(3, 2, 3, 2);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(391, 23);
            txtOldPassword.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAccessMode);
            groupBox1.Location = new Point(10, 271);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(403, 48);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Accesso";
            // 
            // chkAccessMode
            // 
            chkAccessMode.AutoSize = true;
            chkAccessMode.Checked = true;
            chkAccessMode.CheckState = CheckState.Checked;
            chkAccessMode.Location = new Point(6, 20);
            chkAccessMode.Margin = new Padding(3, 2, 3, 2);
            chkAccessMode.Name = "chkAccessMode";
            chkAccessMode.Size = new Size(155, 19);
            chkAccessMode.TabIndex = 0;
            chkAccessMode.Text = "ABILITA INS. PASSWORD";
            chkAccessMode.UseVisualStyleBackColor = true;
            chkAccessMode.CheckedChanged += chkAccessMode_CheckedChanged;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(11, 323);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(404, 51);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(425, 10);
            pnlTop.TabIndex = 24;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 385);
            Controls.Add(pnlTop);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Controls.Add(Password);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SETTINGS";
            Password.ResumeLayout(false);
            Password.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label lblOldPassword;
        private GroupBox Password;
        private Button btnPasswordChange;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtOldPassword;
        private Label lblPasswordResult;
        private GroupBox groupBox1;
        public CheckBox chkAccessMode;
        private Button btnOk;
        private Button btnPasswordReset;
        private Panel pnlTop;
    }
}