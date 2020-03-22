using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class ServiceTicket : ObjectBaseModel
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int? DateCycleExpire { get; set; }

        public bool IsFree { get; set; }
    }
}
