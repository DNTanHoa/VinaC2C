using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;

namespace VinaC2C.Data.Services
{
    public class UnitService : ServiceBase<Data.Models.Unit>, IUnitService
    {
        private readonly VinaC2CContext _context;

        public UnitService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
