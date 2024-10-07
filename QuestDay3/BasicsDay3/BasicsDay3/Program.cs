using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //Console.WriteLine("Enter 5 numbers : ");


            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //numbers[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine($"{numbers[i]} *2 = {numbers[i] *2 }");
            //}

            int[] data = new int[5];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Enter the numbers : ");
                data[i] = int.Parse(Console.ReadLine());
            }

            int sumOfEvens = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    sumOfEvens += data[i];
                }
                Console.WriteLine("The sum of even numbers is :" +sumOfEvens);


            }
        }
    }
}
