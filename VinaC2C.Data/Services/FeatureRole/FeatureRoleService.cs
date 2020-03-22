using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.Feature.Interface;
using VinaC2C.Data.DataTransferObject;

namespace VinaC2C.Data.Services.Feature
{
    public class FeatureRoleService : ServiceBase<Data.Models.FeatureRole>, IFeatureRoleService
    {
        private readonly VinaC2CContext _context;

        public FeatureRoleService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }

        public List<UserFeatureRole> GetFeatureByUserID(int UserID)
        {
            var featureRoles = (from FeatureRole in _context.FeatureRoles
                                join Feature in _context.Features on FeatureRole.FeatureID equals Feature.Id
                                join user in _context.Users on FeatureRole.UserID equals user.Id
                                where user.Id == UserID
                                select new UserFeatureRole
                                {
                                    Id = FeatureRole.Id,
                                    Name = Feature.Name,
                                    IsAllow = FeatureRole.IsAllow,
                                    SortOrder = Feature.SortOrder
                                }).ToList();
            return featureRoles;
        }

        public List<UserFeatureRole> GetFeatureByUsername(string username)
        {
            var featureRoles = (from FeatureRole in _context.FeatureRoles
                                join Feature in _context.Features on FeatureRole.FeatureID equals Feature.Id
                                join user in _context.Users on FeatureRole.UserID equals user.Id
                                where user.Username == username
                                select new UserFeatureRole
                                {
                                    Id = FeatureRole.Id,
                                    Name = Feature.Name,
                                    IsAllow = FeatureRole.IsAllow,
                                    SortOrder = Feature.SortOrder
                                }).ToList();
            return featureRoles;
        }

        public List<UserFeatureRole> InitializeUserFeatureRole()
        {
            var featureRoles = (from Feature in _context.Features
                               select new UserFeatureRole
                               {
                                   Id = 0,
                                   Name = Feature.Name,
                                   FeatureID = Feature.Id,
                                   IsAllow = false,
                                   SortOrder = Feature.SortOrder
                               }).ToList();

            return featureRoles;
        }

        public int SaveChange(List<UserFeatureRole> userFeatureRoles, bool isAllowAll = false)
        {
            throw new NotImplementedException();
        }
    }
}
