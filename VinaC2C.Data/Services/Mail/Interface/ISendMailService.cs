using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace VinaC2C.Data.Services
{
    public interface ISendMailService
    {
        public Task SendAsync(Data.Models.Mail mail);

        public void Send(Data.Models.Mail mail);

        public void Initialization(Data.Models.Mail mail, out MailMessage message, out SmtpClient client);
    }
}
