using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using VinaC2C.Data.Services.Mail.Interface;

namespace VinaC2C.Data.Services.Mail
{
    public class SendMailService : ISendMailService
    {
        public void Initialization(Models.Mail mail, out MailMessage message, out SmtpClient client)
        {
            message = new MailMessage();
            message.IsBodyHtml = mail.IsBodyHtml;
            message.BodyEncoding = Encoding.GetEncoding("UTF-8");
            message.From = new MailAddress(mail.FromMail, mail.DisplayName);
            message.To.Add(new MailAddress(mail.ToMail));
            message.Subject = mail.Subject;
            message.Body = mail.Body;
            message.Priority = MailPriority.High;

            client = new SmtpClient();
            client.EnableSsl = mail.IsUsingSSL;
            client.Host = mail.SMTPServer;
            client.Port = mail.SMTPPort;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(mail.Username, mail.Password);
        }

        public void Send(Models.Mail mail)
        {
            Initialization(mail, out MailMessage message, out SmtpClient client);
            client.Send(message);
        }

        public async Task SendAsync(Models.Mail mail)
        {
            Initialization(mail, out MailMessage message, out SmtpClient client);
            await client.SendMailAsync(message);
        }
    }
}
