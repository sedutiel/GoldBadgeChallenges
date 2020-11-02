using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Campaign
{
    class Recipients
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerType { get; set; }
        public Recipients(string firstName, string lastName, string emailAddress, int customerType)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CustomerType = customerType;
        }
    }
}
