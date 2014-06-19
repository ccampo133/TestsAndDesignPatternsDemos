using MockingDemo.Lib.Connections;

namespace MockingDemo.Lib.Messagers
{
    public interface IMessager
    {
        IConnection Connection { get; }
        void Send(string messageContent);
    }
}
