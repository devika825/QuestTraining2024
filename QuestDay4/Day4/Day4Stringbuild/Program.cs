using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Stringbuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Method 1
            var res = "";
            res = string.Join(",", "Hello", "world");
            System.Console.WriteLine(res);

            // Method 2

            res = string.Concat("1", true, 10.5);
            System.Console.WriteLine(res);

            // Method 3

            res = string.Format("{0} {1} {2}", "Hello", "From", "c#");
            System.Console.WriteLine(res);

            //Method 4

            res = "Hello" + "From" + "c#";
            System.Console.WriteLine(res);

            // Method 5

            var language = "c#";
            res = $"Hello from {language}";

            // Method 6
            var largeArr = new int[] { 1, 2, 3, 4, 5, 6 };
            var sb = new StringBuilder();
            sb.AppendLine("Line 1");
            sb.AppendLine("Line 2");
            sb.Append("No new line");
            sb.Append("No new line");


            foreach (var item in largeArr)
            {
                {
                    sb.AppendFormat("{0}", item);

                }

                res = sb.ToString();

                Console.WriteLine(res);


            }
        }
    }
}
