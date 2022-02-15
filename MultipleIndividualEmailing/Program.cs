using System;
using MultipleIndividualEmailing.ApplicationServices;
using MultipleIndividualEmailing.Infrastructure;

namespace MultipleIndividualEmailing
{
    class Program
    {
        static void Main(string[] args)
        {
            //var emailList = new EmailList("navkontorer", new[] {"a@nav.no", "b@nav.no", "c@nav.no"});
            //var json = JsonSerializer.Serialize(emailList);
            //File.WriteAllText("EmailLists/navkontorer.json", json);

            //var emailTemplate = new EmailTemplate("mytemplate", "terje@getacademy.no", "Super IT-utdanning", "Bli IT-utvikler!");
            //var json= JsonSerializer.Serialize(emailTemplate);
            //File.WriteAllText("EmailTemplates/mytemplate.json", json);

            var emailListRepository = new EmailListFileRepository();
            var names = emailListRepository.ReadAll();
            Console.WriteLine("Epostlister:");
            Console.WriteLine(string.Join("\n ", names));

            var emailTemplateRepository = new EmailTemplateFileRepository();
            names = emailTemplateRepository.ReadAll();
            Console.WriteLine("\nEpostmaler:");
            Console.WriteLine(string.Join('\n', names));

            Console.Write("Velg liste: ");
            var emailListName = Console.ReadLine();
            Console.Write("Velg mal: ");
            var emailTemplateName = Console.ReadLine();

            var multiEmailService = new MultiEmailService(new DummyEmailService(), emailListRepository, emailTemplateRepository);
            multiEmailService.SendEmails(emailListName, emailTemplateName);
        }
    }
}
