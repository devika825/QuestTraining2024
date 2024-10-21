using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<string> list2 = new List<string> { "one", "two", "three", "four", "five" };

           
            var zippedList = list1.Zip(list2, (first, second) => (first, second)).ToList();

          
            Console.WriteLine("Zipped List:");
            foreach (var pair in zippedList)
            {
                Console.WriteLine($"{pair.first} - {pair.second}");
            }
        }
    }
}
