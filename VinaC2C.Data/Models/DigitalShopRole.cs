using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class DigitalShopRole : ObjectBaseModel
    {
        public Int64 DigitalShopID { get; set; }

        public Int64 UserID { get; set; }

        public bool IsAllow { get; set; }
    }
}
