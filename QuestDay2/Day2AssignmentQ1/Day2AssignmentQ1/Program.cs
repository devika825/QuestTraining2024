using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = "200_10_34_1";

            int sum = 0;
            string currentNumber = "";
            int i = 0;
            while (i < pattern.Length)
            {
                if (pattern[i] != '_')
                {
                    currentNumber += pattern[i];

                }
                else
                {
                    sum += int.Parse(currentNumber);
                    currentNumber = " ";
                }
                i++;
            }
            if (currentNumber != "")
            {
                sum += int.Parse(currentNumber);

            }
            Console.WriteLine(sum);
        }
    }
}
