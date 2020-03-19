using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.Feature.Interface;

namespace VinaC2C.Data.Services.Feature
{
    public class FeatureRoleService : ServiceBase<Data.Models.FeatureRole>, IFeatureRoleService
    {
        private readonly VinaC2CContext _context;

        public FeatureRoleService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
