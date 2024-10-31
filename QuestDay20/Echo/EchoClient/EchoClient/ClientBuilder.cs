using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    public class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _client;
        private NetworkStream _stream;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _client = new TcpClient();
            _client.Connect(ip, port);
        }

        public void Run(Action<string> callback)
        {
            Build();
            Console.WriteLine("Connected to the server.");

            _stream = _client.GetStream();

            while (true)
            {
              
                Console.Write("Enter message: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                _stream.Write(data, 0, data.Length);

            
                var buffer = new byte[1024];
                var dataLength = _stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, dataLength);

               
                callback(response);
            }
        }
    }
}
