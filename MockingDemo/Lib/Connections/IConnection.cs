namespace MockingDemo.Lib.Connections
{
    public interface IConnection
    {
        bool IsConnected { get; }
        string Destination { get; }
        void Connect();
        void Disconnect();
    }
}
