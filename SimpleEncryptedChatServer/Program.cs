using System;
using System.Net;
using System.Net.Sockets;

namespace SimpleEncryptedChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new UdpClient(9000))
            {
                while(true)
                {
                    var ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receivedBytes = client.Receive(ref ipEndPoint);
                    string message = System.Text.Encoding.ASCII.GetString(receivedBytes);
                    Console.WriteLine($"Message received: {message}");
                }
            }
        }
    }
}
