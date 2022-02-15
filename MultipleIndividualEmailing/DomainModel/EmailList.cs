using System.Collections.Generic;

namespace MultipleIndividualEmailing.DomainModel
{
    class EmailList
    {
        public string Name { get; set; }
        public IEnumerable<string> EmailAddresses { get; set; }

        public EmailList()
        {
            
        }
        public EmailList(string name, IEnumerable<string> emailAddresses)
        {
            Name = name;
            EmailAddresses = emailAddresses;
        }
    }
}
