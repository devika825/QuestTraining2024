using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var client = new ClientBuilder();
            client.Run(response => Console.WriteLine("Server response: " + response));

            //var ip = IPAddress.Parse("127.0.0.1");
            //var port = 8000;


            //var client = new TcpClient();
            //client.Connect(ip, port);
            //Console.WriteLine("Connected to echo server.");


            //while (true)
            //{
            //    Console.Write("Enter message to send: ");
            //    string message = Console.ReadLine();


            //    byte[] data = Encoding.UTF8.GetBytes(message);
            //    client.GetStream().Write(data, 0, data.Length);


            //    byte[] response = new byte[1024];
            //    int responseLength = client.GetStream().Read(response, 0, response.Length);
            //    string responseMessage = Encoding.UTF8.GetString(response, 0, responseLength);

            //    Console.WriteLine(responseMessage);
        }
        }
    }

