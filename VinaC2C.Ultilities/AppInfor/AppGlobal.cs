using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VinaC2C.Ultilities.AppInfor
{
    public class AppGlobal
    {
        public static string SecretKey
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();
                return configurationRoot.GetSection("SecretKey").Value.ToString();
            }
        }
    }
}
