using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02_Komodo_Email_Repo
{
    public class Email_Message
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public Email_Message() { }
        public Email_Message(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}