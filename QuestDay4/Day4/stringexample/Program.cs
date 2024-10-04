using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the numbers :");

            //string input = Console.ReadLine();

            //string[] inputs = input.Split(',');
            //string[] numberWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //for (int i = 0; i < inputs.Length; i++)
            //{
            //    string trimmedInput = inputs[i].Trim();



            //}   

            var numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven" };

            string input = "One, 2,Three ,Four, 2";

            //var inputItems = input.Replace(" ", "").Split(',');

            //var sb = new StringBuilder();

            //foreach (var item in inputItems)
            //{
            //    if (item.Length <= 2)
            //    {
            //        int number = int.Parse(item);
            //        string text = numbers[number - 1];
            //        sb.Append($"{ text}, ");
            //    }
            //    else
            //    {
            //        sb.Append($"{ item }," );
            //    }
            //}
            //Console.WriteLine(sb.ToString());

            var inputItems = input.Replace(" ","").Split(',');

            var sb = new StringBuilder() ;

            foreach (var item in inputItems)
            {
                if (item.Length <= 2)
                {
                    int number = int.Parse(item);
                    string text = numbers[number - 1];
                    sb.Append($"{text}, ");
                }

                else
                {
                    sb.Append($"{ item },");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
