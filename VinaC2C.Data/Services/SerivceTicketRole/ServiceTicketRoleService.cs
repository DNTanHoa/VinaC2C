using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Services
{
    public class ServiceTicketRoleService : ServiceBase<Data.Models.ServiceTicketRole>, IServiceTicketRoleService
    {
        private readonly VinaC2CContext _context;

        public ServiceTicketRoleService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }

        public List<UserServiceTicketRole> GetServiceTicketByUserID(Int64 UserID)
        {
            var serviceTicketRoles = (from ServiceTicketRole in _context.ServiceTicketRoles
                                      join ServiceTicket in _context.ServiceTickets on ServiceTicketRole.ServiceTicketID equals ServiceTicket.Id
                                      join user in _context.Users on ServiceTicketRole.UserID equals user.Id
                                      where user.Id == UserID
                                      select new UserServiceTicketRole
                                      {
                                          Id = ServiceTicketRole.Id,
                                          Name = ServiceTicket.Name,
                                          ServiceTicketID = ServiceTicket.Id,
                                          IsAllow = ServiceTicketRole.IsAllow,
                                          ExpiredDate = ServiceTicketRole.ExpireDate
                                      }).ToList();
            return serviceTicketRoles;
        }

        public List<UserServiceTicketRole> GetServiceTicketByUsername(string username)
        {
            var serviceTicketRoles = (from ServiceTicketRole in _context.ServiceTicketRoles
                                      join ServiceTicket in _context.ServiceTickets on ServiceTicketRole.ServiceTicketID equals ServiceTicket.Id
                                      join user in _context.Users on ServiceTicketRole.UserID equals user.Id
                                      where user.Username == username
                                      select new UserServiceTicketRole
                                      {
                                          Id = ServiceTicketRole.Id,
                                          Name = ServiceTicket.Name,
                                          ServiceTicketID = ServiceTicket.Id,
                                          IsAllow = ServiceTicketRole.IsAllow,
                                          ExpiredDate = ServiceTicketRole.ExpireDate
                                      }).ToList();
            return serviceTicketRoles;
        }

        public List<UserServiceTicketRole> InitializeUserServiceTicketRole(Int64 UserID)
        {
            _context.ServiceTicketRoles.RemoveRange(_context.ServiceTicketRoles.Where(item => item.UserID == UserID));
            _context.SaveChanges();

            var userServiceTicketRole = (from ServiceTicket in _context.ServiceTickets
                                         select new UserServiceTicketRole
                                         {
                                            Id = 0,
                                            Name = ServiceTicket.Name,
                                            ServiceTicketID = ServiceTicket.Id,
                                            IsAllow = false,
                                            UserID = UserID,
                                            ExpiredDate = ServiceTicket.DateCycleExpire != null ? (DateTime?)AppGlobal.SystemDate.AddDays((int)ServiceTicket.DateCycleExpire) : null
                                         }).ToList();

            return userServiceTicketRole;
        }

        public int SaveChange(List<ServiceTicketRole> serviceTicketRoles)
        {
            _context.ServiceTicketRoles.AddRange(serviceTicketRoles);
            return _context.SaveChanges();
        }
    }
}
