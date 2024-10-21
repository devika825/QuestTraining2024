using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q14

            //List<double> numbers = new List<double> { 10.5, 20.75, 30.0, 40.25, 50.0 };


            //double average = numbers.Average();

            //Console.WriteLine($"The average of the list is: {average}");

            //q15

          

            List<int> numbers = new List<int> { 10, 20, 10, 30, 20, 40, 50, 50 };

            //var distinctNumbers = numbers.Distinct().ToList();

            //Console.WriteLine("Distinct numbers:");
            //foreach (var number in distinctNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //q16

            int count = numbers.Count(n => n > 10);

            Console.WriteLine($"Count of elements greater than 10: {count}");
        }
    }
}
