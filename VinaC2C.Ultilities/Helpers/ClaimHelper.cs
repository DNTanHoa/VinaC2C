using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace VinaC2C.Ultilities.Helpers
{
    public class ClaimHelper
    {
        public static List<Claim> GetListFromObject(object obj)
        {
            List<Claim> result = new List<Claim>();
            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach(var prop in props)
            {
                string type = prop.Name;
                string value = prop.GetValue(obj) != null? prop.GetValue(obj).ToString() : "";
                Claim claim = new Claim(type, value);
                result.Add(claim);
            }
            return result;
        }
    }
}
