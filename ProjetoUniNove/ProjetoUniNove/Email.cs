using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace ProjetoUniNove
{
    public class Email
    {
        static void enviarEmail(String emailDestinatario, String codigo)
        {           
            try
            {//                                                    DE                        PARA
                MailMessage mailMessage = new MailMessage("projetootchealth@gmail.com", emailDestinatario);

                mailMessage.Subject = "Confirmação de Email"; //Titulo do E-Mail
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $"<p>Não compartilhe a senha com ninguem</p></br><p>{codigo}</p>"; //Mensagem do E-Mail
                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("projetootchealth@gmail.com", "teste@123");//email que vai enviar para outras pessoas
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                
            }
        }
    } 
}

