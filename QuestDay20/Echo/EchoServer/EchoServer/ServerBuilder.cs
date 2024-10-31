using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer
{
  public class ServerBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpListener _listener;
        private Socket _socket;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip,port);
        }

        public void Run(Action<string> callback)
        {
            Build();
            _listener.Start();
            Console.WriteLine($"App is listening on {ipAddress}:{port}");

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected");

            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = _socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer, 0, dataLength);
                _socket.Send(Encoding.UTF8.GetBytes("Echo: " + message));
                callback(message);
            }
        }

        public void SendMessage(string message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            _socket.Send(data);
        }
        public void ShutDown()
        {
            _listener.Stop();
            _socket.Close();
        }
    }
}
