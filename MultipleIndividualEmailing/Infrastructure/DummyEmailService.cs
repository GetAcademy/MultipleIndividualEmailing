using System;
using System.IO;
using MultipleIndividualEmailing.DomainModel;
using MultipleIndividualEmailing.DomainServices;

namespace MultipleIndividualEmailing.Infrastructure
{
    class DummyEmailService : IEmailService
    {
        public void Send(Email email)
        {
            var contents = $"Sendte epost til {email.ToEmailAddress} {DateTime.Now:g}\n";
            File.AppendAllText("EmailLog.txt", contents);
        }
    }
}
