using System;

namespace DependencyInjectionDemo.Lib
{
    class Mailer
    {
        public IMessage Message { get; private set; }

        public Mailer(IMessage message)
        {
            Message = message;
        }

        public void Send()
        {
            // The type is resolved at runtime if you're using an IoC container.
            // Otherwise, the type is resolved at compile time (DI by hand).
            Console.WriteLine("Resolved type of message: {0}", Message.GetType());

            Console.Write("Contacts: ");
            foreach (var contact in Message.Contacts)
                Console.Write("{0}, {1} ({2}); ", contact.LastName, contact.FirstName, contact.Address);

            Console.WriteLine("{0}Subject: {1}", Environment.NewLine, Message.Subject);
            Console.WriteLine("Body: {0}{1}", Message.Body, Environment.NewLine);
        }
    }
}
