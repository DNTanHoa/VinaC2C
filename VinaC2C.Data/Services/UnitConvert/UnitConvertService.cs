using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;

namespace VinaC2C.Data.Services
{
    public class UnitConvertService : ServiceBase<Data.Models.UnitConvert>, IUnitConvertService
    {
        private readonly VinaC2CContext _context;

        public UnitConvertService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
