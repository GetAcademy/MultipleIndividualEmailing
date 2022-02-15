using System.Collections.Generic;
using MultipleIndividualEmailing.DomainServices;

namespace MultipleIndividualEmailing.ApplicationServices
{
    class MultiEmailService
    {
        private readonly IEmailService _emailService;
        private readonly IEmailListRepository _emailListRepository;
        private readonly IEmailTemplateRepository _emailTemplateRepository;

        public MultiEmailService(
            IEmailService emailService, 
            IEmailListRepository emailListRepository,
            IEmailTemplateRepository emailTemplateRepository
            )
        {
            _emailTemplateRepository = emailTemplateRepository;
            _emailListRepository = emailListRepository;
            _emailService = emailService;
        }

        public IEnumerable<string> GetEmailListNames()
        {
            return _emailListRepository.ReadAll();
        }

        public IEnumerable<string> GetEmailTemplateNames()
        {
            return _emailTemplateRepository.ReadAll();
        }

        public void SendEmails(string emailListName, string emailTemplateName)
        {
            var emailTemplate = _emailTemplateRepository.Read(emailTemplateName);
            var emailList = _emailListRepository.Read(emailListName);
            foreach (var toEmailAddress in emailList.EmailAddresses)
            {
                var email = emailTemplate.CreateEmail(toEmailAddress);
                _emailService.Send(email);
            }
        }
    }
}
