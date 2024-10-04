using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string vowels = "aeiouAEIOU";
            Console.WriteLine("Vowels in the string:");


            foreach (char c in input)
            {

                if (vowels.Contains(c))
                {
                    Console.Write(c + " ");
                }
            }
            Console.ReadLine();
        }
    }  
}
