using System;
using MockingDemo.Lib.Connections;

namespace MockingDemo.Lib.Messagers
{
    class VideoMessager : BaseMessager
    {
        public VideoMessager(IConnection connection) : base(connection) { }

        public override void Send(string filename)
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

            Console.WriteLine("Sent video message with filename \"{0}\" to {1}", filename, Connection.Destination);
        }
    }
}
