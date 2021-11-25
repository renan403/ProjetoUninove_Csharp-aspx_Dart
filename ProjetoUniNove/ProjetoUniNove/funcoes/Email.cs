using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ProjetoUniNove
{
    public class Email
    {

        public void EnviarEmail(String emailDestinatario, String codigo)
        {
            try
            {//                                                    DE                        PARA
                MailMessage mailMessage = new MailMessage("projetootchealth@gmail.com", emailDestinatario)
                {
                    Subject = "Confirmação de Email", //Titulo do E-Mail
                    IsBodyHtml = true,
                    Body = $"<p>Não compartilhe a senha com ninguem</p></br><h3>{codigo}</h3>", //Mensagem do E-Mail
                    SubjectEncoding = Encoding.GetEncoding("UTF-8"),
                    BodyEncoding = Encoding.GetEncoding("UTF-8")
                };

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("projetootchealth@gmail.com", "teste@123"),//email que vai enviar para outras pessoas
                    EnableSsl = true
                };// Servidor do Gmail
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {

            }
        }

    }
}

