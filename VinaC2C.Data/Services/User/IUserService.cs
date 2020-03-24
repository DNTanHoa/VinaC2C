using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.DataTransferObject;

namespace VinaC2C.Data.Services
{
    public interface IUserService : IServiceBase<Data.Models.User>
    {
        public Task<bool> LoginByUsernameAndPassword(string username, string password);
        
        public Task<bool> LoginByEmailAndPassword(string email, string password);

        public Task<int> RegisterUserDefautl(Data.Models.User user);
        
        public Task<bool> IsExistEmail(string email);
        
        public Task<bool> IsExistUsername(string username);

        public Task<List<UserSelect>> GetForSelectList();

        public Models.User GetByUsername(string username);
    }
}
