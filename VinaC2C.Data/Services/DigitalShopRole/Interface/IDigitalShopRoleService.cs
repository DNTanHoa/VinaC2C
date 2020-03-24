using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.DataTransferObject;

namespace VinaC2C.Data.Services
{
    public interface IDigitalShopRoleService : IServiceBase<Data.Models.DigitalShopRole>
    {
        public List<UserDigitalShopRole> GetDigitalShopByUsername(string username);

        public List<UserDigitalShopRole> InitializeUserDigitalShopRole(Int64 UserID);

        public List<UserDigitalShopRole> GetDigitalShopByUserID(Int64 UserID);

        public int SaveChange(List<Models.DigitalShopRole> digitalShopRoles);
    }
}
