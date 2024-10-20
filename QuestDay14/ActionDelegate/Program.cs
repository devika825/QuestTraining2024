using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    internal class Program
    {
        static void Greet() => Console.WriteLine("Hello");

        static void GreetMessage(string message) => Console.WriteLine(message); 
        static void Main(string[] args)
        {
            Action g  = Greet;
            Action<string> gm = GreetMessage;
            g();
            gm("hi");
        }
    }
}
