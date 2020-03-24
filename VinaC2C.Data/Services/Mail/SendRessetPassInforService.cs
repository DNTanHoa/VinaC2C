using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinaC2C.Data.Services
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
