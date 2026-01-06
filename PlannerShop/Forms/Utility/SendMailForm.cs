using PlannerShop.Data;
using System.Net;
using System.Net.Mail;

namespace PlannerShop.Forms
{
    public partial class SendMailForm : Form
    {
        string emailMittente = "";
        string emailDestinatario = "";
        public SendMailForm(string emailDestinatario)
        {
            InitializeComponent();
            this.emailMittente = ModelOpzioni.GetOpzione("mailgest");
            this.emailDestinatario = emailDestinatario;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(emailMittente);
            mail.To.Add(emailDestinatario);
            mail.Subject = txtOggetto.Text;
            mail.Body = txtMessage.Text;
            mail.IsBodyHtml = false;

            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(
                emailMittente,
                "miapassword"
            );
            smtp.EnableSsl = true;

            smtp.Send(mail);

            this.Close();
        }

    }
}
