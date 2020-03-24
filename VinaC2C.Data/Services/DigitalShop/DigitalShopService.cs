using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;

namespace VinaC2C.Data.Services
{
    public class DigitalShopService : ServiceBase<Data.Models.DigitalShop>, IDigitalShopService
    {
        private readonly VinaC2CContext _context;

        public DigitalShopService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
