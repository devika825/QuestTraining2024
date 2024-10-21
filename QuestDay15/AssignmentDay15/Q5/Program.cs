using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squareEven = numbers.Where(num=> num % 2 == 0).Select(num=>num*num);

            Console.WriteLine("Squares of even numbers:");
            foreach (var num in squareEven)
            {
                Console.WriteLine(num);
            }
        }
    }
}
