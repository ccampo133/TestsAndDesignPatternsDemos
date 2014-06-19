using System;
using MockingDemo.Lib.Connections;

namespace MockingDemo.Lib.Messagers
{
    class TextMessager : BaseMessager
    {
        public TextMessager(IConnection connection) : base(connection){ }

        public override void Send(string messageContent)
        {
            try
            {
                Connection.Connect();
            }
            catch (ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Sent text message \"{0}\" to {1}", messageContent, Connection.Destination);
        }
    }
}
