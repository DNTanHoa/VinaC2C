using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VinaC2C.Data.DataTransferObject;

namespace VinaC2C.Data.Services
{
    public interface IServiceTicketRoleService : IServiceBase<Data.Models.ServiceTicketRole>
    {
        public List<UserServiceTicketRole> GetServiceTicketByUsername(string username);

        public List<UserServiceTicketRole> InitializeUserServiceTicketRole(Int64 UserID);

        public List<UserServiceTicketRole> GetServiceTicketByUserID(Int64 UserID);

        public int SaveChange(List<Models.ServiceTicketRole> serviceTicketRoles);
    }
}
