using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squaredNumbers = numbers.Select(n => n * n);

            Console.WriteLine("Square of each number:");
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
