using System;

namespace MockingDemo.Lib.Connections
{
    class NetworkConnection : BaseConnection
    {
        public NetworkConnection(string destination) : base(destination) { }

        public override void Connect()
        {
            // Ideally, some code would go here to actually establish 
            // a connection before setting IsConnected to true.
            Console.WriteLine("Connected over the network to " + Destination);
            IsConnected = true;

            // Returning nothing indicates a successful connection.
            // A `ConnectionException` is thrown if for some reason,
            // the connection failed. Currently, this exception will 
            // never be thrown, but I've included it here for 
            // demonstration purposes.
            if (!IsConnected)
                throw new ConnectionException("Could not connect for some unknown reason.");
        }

        public override void Disconnect()
        {
            // Some code would go here to disconnect if connected.
            // Returning nothing indicates that the connection was
            // properly closed, or the method did nothing.
            if(IsConnected)
                IsConnected = false;
        }
    }
}
