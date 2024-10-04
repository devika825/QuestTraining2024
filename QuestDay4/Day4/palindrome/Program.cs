using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if its a palindrome :");
            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reversed = new string(inputArray);

            
            if (input == reversed)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
