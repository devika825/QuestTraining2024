using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePrblm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //string result = "";

            //foreach (char c in input)
            //{

            //    if (char.IsUpper(c))
            //    {
            //        result += char.ToLower(c);
            //    }

            //    else if (char.IsLower(c))
            //    {
            //        result += char.ToUpper(c);
            //    }
            //    else
            //    {

            //        result += c;
            //    }
            //}

            //Console.WriteLine("Swapped : " + result);

            string text = "HeLlO WoRlD";
            string s = "";
            foreach(var chr in text)
            {
                char res = char.IsUpper(chr) ? char.ToLower(chr) : char.ToUpper(chr);

                s = s + res;
            }
            Console.WriteLine(s);

        }
    }
}
