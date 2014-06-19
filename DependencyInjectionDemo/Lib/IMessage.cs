using System.Collections.Generic;

namespace DependencyInjectionDemo.Lib
{
    interface IMessage
    {
        IEnumerable<Contact> Contacts { get; }
        string Subject { get; }
        string Body { get; }
    }
}
