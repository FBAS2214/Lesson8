using System;
using System.Net;

namespace Lesson8
{

    class Protocol
    {
        public const string TCP = "TCP";
        public const string UDP = "UDP";

        // public readonly int Port;
        // public readonly int Port = 122;
        public readonly int Port = Math.Abs(-7);




        private readonly string _iPAddress;

        public string MyProperty
        {
            get { return _iPAddress; }
        }


        public Protocol(int port)
        {
            Port=port;
        }
    }


    public class Program
    {
        static void Main()
        {
            // Protocol protocol = new Protocol(21);
            // // protocol.Port = 20;
            // Console.WriteLine(protocol.Port);



            // Console.WriteLine(Environment.CommandLine);
            // Console.WriteLine(Environment.UserName);
            // Console.WriteLine(Environment.MachineName);
            // Console.WriteLine(Environment.CurrentDirectory);
            // Console.WriteLine(Environment.OSVersion);


            // Console.WriteLine(IPAddress.Loopback);
            // Console.WriteLine(IPAddress.None);
            // Console.WriteLine(IPAddress.IPv6Any);



            // string text = "Hello";
            // Console.Write(string.Format("{0, 10}", text));
            // // Console.Write($"{text, -10}");
            // // Console.Write($"{text, -10}");
        }
    }
}