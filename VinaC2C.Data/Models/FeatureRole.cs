using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class FeatureRole : ObjectBaseModel
    {
        public Int64 FeatureID { get; set; }

        public Int64 UserID { get; set; }

        public bool IsAllow { get; set; }
    }
}
