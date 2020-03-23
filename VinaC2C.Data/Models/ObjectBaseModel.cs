using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;
using VinaC2C.Ultilities.Helpers;

namespace VinaC2C.Data.Models
{
    public class ObjectBaseModel : BaseModel
    {
        public void Initialization(ObjectInitType initType, string requestUser, HttpContext context = null)
        {
            if (string.IsNullOrEmpty(requestUser) && context != null)
                requestUser = CookieHelper.GetValueByKeyFromClaim(nameof(Models.User.Username), context);

            if (initType == ObjectInitType.Insert)
            {
                this.CreateDate = AppGlobal.SystemDateTime;
                this.CreateUser = requestUser;
            }
            this.UpdateDate = AppGlobal.SystemDateTime;
            this.UpdateUser = requestUser;
        }

        public bool GCRecord { get; set; }

        public string CreateUser { get; set; }

        public string UpdateUser { get; set; }

        public string Note { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
