using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampleprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example 1

            //Console.WriteLine("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());

            //if (age > 18) 
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("You can't drive");
            //}

            //example 2

            //Console.WriteLine("Enter the first number :");
            //int n1 =  int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number :");
            //int n2 = int.Parse(Console.ReadLine());


            //Console.WriteLine(n1 + n2);

            //example 3

            //Console.WriteLine("Enter your mark : ");
            //int mark = int.Parse(Console.ReadLine());

            //if (mark > 90)
            //{
            //    Console.WriteLine("A");

            //}

            //else if (mark > 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (mark > 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}

            //example 4

            //Console.WriteLine("Enter your name :");
            //string name = Console.ReadLine();

            //string upperCaseName = name.ToUpper();

            //Console.WriteLine(upperCaseName);

            //example 5

            //string pattern = "1_2_1_3";

            //int sum = 0;

            //int i = 0;

            //while (i < pattern.Length) 
            //{
            //  sum += int.Parse(pattern[i].ToString());
            //    i = i + 2;
            //}
            //Console.WriteLine(sum);

            //example 5

            //string pattern = "200_10_34_1";

            //int sum = 0;
            //string currentNumber = "";
            //int i = 0;
            //while (i < pattern.Length) 
            //{
            //if(pattern[i]!= '_')
            //    {
            //        currentNumber += pattern[i];

            //    }
            //else
            //    {
            //        sum += int.Parse(currentNumber);
            //        currentNumber = " ";
            //    }
            //i++;
            //}
            //if(currentNumber != "")
            //{
            //        sum += int.Parse(currentNumber);

            //}
            //Console.WriteLine(sum);

            //example 6


            Console.Write("Enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());

            int width = 15;

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
