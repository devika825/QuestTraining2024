using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Amritha", "Sam", "Akhil", "Alen", "John", "Joel" };


           var namesA = names.Where(name => name.StartsWith("A"));

            Console.WriteLine("Strings starting with 'A':");
            foreach (var word in namesA)
            {
                Console.WriteLine(word);
            }

        }
    }
}
