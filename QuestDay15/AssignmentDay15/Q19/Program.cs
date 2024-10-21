using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            var result = numbers.Skip(5).Take(3);

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}
