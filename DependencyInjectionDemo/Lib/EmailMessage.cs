using System.Collections.Generic;

namespace DependencyInjectionDemo.Lib
{
    class EmailMessage : IMessage
    {
        public IEnumerable<Contact> Contacts { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public EmailMessage(IEnumerable<Contact> contacts, string subject, string body)
        {
            Contacts = contacts;
            Subject = subject;
            Body = body;
        }
    }
}
