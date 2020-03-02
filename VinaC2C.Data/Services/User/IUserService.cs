using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Services.Common;

namespace VinaC2C.Data.Services.User
{
    public interface IUserService : IServiceBase<Data.Models.User>
    {
        public Task<bool> LoginByUsernameAndPassword(string username, string password);
    }
}
