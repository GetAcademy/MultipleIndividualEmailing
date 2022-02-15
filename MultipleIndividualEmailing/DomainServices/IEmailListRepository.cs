using System.Collections.Generic;
using MultipleIndividualEmailing.DomainModel;

namespace MultipleIndividualEmailing.DomainServices
{
    interface IEmailListRepository
    {
        void Create(EmailList emailList);
        void Delete(EmailList emailList);
        void Update(EmailList emailList);

        EmailList Read(string name);

        IEnumerable<string> ReadAll();
    }
}
