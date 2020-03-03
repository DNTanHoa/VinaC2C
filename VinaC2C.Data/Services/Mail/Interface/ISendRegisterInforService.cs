using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinaC2C.Data.Services.Mail.Interface
{
    public interface ISendRegisterInforService : ISendMailService
    {
        public void SendConfirmLink(Data.Models.Mail mail);

        public Task SendConfirmLinkAsync(Data.Models.Mail mail);
    }
}
