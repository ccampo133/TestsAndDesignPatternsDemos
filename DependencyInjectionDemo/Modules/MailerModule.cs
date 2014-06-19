using DependencyInjectionDemo.Lib;
using Ninject.Modules;

namespace DependencyInjectionDemo.Modules
{
    class MailerModule : NinjectModule
    {
        private readonly bool useConventionalMail;

        public MailerModule(bool useConventionalMail = false)
        {
            this.useConventionalMail = useConventionalMail;
        }

        public override void Load()
        {
            if (useConventionalMail)
                Bind<IMessage>().To<ConventionalMessage>();
            else
                Bind<IMessage>().To<EmailMessage>();
        }
    }
}
