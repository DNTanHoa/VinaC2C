using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VinaC2C.Ultilities.AppInfor
{
    public class AppGlobal
    {
        /// <summary>
        /// Key for determine who can login to system
        /// </summary>
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

        /// <summary>
        /// Path for html template file for send mail
        /// </summary>
        public static string MailTemplatePath
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();
                return configurationRoot.GetSection("MailTemplatePath").Value.ToString();
            }
        }

        /// <summary>
        /// Config Mail For System
        /// </summary>
        public static string FromMail
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();
                return configurationRoot.GetSection("FromMail").Value.ToString();
            }
        }

        /// <summary>
        /// STMP Server for send mail
        /// </summary>
        public static string SMTPServer
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();
                return configurationRoot.GetSection("SMTPServer").Value.ToString();
            }
        }

        /// <summary>
        /// All Mail Object
        /// </summary>
        public static object MailObject
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();
                return configurationRoot.GetSection("MailObject") as object;
            }
        }

        /// <summary>
        /// SMTP Port
        /// </summary>
        public static int SMTPPort
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return int.Parse(configurationRoot.GetSection("SMTPPort").Value.ToString());

            }
        }

        /// <summary>
        /// Mail Username
        /// </summary>
        public static string MailUserName
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("MailUser").Value.ToString();
            }
        }

        /// <summary>
        /// Mail Username
        /// </summary>
        public static string MailPassword
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("MailPassword").Value.ToString();
            }
        }

        /// <summary>
        /// RegisterMailDisplayName
        /// </summary>
        public static string RegisterMailDisplayName
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("RegisterMailDisplayName").Value.ToString();
            }
        }

        /// <summary>
        /// RegisterMailSubject
        /// </summary>
        public static string RegisterMailSubject
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("RegisterMailSubject").Value.ToString();
            }
        }

        /// <summary>
        /// RegisterMailTemplatePath
        /// </summary>
        public static string RegisterMailTemplatePath
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("RegisterMailTemplatePath").Value.ToString();
            }
        }

    }
}
