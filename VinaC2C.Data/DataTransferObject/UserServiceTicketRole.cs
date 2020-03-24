using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.DataTransferObject
{
    public class UserServiceTicketRole
    {
        public Int64 Id { get; set; }

        public string Name { get; set; }

        public bool IsAllow { get; set; }

        public Int64 ServiceTicketID { get; set; }
        
        public DateTime? ExpiredDate { get; set; }

        public Int64 UserID { get; set; }
    }
}
