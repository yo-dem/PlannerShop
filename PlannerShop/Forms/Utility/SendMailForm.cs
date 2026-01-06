using PlannerShop.Data;
using System.Net;
using System.Net.Mail;

namespace PlannerShop.Forms
{
    public partial class SendMailForm : Form
    {
        private readonly string emailMittente;
        private readonly string emailDestinatario;
        private readonly string passwordApp;
        private readonly string smtpServer;
        private readonly string smtpPort;
        public SendMailForm(string emailDestinatario)
        {
            InitializeComponent();
            this.emailMittente = ModelOpzioni.GetOpzione("mailgest");
            this.passwordApp = ModelOpzioni.GetOpzione("pwdmailgest");
            this.smtpServer = ModelOpzioni.GetOpzione("smtpmailgest");
            this.smtpPort = ModelOpzioni.GetOpzione("portmailgest");

            this.emailDestinatario = emailDestinatario;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtOggetto.Text))
            {
                MessageBox.Show(
                    "Inserire un oggetto per la mail.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if(string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show(
                    "Inserire un messaggio per la mail.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailMittente);
                    mail.To.Add(emailDestinatario);
                    mail.Subject = txtOggetto.Text;
                    mail.Body = txtMessage.Text;
                    mail.IsBodyHtml = false;

                    using (var smtp = new SmtpClient(smtpServer, int.Parse(smtpPort)))
                    {
                        smtp.Credentials = new NetworkCredential(
                            emailMittente,
                            passwordApp
                        );
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore durante l'invio della mail:\n" + ex.Message,
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            MessageBox.Show(
                "Mail inviata con successo.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


    }
}
