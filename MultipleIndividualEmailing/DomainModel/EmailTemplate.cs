namespace MultipleIndividualEmailing.DomainModel
{
    class EmailTemplate
    {
        public string Name { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }

        public EmailTemplate()
        {
        }
        public EmailTemplate(string name, string fromAddress, string subject, string text)
        {
            Name = name;
            FromAddress = fromAddress;
            Subject = subject;
            Text = text;
        }

        public Email CreateEmail(string toEmailAddress)
        {
            return new Email(toEmailAddress, FromAddress, Subject, Text);
        }
    }
}
