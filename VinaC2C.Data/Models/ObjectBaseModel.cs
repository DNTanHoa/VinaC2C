﻿using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;

namespace VinaC2C.Data.Models
{
    public class ObjectBaseModel : BaseModel
    {
        public void Initialization(ObjectInitType initType, string requestUser)
        {
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
