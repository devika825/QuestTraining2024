using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;

            // Using the IsEven and IsOdd extension methods
            Console.WriteLine($"{num1} is even: {num1.IsEven()}");  // True
            Console.WriteLine($"{num1} is odd: {num1.IsOdd()}");    // False

            Console.WriteLine($"{num2} is even: {num2.IsEven()}");  // False
            Console.WriteLine($"{num2} is odd: {num2.IsOdd()}");    // True
        }
    }
}
