using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinaC2C.Data.DataTransferObject;

namespace VinaC2C.MVC.Models
{
    public class FeatureRoleModel
    {
        public FeatureRoleModel()
        {
            users = new List<UserSelect>();
        }

        public List<UserSelect> users { get; set; }

        [BindProperty]
        public int UserID { get; set; }

        public SelectList userOptions { get; set; }
    }
}
