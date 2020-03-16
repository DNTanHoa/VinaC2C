using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.Feature.Interface;

namespace VinaC2C.Data.Services.DigitalShop
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
