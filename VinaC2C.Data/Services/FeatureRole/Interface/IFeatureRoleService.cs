using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Services.Common;

namespace VinaC2C.Data.Services.Feature.Interface
{
    public interface IFeatureRoleService : IServiceBase<Data.Models.FeatureRole>
    {
        public List<UserFeatureRole> GetFeatureByUsername(string username);

        public List<UserFeatureRole> InitializeUserFeatureRole(Int64 UserID);

        public List<UserFeatureRole> GetFeatureByUserID(Int64 UserID);

        public int SaveChange(List<Models.FeatureRole> featureRoles);
    }
}
