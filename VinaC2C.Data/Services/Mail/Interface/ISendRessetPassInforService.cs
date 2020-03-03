using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinaC2C.Data.Services.Mail.Interface
{
    public interface ISendRessetPassInforService : ISendMailService
    {
        public void SendLinkReset(Data.Models.Mail mail);

        public Task SendLinkResetAsync(Data.Models.Mail mail);
    }
}
