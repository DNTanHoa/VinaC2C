using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class UnitConvert : ObjectBaseModel 
    {
        public Int64? SourceUnit { get; set; }

        public Int64? DestinationUnit { get; set; }

        public decimal? SourceCoefficient { get; set; }

        public decimal? DestinationCoefficient { get; set; }

        public Int64 UserID { get; set; }
    }
}
