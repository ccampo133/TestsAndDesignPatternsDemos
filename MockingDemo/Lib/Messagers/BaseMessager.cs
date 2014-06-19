using MockingDemo.Lib.Connections;

namespace MockingDemo.Lib.Messagers
{
    abstract class BaseMessager : IMessager
    {
        public IConnection Connection { get; private set; }

        protected BaseMessager(IConnection connection)
        {
            Connection = connection;
        }

        // Let the derived classes handle the implementation
        public abstract void Send(string messageContent);
    }
}