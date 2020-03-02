using Microsoft.EntityFrameworkCore;
using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Helpers;

namespace VinaC2C.Data.Services.User
{
    public class UserService : ServiceBase<Data.Models.User>, IUserService
    {
        private readonly VinaC2CContext _context;

        public UserService(VinaC2CContext context): base(context)
        {
            this._context = context;
        }

        public async Task<bool> LoginByUsernameAndPassword(string username = "", string password = "")
        {
            string sceretKey = AppGlobal.SecretKey;
            var loginUser = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username) &&
                                                                             user.Password.Equals(PasswordHelper.Encrypt(sceretKey, password)));
            return loginUser != null ? true : false;
        }
    }
}
