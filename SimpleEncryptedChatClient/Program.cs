using System;
using System.Net;
using System.Net.Sockets;

namespace SimpleEncryptedChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to send");
            using(var client = new UdpClient(9000))
            {
                client.Connect("127.0.0.1", 9000);
                var message = Console.ReadLine();

                while (message != "q")
                {
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    client.Send(data, data.Length);
                }
            }
        }
    }
}
