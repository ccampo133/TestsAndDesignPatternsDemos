using System.Collections.Generic;

namespace DependencyInjectionDemo.Lib
{
    class ConventionalMessage : IMessage
    {
        public IEnumerable<Contact> Contacts { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public ConventionalMessage(IEnumerable<Contact> contacts, string subject, string body)
        {
            Contacts = contacts;
            Subject = subject;
            Body = body;
        }
    }
}
