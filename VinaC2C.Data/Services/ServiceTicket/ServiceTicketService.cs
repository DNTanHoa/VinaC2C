﻿using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Context;

namespace VinaC2C.Data.Services
{
    public class ServiceTicketService : ServiceBase<Data.Models.ServiceTicket>, IServiceTicketService
    {
        private readonly VinaC2CContext _context;

        public ServiceTicketService(VinaC2CContext context) : base(context)
        {
            this._context = context;
        }
    }
}
