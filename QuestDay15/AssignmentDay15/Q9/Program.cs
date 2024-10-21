using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        //Q9 and Q10
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 11, 2, 33, 54, 65, 56, 57, 98, 29, 20, 11, 42, 13 };

            //var MaxValue = numbers.Max();//q9
            //var MinValue = numbers.Min();//q10
            //var result = numbers.Find(n => n > 50);//q11
            //bool hasGreaterThan50 = result > 50;
            //bool allPositive = numbers.All(n => n > 0);//q12
            int sum = numbers.Sum();//q13

            //Console.WriteLine($"The maximum value is: {MaxValue}");
            //Console.WriteLine($"The minimum value is: {MinValue}");
            //Console.WriteLine($"Is there any number greater than 50? {hasGreaterThan50}");
            //Console.WriteLine($"Are all numbers positive? {allPositive}");
            //Console.WriteLine($"The sum of all elements is: {sum}");

        }
    }
}
