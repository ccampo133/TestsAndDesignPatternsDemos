using System;
using DependencyInjectionDemo.Lib;
using DependencyInjectionDemo.Modules;
using Ninject;
using Ninject.Parameters;

namespace DependencyInjectionDemo
{
    static class Program
    {
        /*
         * The following code demonstrates the concepts of Inversion of Control
         * (IoC) and dependency injection (DI). Only the DI method of "constructor 
         * injection" is presented. The first portion of the example illustrates
         * dependency injection by hand, while the second portion illustrates
         * the use of an IoC container (Ninject).
         * 
         * You can (and should) read all about Ninject at the following link:
         * https://github.com/ninject/ninject/wiki/Table-of-Contents
         * 
         * For more information about IoC containers, and Ninject tutorials,
         * please visit the following links as well:
         * http://stackoverflow.com/questions/2056409/what-is-the-intention-of-ninject-modules
         * http://stackoverflow.com/questions/tagged/ninject?sort=votes&pageSize=15
         * 
         * Official Ninject "Getting Started":
         * https://github.com/ninject/ninject/wiki/Getting-Started
         * 
         * Ninject basics tutorial (and cheat sheet):
         * http://lukewickstead.wordpress.com/2013/02/09/howto-ninject-part-1-basics/
         * http://lukewickstead.wordpress.com/2013/02/09/howto-ninject-part-2-advanced-features/
         * http://lukewickstead.wordpress.com/2013/01/18/ninject-cheat-sheet/
         * 
         * Mini tutorial (parts 1 and 2):
         * http://dotnet.dzone.com/articles/ninject-mini-tutorial-%E2%80%93-part-1
         * http://dotnet.dzone.com/articles/controlling-life-cycle-your
         * 
         */
        static void Main(string[] args)
        {
            var emailContacts = new[]
            {
                new Contact("Chris", "Campo", "christopher.campo@ngc.com"),
                new Contact("Ryan", "Korson", "ryan.korson@ngc.com"),
            };

            var mailContacts = new[]
            {
                new Contact("Northrop", "Grumman", "11474 Corporate Blvd. Orlando, FL 32817"),
                new Contact("Barrack", "Obama", "1600 Pennsylvania Ave NW, Washington, DC 20500") 
            };

            // Dependency injection by hand (a.k.a. Poor Man's DI)
            Console.WriteLine("DEPENDENCY INJECTION BY HAND");
            Console.WriteLine("----------------------------");

            // When using DI by hand, we would have to update this line
            // (and every other line in the code that instantiated a mailer)
            // manually if we wanted to change the type of message passed
            // to the mailer class. This called wiring.
            IMessage message = new EmailMessage(
                emailContacts,
                "No subject",
                "This is dependency injection by hand, a.k.a. Poor Man's DI!");
            var mailer = new Mailer(message);
            mailer.Send();

            // Same deal here as before, except this time we're using a
            // sending a conventional message instead of an email.
            mailer = new Mailer(
                new ConventionalMessage(
                    mailContacts,
                    "No subject",
                    "Nothing to read here..."));
            mailer.Send();

            // Dependency injection using an IoC container (Ninject)
            Console.WriteLine("DEPENDENCY INJECTION USING NINJECT");
            Console.WriteLine("----------------------------------");

            // Set up the Ninject kernel (service locator) with our bindings
            var kernel = new StandardKernel(new MailerModule());

            // The "message" variable should be of type EmailMessage because
            // in our bindings module, we bound the interface IMessage to
            // the concrete type EmailMessage, when we set useConventionalMail
            // to false (the default constructor of MailerModule).
            message = kernel.Get<IMessage>(new []
            {
                new ConstructorArgument("contacts", emailContacts),
                new ConstructorArgument("subject", "Ninject is cool!"), 
                new ConstructorArgument("body", "Not really much more to say...")
            });
            mailer = new Mailer(message);
            mailer.Send();

            // Now we reloaded our kernel with a new MailerModule, with the flag
            // useConventionalMail set to true. Now all messages resolved by the
            // kernel will be of type ConventionalMessage, instead of EmailMessage.
            // In normal circumstances, you would never reload the kernel in your
            // main program. Instead, it is better to have a single kernel.
            kernel = new StandardKernel(new MailerModule(useConventionalMail: true));
            message = kernel.Get<IMessage>(new[]
            {
                new ConstructorArgument("contacts", mailContacts),
                new ConstructorArgument("subject", "Ninject is still cool!"),
                new ConstructorArgument("body", "Again, not really much more to say...")
            });
            mailer = new Mailer(message);
            mailer.Send();

            Console.WriteLine("{0}Press any key to continue...", Environment.NewLine);
            Console.ReadKey();
        }
    }
}
