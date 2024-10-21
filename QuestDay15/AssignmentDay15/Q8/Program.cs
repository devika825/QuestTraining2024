using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Amritha", "Sam", "Akhil", "Alen", "John", "Joel" };

            var groupedByLength = names.GroupBy(name => name.Length);

            foreach (var group in groupedByLength)
            {
                Console.WriteLine($"Names with length {group.Key}:");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine();
            }

        }
    }
}
