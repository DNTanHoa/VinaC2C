using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class Feature : ObjectBaseModel
    {
        public string Name { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }

        public bool IsMenuLeft { get; set; }

        public int ParentFeatureID { get; set; }
    }
}
