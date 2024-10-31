using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ServerBuilder = new ServerBuilder();
            ServerBuilder.Run(res =>
            {
                Console.WriteLine(res);
            });
            ServerBuilder.ShutDown();

            //    var ip = IPAddress.Parse("127.0.0.1");
            //    var port = 8000;

            //    var listener = new TcpListener(ip, port);
            //    listener.Start();
            //    Console.WriteLine($"Echo server is listening on {ip}:{port}");

            //    while (true)
            //    {

            //        Socket clientSocket = listener.AcceptSocket();
            //        Console.WriteLine("Client connected.");


            //        var buffer = new byte[1024];
            //        int dataLength;

            //        while ((dataLength = clientSocket.Receive(buffer)) > 0)
            //        {



            //            string message = Encoding.UTF8.GetString(buffer, 0, dataLength);
            //            Console.WriteLine($"Received from client: {message}");


            //            clientSocket.Send(Encoding.UTF8.GetBytes("Echo: " + message));
            //        }


            //        clientSocket.Close();
            //        Console.WriteLine("Client disconnected.");
            //}
        }
    }
}
