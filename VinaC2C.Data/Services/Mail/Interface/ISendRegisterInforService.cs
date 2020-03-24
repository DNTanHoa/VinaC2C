using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinaC2C.Data.Services
{
    public interface ISendRegisterInforService : ISendMailService
    {
        public void SendConfirmLink(Data.Models.User registerUser, string templatePath);

        public Task SendConfirmLinkAsync(Data.Models.Mail mail);
    }
}
