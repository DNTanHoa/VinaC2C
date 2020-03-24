using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class UserShop : ObjectBaseModel
    {
        public Int64 UserID { get; set; }

        public Int64 DigitalShopID { get; set; }

        public string ShopClientKey { get; set; }

        public string ShopScretKey { get; set; }
    }
}
