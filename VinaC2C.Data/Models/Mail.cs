using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Data.Models
{
    public class Mail : BaseModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public int SMTPPort { get; set; }

        public string SMTPServer { get; set; }

        public bool IsUsingSSL { get; set; }

        public string FromMail { get; set; }

        public string ToMail { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }

        public string DisplayName { get; set; }

    }
}
