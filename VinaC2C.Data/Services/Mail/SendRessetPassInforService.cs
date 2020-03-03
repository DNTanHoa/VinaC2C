using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Services.Mail.Interface;

namespace VinaC2C.Data.Services.Mail
{
    public class SendRessetPassInforService : SendMailService, ISendRessetPassInforService
    {
        public void SendLinkReset(Models.Mail mail)
        {
            throw new NotImplementedException();
        }

        public Task SendLinkResetAsync(Models.Mail mail)
        {
            throw new NotImplementedException();
        }
    }
}
