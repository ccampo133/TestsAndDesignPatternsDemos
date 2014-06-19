using System;
using MockingDemo.Lib.Connections;
using MockingDemo.Lib.Messagers;

namespace MockingDemo
{
    static class Program
    {
        /*
         * This demo is designed to illustrate the concept of mocking,
         * particularly in unit testing. All of the code follows a
         * simple object oriented design with loose coupling to allow
         * unit tests to be written easily. The main program represents
         * a hypothetical messaging system, where various types of
         * messagers (text, video) can send their messages over various 
         * types of connections (network, wireless). The main method 
         * demonstrates some use-cases as a console application.
         * 
         * The Lib directory contains all of the code for the different
         * messagers and connections. The Tests directory contains all
         * of the unit tests for the messagers and connections. All of
         * the tests pass by default.
         * 
         */
        static void Main(string[] args)
        {
            string networkDestination = "192.168.1.10";
            string wirelessDestination = "Mike's WiFi";

            // Send a text message over the network.
            Console.WriteLine("Attempting to send a text message over the network...");
            var networkTextMessager = new TextMessager(new NetworkConnection(networkDestination));
            networkTextMessager.Send("Hello wired world!");

            // Send a video message over the network;
            Console.WriteLine("\nAttempting to send a video message over the network...");
            var networkVideoMessager = new VideoMessager(new NetworkConnection(networkDestination));
            networkVideoMessager.Send("leeroy_jenkins.avi");

            // Send a text message over wireless
            Console.WriteLine("\nAttempting to send a text message over wireless...");
            var wirelessTextMessager = new TextMessager(new WirelessConnection(wirelessDestination));
            wirelessTextMessager.Send("Hello wireless world!");

            // Send a video message over wireless
            Console.WriteLine("\nAttempting to send a video message over wireless...");
            var wirelessVideoMessager = new VideoMessager(new WirelessConnection(wirelessDestination));
            wirelessVideoMessager.Send("leeroy_jenkins_new.avi");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
