using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
      static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = AddNumbers(num1, num2);

            Console.WriteLine("The sum of two numbers is :" + sum);

        }
    }
}
