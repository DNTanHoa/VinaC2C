﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Services.Common;

namespace VinaC2C.Data.Services.Feature.Interface
{
    public interface IServiceTicketRoleService : IServiceBase<Data.Models.ServiceTicketRole>
    {
        public List<UserServiceTicketRole> GetServiceTicketByUsername(string username);

        public List<UserServiceTicketRole> InitializeUserServiceTicketRole();
    }
}
