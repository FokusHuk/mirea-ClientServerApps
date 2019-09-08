using System;
using System.Net;

namespace TestServ
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Server server = new Server(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1111));

            server.Start();

            string message = server.ReceiveMessage();
            Console.WriteLine(message);

            server.SendMessage("message to client");

            server.Close();

            Console.ReadLine();
        }
    }
}
