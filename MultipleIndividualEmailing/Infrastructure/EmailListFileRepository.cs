using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MultipleIndividualEmailing.DomainModel;
using MultipleIndividualEmailing.DomainServices;

namespace MultipleIndividualEmailing.Infrastructure
{
    class EmailListFileRepository:IEmailListRepository
    {
        public void Create(EmailList emailList)
        {
        }

        public void Delete(EmailList emailList)
        {
        }

        public void Update(EmailList emailList)
        {
        }

        public EmailList Read(string name)
        {
            var json = File.ReadAllText($"EmailLists/{name}.json");
            var emailList = JsonSerializer.Deserialize<EmailList>(json);
            return emailList;
        }

        public IEnumerable<string> ReadAll()
        {
            return Directory
                .GetFiles("EmailLists")
                .Select(
                    fileName=>
                        fileName.Replace(".json", "")
                                .Replace("EmailLists\\", "")
                        );
        }
    }
}
