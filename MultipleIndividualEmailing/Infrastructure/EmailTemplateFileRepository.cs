using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MultipleIndividualEmailing.DomainModel;
using MultipleIndividualEmailing.DomainServices;

namespace MultipleIndividualEmailing.Infrastructure
{
    class EmailTemplateFileRepository : IEmailTemplateRepository
    {
        public void Create(EmailTemplate emailList)
        {
        }

        public void Delete(EmailTemplate emailList)
        {
        }

        public void Update(EmailTemplate emailList)
        {
        }

        public EmailTemplate Read(string name)
        {
            var json = File.ReadAllText($"EmailTemplates/{name}.json");
            var emailTemplate = JsonSerializer.Deserialize<EmailTemplate>(json);
            return emailTemplate;
        }

        public IEnumerable<string> ReadAll()
        {
            return Directory
                .GetFiles("EmailTemplates")
                .Select(
                    fileName =>
                        fileName.Replace(".json", "")
                                .Replace("EmailTemplates\\", "")
                );
        }
    }
}
