using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Services.Common;

namespace VinaC2C.Data.Services.Feature.Interface
{
    public interface IDigitalShopRoleService : IServiceBase<Data.Models.DigitalShopRole>
    {
        public List<UserDigitalShopRole> GetDigitalShopByUsername(string username);

        public List<UserDigitalShopRole> InitializeUserDigitalShopRole();
    }
}
