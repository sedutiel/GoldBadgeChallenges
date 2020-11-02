
using Email_Campaign;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Email_Repo
{
    public class Email_Repo
    {
        private List<Email_Message> __email = new List<Email_Message>();
        private List<Recipients> _repo = new List<Recipients>();

        public bool AddRecipient(Recipients recipient)
        {
            int startingCount = _repo.Count;
            _repo.Add(recipient);

            bool wasAdded = (_repo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<Recipients> ShowAllRecipients()
        {
            return _repo;
        }

        public bool DeleteRecipient(Recipients recipients)
        {
            int startingCount = _repo.Count;
            _repo.Remove(recipients);

            bool wasDeleted = (_repo.Count < startingCount) ? true : false;
            return wasDeleted;
        }

        public Recipients ShowByLastName(string lastname)
        {
            foreach (Recipients recipients in _repo)
            {
                if (recipients.LastName.ToLower() == lastname.ToLower())
                {
                    return recipients;
                }
            }
            return null;
        }

        public bool UpdateRecipient(string originalRecipient, Recipients newRecipient)
        {
            Recipients recipients = ShowByLastName(originalRecipient);

            if (recipients != null)
            {
                recipients.FirstName = newRecipient.FirstName;
                recipients.LastName = newRecipient.FirstName;
                recipients.CustomerType = newRecipient.CustomerType;
                recipients.EmailAddress = newRecipient.EmailAddress;
                //recipient.Message = newRecipient.Message;

                return true;
            }
            else { return false; }
        }
    }
}