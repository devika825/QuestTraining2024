using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var listener = new TcpListener(ip, port);
            listener.Start();
            Console.WriteLine($"App is listeneing on {ip}:{port}");

            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client Connected");

            while (true)
            {

                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer, 0, dataLength);
                Console.WriteLine($"Message Recieved{message}");

                Console.WriteLine("Server: ");
                string response = Console.ReadLine();
                byte[] responseData = Encoding.UTF8.GetBytes(response);
                socket.Send(responseData);
            }
            socket.Close();
            listener.Stop();
        }
    }
}
