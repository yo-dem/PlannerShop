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

        private string locandinaPath = string.Empty;

        public SendMailForm(string emailDestinatario)
        {
            InitializeComponent();
            this.emailMittente = ModelOpzioni.GetOpzione("mailgest");
            this.passwordApp = ModelOpzioni.GetOpzione("pwdmailgest");
            this.smtpServer = ModelOpzioni.GetOpzione("smtpmailgest");
            this.smtpPort = ModelOpzioni.GetOpzione("portmailgest");

            this.emailDestinatario = emailDestinatario;

            lblNomeLocandina.Text = "Nessuna locandina selezionata";

            picAnteprima.Image = null;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOggetto.Text))
            {
                MessageBox.Show(
                    "Inserire un oggetto per la mail.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show(
                    "Inserire un messaggio per la mail.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //if (string.IsNullOrEmpty(locandinaPath) || !File.Exists(locandinaPath))
            //{
            //    MessageBox.Show(
            //        "Selezionare una locandina valida.",
            //        "Attenzione",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //    );
            //    return;
            //}

            try
            {
                string htmlBody = @"
                    <!DOCTYPE html>
                    <html>
                    <body style='margin:0;padding:0;'>
                    <table width='100%' cellpadding='0' cellspacing='0'>
                        <tr>
                            <td align='center'>
                                <table width='600' height='800' style='
                                    background-image: url(""cid:locandina"");
                                    background-size: cover;
                                    background-position: center;
                                    font-family: Arial, sans-serif;
                                    color: #ffffff;
                                '>
                                    <tr>
                                        <td style='padding:40px; vertical-align:bottom;'>
                                            <h1>" + WebUtility.HtmlEncode(txtOggetto.Text) + @"</h1>
                                            <p>" + WebUtility.HtmlEncode(txtMessage.Text).Replace("\n", "<br>") + @"</p>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    </body>
                    </html>";

                try
                {
                    btnOk.Enabled = false;
                    progressBarSend.Visible = true;

                    await Task.Run(() =>
                    {
                        using (var mail = new MailMessage())
                        {
                            mail.From = new MailAddress(emailMittente, "AL NA’IR, Centro Estetico");
                            mail.To.Add(emailDestinatario);
                            mail.Subject = txtOggetto.Text;

                            if (!string.IsNullOrEmpty(locandinaPath) && File.Exists(locandinaPath))
                            {
                                // MAIL HTML CON LOCANDINA
                                mail.IsBodyHtml = true;

                                var htmlView = AlternateView.CreateAlternateViewFromString(
                                    htmlBody,
                                    null,
                                    "text/html"
                                );

                                var locandina = new LinkedResource(locandinaPath)
                                {
                                    ContentId = "locandina",
                                    TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                                };

                                htmlView.LinkedResources.Add(locandina);
                                mail.AlternateViews.Add(htmlView);
                            }
                            else
                            {
                                // MAIL TESTUALE NORMALE
                                mail.IsBodyHtml = false;
                                mail.Body = txtMessage.Text;
                            }

                            using (var smtp = new SmtpClient(smtpServer, int.Parse(smtpPort)))
                            {
                                smtp.Credentials = new NetworkCredential(emailMittente, passwordApp);
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                            }
                        }

                    });

                    //MessageBox.Show(
                    //    "Mail inviata con successo.",
                    //    "Info",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information
                    //);
                    locandinaPath = string.Empty;
                    lblNomeLocandina.Text = "Nessuna locandina selezionata";
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
                finally
                {
                    progressBarSend.Visible = false;
                    btnOk.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Errore imprevisto:\n" + ex.Message,
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCaricaLocandina_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Immagini|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    locandinaPath = ofd.FileName;
                    lblNomeLocandina.Text = Path.GetFileName(locandinaPath);

                    // evita lock del file
                    using (var img = Image.FromFile(locandinaPath))
                    {
                        picAnteprima.Image?.Dispose();
                        picAnteprima.Image = new Bitmap(img);
                    }
                }
            }
        }
    }
}
