using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VinaC2C.Data.Services
{
    public class SendRegisterInforService : SendMailService, ISendRegisterInforService
    {
        public void SendConfirmLink(Data.Models.User registerUser, string templatePath)
        {
            StreamReader streamReader = new StreamReader(templatePath);
            StringBuilder stringBuilder = new StringBuilder(streamReader.ReadToEnd());
            streamReader.Close();
            stringBuilder.Replace(@"[ActiveLink]", "https://google.com");

            var mail = new Models.Mail();
            mail.FromMail = Ultilities.AppInfor.AppGlobal.FromMail;
            mail.DisplayName = Ultilities.AppInfor.AppGlobal.RegisterMailDisplayName;
            mail.Subject = Ultilities.AppInfor.AppGlobal.RegisterMailSubject;
            mail.SMTPServer = Ultilities.AppInfor.AppGlobal.SMTPServer;
            mail.SMTPPort = Ultilities.AppInfor.AppGlobal.SMTPPort;
            mail.Username = Ultilities.AppInfor.AppGlobal.MailUserName;
            mail.Password = Ultilities.AppInfor.AppGlobal.MailPassword;
            mail.IsUsingSSL = true;
            mail.IsBodyHtml = true;
            mail.Body = stringBuilder.ToString();
            mail.ToMail = registerUser.Email;
            this.Send(mail);
        }

        public Task SendConfirmLinkAsync(Models.Mail mail)
        {
            throw new NotImplementedException();
        }
    }
}
