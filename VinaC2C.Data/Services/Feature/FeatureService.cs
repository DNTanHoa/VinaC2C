using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Services.Feature.Interface;

namespace VinaC2C.Data.Services.Feature
{
    public class FeatureService : ServiceBase<Data.Models.Feature>, IFeatureService
    {
        private readonly VinaC2CContext _context;

        public FeatureService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }

    }
}
