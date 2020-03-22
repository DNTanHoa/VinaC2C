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

        /// <summary>
        /// Get Current WebServer Time
        /// </summary>
        public static DateTime SystemDateTime => DateTime.Now;

        /// <summary>
        /// Get Current WebServer Day
        /// </summary>
        public static DateTime SystemDate => DateTime.Today;

        /// <summary>
        /// Get Current WebServer Day
        /// </summary>
        public static int SystemDay => DateTime.Today.Day;

        /// <summary>
        /// Get Current WebServer Month
        /// </summary>
        public static int SystemMonth => DateTime.Today.Month;

        /// <summary>
        /// Get Current WebServer Month
        /// </summary>
        public static int SystemYear => DateTime.Today.Year;

        /// <summary>
        /// Get Current System Datetime String
        /// </summary>
        public static string SystemDateString => DateTime.Now.ToString("yyyyMMddd");

        /// <summary>
        /// Insert Success Message
        /// </summary>
        public static string InsertSuccessMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("InsertSuccessMessage").Value.ToString();
            }
        }

        /// <summary>
        /// Insert Fail Message
        /// </summary>
        public static string InsertFailMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("InsertFailMessage").Value.ToString();
            }
        }

        /// <summary>
        /// Delete Success Message
        /// </summary>
        public static string DeleteSuccessMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("DeleteSuccessMessage").Value.ToString();
            }
        }
        
        /// <summary>
        /// Delete Success Message
        /// </summary>
        public static string DeleteFailMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("DeleteFailMessage").Value.ToString();
            }
        }

        /// <summary>
        /// Update Success Message
        /// </summary>
        public static string UpdateSuccessMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("UpdateSuccessMessage").Value.ToString();
            }
        }

        /// <summary>
        /// Update Fail Message
        /// </summary>
        public static string UpdateFailMessage
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("UpdateFailMessage").Value.ToString();
            }
        }

        /// <summary>
        /// Login Path
        /// </summary>
        public static string LoginPath
        {
            get
            {
                IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                           .SetBasePath(Directory.GetCurrentDirectory())
                                                           .AddJsonFile("appsettings.json")
                                                           .Build();
                return configurationRoot.GetSection("LoginPath").Value.ToString();
            }
        }
    }
}
