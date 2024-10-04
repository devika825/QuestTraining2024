using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "devika", "arya", "anjana", "asha", "abina", "shabin" };

            //Console.WriteLine("Names that contain 'ab':");
            //var toSearch = Console.ReadLine().ToLower().Trim();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Contains("ab"))
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}

            string sentence = "hi, how are you?";

          
            string updatedSentence = sentence.Replace("are", "is");

            Console.WriteLine("Original: " + sentence);

            Console.WriteLine("Updated: " + updatedSentence);
        }
    }
}
