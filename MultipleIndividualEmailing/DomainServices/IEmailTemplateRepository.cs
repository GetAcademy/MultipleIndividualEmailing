using System.Collections.Generic;
using MultipleIndividualEmailing.DomainModel;

namespace MultipleIndividualEmailing.DomainServices
{
    interface IEmailTemplateRepository
    {

        void Create(EmailTemplate emailList);
        void Delete(EmailTemplate emailList);
        void Update(EmailTemplate emailList);

        EmailTemplate Read(string name);

        IEnumerable<string> ReadAll();
    }
}
