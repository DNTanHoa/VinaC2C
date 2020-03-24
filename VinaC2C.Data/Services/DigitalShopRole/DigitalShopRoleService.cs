using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VinaC2C.Data.Context;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Services
{
    public class DigitalShopRoleService : ServiceBase<Data.Models.DigitalShopRole>, IDigitalShopRoleService
    {
        private readonly VinaC2CContext _context;

        public DigitalShopRoleService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }

        public List<UserDigitalShopRole> GetDigitalShopByUsername(string username)
        {
            var digitalShopRoles = (from DigitalShopRole in _context.DigitalShopRoles
                                    join DigitalShop in _context.Features on DigitalShopRole.DigitalShopID equals DigitalShop.Id
                                    join user in _context.Users on DigitalShopRole.UserID equals user.Id
                                    where user.Username == username
                                    select new UserDigitalShopRole
                                    {
                                        Id = DigitalShopRole.Id,
                                        Name = DigitalShop.Name,
                                        IsAllow = DigitalShopRole.IsAllow,
                                    }).ToList();
            return digitalShopRoles;
        }

        public List<UserDigitalShopRole> GetDigitalShopByUserID(Int64 UserID)
        {
            var digitalShopRoles = (from DigitalShopRole in _context.DigitalShopRoles
                                    join DigitalShop in _context.Features on DigitalShopRole.DigitalShopID equals DigitalShop.Id
                                    join user in _context.Users on DigitalShopRole.UserID equals user.Id
                                    where user.Id == UserID
                                    select new UserDigitalShopRole
                                    {
                                        Id = DigitalShopRole.Id,
                                        Name = DigitalShop.Name,
                                        DigitalShopID = DigitalShop.Id,
                                        IsAllow = DigitalShopRole.IsAllow,
                                    }).ToList();
            return digitalShopRoles;
        }

        public List<UserDigitalShopRole> InitializeUserDigitalShopRole(Int64 UserID)
        {
            _context.DigitalShopRoles.RemoveRange(_context.DigitalShopRoles.Where(item => item.UserID == UserID));
            _context.SaveChanges();

            var digitalShopRoles = (from DigitalShop in _context.DigitalShops
                                select new UserDigitalShopRole
                                {
                                    Id = 0,
                                    Name = DigitalShop.Name,
                                    DigitalShopID = DigitalShop.Id,
                                    UserID = UserID,
                                    IsAllow = false
                                }).ToList();
            return digitalShopRoles;
        }

        public int SaveChange(List<DigitalShopRole> digitalShopRoles)
        {
            _context.DigitalShopRoles.AddRange(digitalShopRoles);
            return _context.SaveChanges();
        }
    }
}
