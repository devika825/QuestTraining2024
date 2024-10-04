using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halfpyrmaid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 : Half pyramid

            //Console.WriteLine("Enter the number of rows for the pyramid:");
            //int rows = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" * ");
            //    }

            //    Console.WriteLine();

            //}


            // Example 2 : Half pyrmaid using numbers

            Console.WriteLine("Enter the number of rows for the pyramid:");
            int rows = int.Parse(Console.ReadLine());

            int number = 1;
            int count = 1;


            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{count++ , -3}");
                    number++;
                }


                Console.WriteLine();

            }
                // Example 3

                //Console.WriteLine("Enter the number of rows for the pyramid:");
                //int rows = int.Parse(Console.ReadLine());


                //for (int i = 1; i <= rows; i++)
                //{

                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write(j + " ");
                //    }


                //    Console.WriteLine();
          //  }


        }
    }
}
