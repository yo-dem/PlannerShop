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
            groupBox3 = new GroupBox();
            lblPort = new Label();
            txtPort = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblSmtp = new Label();
            txtSmtp = new TextBox();
            lblEmail = new Label();
            lblEmailResult = new Label();
            btnSaveMail = new Button();
            txtEmail = new TextBox();
            tabSettings = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            lblBackupResult = new Label();
            Password.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabSettings.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            Password.Location = new Point(6, 5);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Padding = new Padding(3, 2, 3, 2);
            Password.Size = new Size(408, 298);
            Password.TabIndex = 0;
            Password.TabStop = false;
            // 
            // lblPasswordResult
            // 
            lblPasswordResult.Location = new Point(6, 193);
            lblPasswordResult.Name = "lblPasswordResult";
            lblPasswordResult.Size = new Size(396, 24);
            lblPasswordResult.TabIndex = 0;
            lblPasswordResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPasswordReset
            // 
            btnPasswordReset.Location = new Point(6, 259);
            btnPasswordReset.Margin = new Padding(3, 2, 3, 2);
            btnPasswordReset.Name = "btnPasswordReset";
            btnPasswordReset.Size = new Size(396, 35);
            btnPasswordReset.TabIndex = 3;
            btnPasswordReset.Text = "RESET";
            btnPasswordReset.UseVisualStyleBackColor = true;
            btnPasswordReset.Click += btnPasswordReset_Click;
            // 
            // btnPasswordChange
            // 
            btnPasswordChange.Location = new Point(6, 219);
            btnPasswordChange.Margin = new Padding(3, 2, 3, 2);
            btnPasswordChange.Name = "btnPasswordChange";
            btnPasswordChange.Size = new Size(396, 35);
            btnPasswordChange.TabIndex = 2;
            btnPasswordChange.Text = "CAMBIA PASSWORD";
            btnPasswordChange.UseVisualStyleBackColor = true;
            btnPasswordChange.Click += btnPasswordChange_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(6, 79);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(396, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(6, 61);
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
            txtOldPassword.Size = new Size(396, 23);
            txtOldPassword.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAccessMode);
            groupBox1.Location = new Point(12, 361);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(428, 48);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCESSO";
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
            chkAccessMode.TabIndex = 5;
            chkAccessMode.Text = "ABILITA INS. PASSWORD";
            chkAccessMode.UseVisualStyleBackColor = true;
            chkAccessMode.CheckedChanged += chkAccessMode_CheckedChanged;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(12, 413);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(428, 51);
            btnOk.TabIndex = 6;
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
            pnlTop.Size = new Size(452, 10);
            pnlTop.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBackupResult);
            groupBox2.Controls.Add(btnBackup);
            groupBox2.Location = new Point(6, 5);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(408, 302);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(6, 263);
            btnBackup.Margin = new Padding(3, 2, 3, 2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(396, 35);
            btnBackup.TabIndex = 4;
            btnBackup.Text = "BACKUP";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblPort);
            groupBox3.Controls.Add(txtPort);
            groupBox3.Controls.Add(lblPassword);
            groupBox3.Controls.Add(txtPassword);
            groupBox3.Controls.Add(lblSmtp);
            groupBox3.Controls.Add(txtSmtp);
            groupBox3.Controls.Add(lblEmail);
            groupBox3.Controls.Add(lblEmailResult);
            groupBox3.Controls.Add(btnSaveMail);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Location = new Point(6, 5);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(408, 302);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(6, 149);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(43, 15);
            lblPort.TabIndex = 12;
            lblPort.Text = "PORTA";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(6, 167);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(396, 23);
            txtPort.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 61);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(396, 23);
            txtPassword.TabIndex = 9;
            // 
            // lblSmtp
            // 
            lblSmtp.AutoSize = true;
            lblSmtp.Location = new Point(6, 105);
            lblSmtp.Name = "lblSmtp";
            lblSmtp.Size = new Size(38, 15);
            lblSmtp.TabIndex = 8;
            lblSmtp.Text = "SMTP";
            // 
            // txtSmtp
            // 
            txtSmtp.Location = new Point(6, 123);
            txtSmtp.Name = "txtSmtp";
            txtSmtp.Size = new Size(396, 23);
            txtSmtp.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 18);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "EMAIL";
            // 
            // lblEmailResult
            // 
            lblEmailResult.Location = new Point(6, 237);
            lblEmailResult.Name = "lblEmailResult";
            lblEmailResult.Size = new Size(396, 24);
            lblEmailResult.TabIndex = 5;
            lblEmailResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveMail
            // 
            btnSaveMail.Location = new Point(6, 263);
            btnSaveMail.Margin = new Padding(3, 2, 3, 2);
            btnSaveMail.Name = "btnSaveMail";
            btnSaveMail.Size = new Size(396, 35);
            btnSaveMail.TabIndex = 4;
            btnSaveMail.Text = "SALVA MAIL";
            btnSaveMail.UseVisualStyleBackColor = true;
            btnSaveMail.Click += btnSaveMail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 35);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(396, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabPage1);
            tabSettings.Controls.Add(tabPage2);
            tabSettings.Controls.Add(tabPage3);
            tabSettings.Location = new Point(12, 16);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(428, 340);
            tabSettings.TabIndex = 27;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Password);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(420, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PASSWORD";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(420, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "EMAIL";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(420, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "BACKUP";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblBackupResult
            // 
            lblBackupResult.Location = new Point(6, 237);
            lblBackupResult.Name = "lblBackupResult";
            lblBackupResult.Size = new Size(396, 24);
            lblBackupResult.TabIndex = 6;
            lblBackupResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 479);
            Controls.Add(tabSettings);
            Controls.Add(pnlTop);
            Controls.Add(btnOk);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SETTINGS";
            Password.ResumeLayout(false);
            Password.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabSettings.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
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
        private GroupBox groupBox3;
        private TextBox txtEmail;
        private Label lblEmailResult;
        private Button btnSaveMail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblSmtp;
        private TextBox txtSmtp;
        private Label lblEmail;
        private Label lblPort;
        private TextBox txtPort;
        private TabControl tabSettings;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblBackupResult;
    }
}