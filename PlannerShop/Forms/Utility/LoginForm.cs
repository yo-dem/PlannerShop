using PlannerShop.Data;

namespace PlannerShop.Forms
{
    public partial class LoginForm : Form
    {
        public bool logged = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ModelPwd.GetAccess(txtPassword.Text))
            {
                logged = true;
                this.Close();
            }
            else
            {
                lblPassword.ForeColor = Color.Red;
                lblPassword.Font = new Font(lblPassword.Font, FontStyle.Bold);
                lblPassword.Text = "PASSWORD ERRATA";
            } 
            txtPassword.Text = String.Empty;
            txtPassword.Focus();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logged)
                Application.Exit();      
        }
    }
}
