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
            groupBox2 = new GroupBox();
            btnBackup = new Button();
            Password.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(7, 24);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(151, 20);
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
            Password.Location = new Point(12, 35);
            Password.Name = "Password";
            Password.Size = new Size(462, 283);
            Password.TabIndex = 0;
            Password.TabStop = false;
            Password.Text = "CAMBIO PASSWORD";
            // 
            // lblPasswordResult
            // 
            lblPasswordResult.Location = new Point(6, 133);
            lblPasswordResult.Name = "lblPasswordResult";
            lblPasswordResult.Size = new Size(447, 32);
            lblPasswordResult.TabIndex = 0;
            lblPasswordResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPasswordReset
            // 
            btnPasswordReset.Location = new Point(6, 221);
            btnPasswordReset.Name = "btnPasswordReset";
            btnPasswordReset.Size = new Size(449, 47);
            btnPasswordReset.TabIndex = 3;
            btnPasswordReset.Text = "RESET";
            btnPasswordReset.UseVisualStyleBackColor = true;
            btnPasswordReset.Click += btnPasswordReset_Click;
            // 
            // btnPasswordChange
            // 
            btnPasswordChange.Location = new Point(6, 168);
            btnPasswordChange.Name = "btnPasswordChange";
            btnPasswordChange.Size = new Size(449, 47);
            btnPasswordChange.TabIndex = 2;
            btnPasswordChange.Text = "CAMBIA PASSWORD";
            btnPasswordChange.UseVisualStyleBackColor = true;
            btnPasswordChange.Click += btnPasswordChange_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(7, 103);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(448, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(7, 80);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(141, 20);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "NUOVA PASSWORD";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(7, 47);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(448, 27);
            txtOldPassword.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAccessMode);
            groupBox1.Location = new Point(12, 424);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 64);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCESSO";
            // 
            // chkAccessMode
            // 
            chkAccessMode.AutoSize = true;
            chkAccessMode.Checked = true;
            chkAccessMode.CheckState = CheckState.Checked;
            chkAccessMode.Location = new Point(7, 27);
            chkAccessMode.Name = "chkAccessMode";
            chkAccessMode.Size = new Size(194, 24);
            chkAccessMode.TabIndex = 0;
            chkAccessMode.Text = "ABILITA INS. PASSWORD";
            chkAccessMode.UseVisualStyleBackColor = true;
            chkAccessMode.CheckedChanged += chkAccessMode_CheckedChanged;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(12, 494);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(462, 68);
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
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(486, 13);
            pnlTop.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBackup);
            groupBox2.Location = new Point(12, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 94);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "BACKUP ARCHIVIO";
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(6, 31);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(450, 47);
            btnBackup.TabIndex = 4;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 574);
            Controls.Add(groupBox2);
            Controls.Add(pnlTop);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            Controls.Add(Password);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SETTINGS";
            Password.ResumeLayout(false);
            Password.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private Button btnBackup;
    }
}