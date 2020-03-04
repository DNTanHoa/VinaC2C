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

        public  async Task<bool> IsExistEmail(string email)
        {
            var existUserEmail = await _context.Users.FirstOrDefaultAsync(user => user.Email.Equals(email));
            return existUserEmail != null ? true : false;
        }

        public async Task<bool> IsExistUsername(string username)
        {
            var existUsername= await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username));
            return existUsername != null ? true : false;
        }

        public Task<bool> LoginByEmailAndPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginByUsernameAndPassword(string username = "", string password = "")
        {
            //TODO: Only get active user
            string sceretKey = AppGlobal.SecretKey;
            var loginUser = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(username) &&
                                                                             user.Password.Equals(PasswordHelper.Encrypt(sceretKey, password)));
            return loginUser != null ? true : false;
        }

        public async Task<int> RegisterUserDefautl(Models.User user)
        {
            string sceretKey = AppGlobal.SecretKey;
            string storedPassword = PasswordHelper.Encrypt(sceretKey,user.Password);
            user.Password = storedPassword;
            return await this.CreateAsync(user);
        }
    }
}
