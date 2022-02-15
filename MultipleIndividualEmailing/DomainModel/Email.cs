namespace MultipleIndividualEmailing.DomainModel
{
    class Email
    {
        public string ToEmailAddress { get; }
        public string FromAddress { get; }
        public string Subject { get; }
        public string Text { get; }

        public Email(
            string toEmailAddress, 
            string fromAddress, 
            string subject, 
            string text)
        {
            Text = text;
            Subject = subject;
            FromAddress = fromAddress;
            ToEmailAddress = toEmailAddress;
        }
    }
}
