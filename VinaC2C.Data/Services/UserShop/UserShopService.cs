using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;

namespace VinaC2C.Data.Services
{
    public class UserShopService : ServiceBase<Data.Models.UserShop>, IUserShopService
    {
        private readonly VinaC2CContext _context;

        public UserShopService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
