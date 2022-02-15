using MultipleIndividualEmailing.Model;

namespace MultipleIndividualEmailing.DomainServices
{
    interface IEmailService
    {
        void Send(Email email);
    }
}
