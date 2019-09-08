using System;
using System.Net;

namespace TestClient
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Client client = new Client(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1111));

            client.Connect();

            client.SendMessage("message to server");

            string responce = client.ReceiveMessage();
            Console.WriteLine(responce);

            client.Close();

            Console.ReadLine();
        }
    }
}
