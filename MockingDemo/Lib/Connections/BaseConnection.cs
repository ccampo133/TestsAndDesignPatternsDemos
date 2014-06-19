namespace MockingDemo.Lib.Connections
{
    abstract class BaseConnection : IConnection
    {
        public bool IsConnected { get; protected set; }
        public string Destination { get; protected set; }

        protected BaseConnection(string destination)
        {
            Destination = destination;
        }

        public abstract void Connect();
        public abstract void Disconnect();
    }
}
