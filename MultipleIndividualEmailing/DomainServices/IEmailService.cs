using MultipleIndividualEmailing.DomainModel;

namespace MultipleIndividualEmailing.DomainServices
{
    interface IEmailService
    {
        void Send(Email email);
    }
}
