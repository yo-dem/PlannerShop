using PlannerShop.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PlannerShop.Forms
{
    public partial class SettingsForm : Form
    {
        bool emailNotValid = false;
        public SettingsForm()
        {
            InitializeComponent();
            chkAccessMode.Checked = ModelPwd.IsEnabled();

            txtEmail.Text = ModelOpzioni.GetOpzione("mailgest");
            txtPassword.Text = ModelOpzioni.GetOpzione("pwdmailgest");
            txtSmtp.Text = ModelOpzioni.GetOpzione("smtpmailgest");
            txtPort.Text = ModelOpzioni.GetOpzione("portmailgest");

        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtOldPassword.Text) || String.IsNullOrEmpty(txtNewPassword.Text)))
            {
                if (ModelPwd.GetAccess(txtOldPassword.Text))
                {
                    ModelPwd.ChangePwd(txtNewPassword.Text);
                    lblPasswordResult.Text = "Password cambiata";
                    txtOldPassword.Text = String.Empty;
                    txtNewPassword.Text = String.Empty;
                }
                else
                    lblPasswordResult.Text = "Password errata";
            }
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            ModelPwd.ChangePwd("1234");
            lblPasswordResult.Text = "Password resettata";
        }

        private void chkAccessMode_CheckedChanged(object sender, EventArgs e)
        {
            ModelPwd.SetEnabled(chkAccessMode.Checked);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var location = Assembly.GetEntryAssembly();
                if (location != null)
                {
                    string sourceFile = Path.GetDirectoryName(location.Location) + @"\Data\PSDB.db";
                    string targetPath = Path.GetDirectoryName(location.Location) + @"\Data\Archivio\";

                    string timestamp = DateTime.Now.ToString().Replace('/', '_').Replace(' ', '_').Replace(':', '_');

                    string destFile = Path.Combine(targetPath, "PSDB_" + timestamp + ".db");

                    Directory.CreateDirectory(targetPath);

                    File.Copy(sourceFile, destFile, true);
                    MessageBox.Show("Backup eseguito correttamente");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Errore nel salvataggio del backup. Procedere a un salvataggio manuale");
                this.Close();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                txtEmail.ForeColor = Color.Black;
                emailNotValid = false;
            }
            else
            {
                txtEmail.ForeColor = Color.Red;
                emailNotValid = true;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.ForeColor = Color.Black;
                emailNotValid = false;
            }
        }

        private void btnSaveMail_Click(object sender, EventArgs e)
        {
            if(!emailNotValid)
            {
                ModelOpzioni.SetOpzione("mailgest", txtEmail.Text);
                ModelOpzioni.SetOpzione("pwdmailgest", txtPassword.Text);
                ModelOpzioni.SetOpzione("smtpmailgest", txtSmtp.Text);
                ModelOpzioni.SetOpzione("portmailgest", txtPort.Text);

                lblEmailResult.Text = "Email salvata";
            }
        }
    }
}
