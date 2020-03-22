using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class ServiceTicketRole : ObjectBaseModel
    {
        public Int64 ServiceTicketID { get; set; }

        public Int64 UserID { get; set; }

        public bool IsAllow { get; set; }

        public DateTime? ExpireDate { get; set; }
    }
}
