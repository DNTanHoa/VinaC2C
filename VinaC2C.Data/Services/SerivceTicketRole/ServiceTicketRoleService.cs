using POSBlazor.Data.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.Feature.Interface;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Ultilities.AppInfor;

namespace VinaC2C.Data.Services.Feature
{
    public class ServiceTicketRoleService : ServiceBase<Data.Models.ServiceTicketRole>, IServiceTicketRoleService
    {
        private readonly VinaC2CContext _context;

        public ServiceTicketRoleService(VinaC2CContext context) : base(context)
        {
            this._context = context;
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
                                          IsAllow = ServiceTicketRole.IsAllow,
                                          ExpiredDate = ServiceTicketRole.ExpireDate
                                      }).ToList();
            return serviceTicketRoles;
        }

        public List<UserServiceTicketRole> InitializeUserServiceTicketRole()
        {
            var userServiceTicketRole = (from ServiceTicket in _context.ServiceTickets
                                         select new UserServiceTicketRole
                                         {
                                            Id = 0,
                                            Name = ServiceTicket.Name,
                                            ServiceTicketID = ServiceTicket.Id,
                                            IsAllow = false,
                                            ExpiredDate = ServiceTicket.DateCycleExpire != null ? (DateTime?)AppGlobal.SystemDate.AddDays((int)ServiceTicket.DateCycleExpire) : null
                                         }).ToList();

            return userServiceTicketRole;
        }
    }
}
