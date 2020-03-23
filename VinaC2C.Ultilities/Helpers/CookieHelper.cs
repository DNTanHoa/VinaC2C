using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Ultilities.Helpers
{
    public class CookieHelper
    {
        public static string GetValueByKeyFromRequest(string key, HttpRequest request)
        {
            try
            {
                return request.Cookies[key].ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetValueByKeyFromClaim(string key, HttpContext context)
        {
            try
            {
                var principals = context.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme).Result.Principal;
                return principals.FindFirst(key).Value;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
