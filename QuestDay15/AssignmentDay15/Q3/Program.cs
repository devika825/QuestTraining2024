using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 11, 2, 33, 54, 65, 56, 57, 98, 29, 20, 11, 42, 13};

            var DescSort = numbers.OrderByDescending(x => x);

            Console.WriteLine("Numbers sorted in descending order:");
            foreach (var num in DescSort)
            {
                Console.WriteLine(num);
            }
        }
    }
}
