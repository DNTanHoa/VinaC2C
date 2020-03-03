using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Services.Mail.Interface;

namespace VinaC2C.Data.Services.Mail
{
    public class SendRegisterInforService : SendMailService, ISendRegisterInforService
    {
        public void SendConfirmLink(Models.Mail mail)
        {
            throw new NotImplementedException();
        }

        public Task SendConfirmLinkAsync(Models.Mail mail)
        {
            throw new NotImplementedException();
        }
    }
}
