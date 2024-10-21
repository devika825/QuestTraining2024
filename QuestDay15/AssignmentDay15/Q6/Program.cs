using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Amritha", "Sam", "Akhil", "Alen", "John", "Joel","Bindhu","Binil" };

            string firstWithB = names.FirstOrDefault(word => word.StartsWith("B"));

            if (firstWithB != null)
            {
                Console.WriteLine($"The first string starting with 'B' is: {firstWithB}");
            }
            else
            {
                Console.WriteLine("No string starts with 'B'");
            }


        }
    }
}
