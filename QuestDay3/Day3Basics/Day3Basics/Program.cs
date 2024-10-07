using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example 1 Read an array of numbers and multiply by 2

            //int[] numbers = new int[5];


            //Console.WriteLine("Enter 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int[] multipliedNumbers = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    multipliedNumbers[i] = numbers[i] * 2;
            //}


            //Console.WriteLine("Multiplied Numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(multipliedNumbers[i]);
            //}



            //example 2 Read an array of numbers and find the sum of even numbers

            //Console.Write("Enter the number of elements in the array: ");
            //int size = int.Parse(Console.ReadLine());


            //int[] numbers = new int[size];


            //Console.WriteLine("Enter the numbers:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int sumOfEvens = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    if (numbers[i] % 2 == 0)  
            //    {
            //        sumOfEvens += numbers[i];
            //    }
            //}


            //Console.WriteLine($"The sum of even numbers is: {sumOfEvens}");



            //example 3

            //int[] numbers = new int[1];
            //int index = 0;

            //while (true)
            //{
            //    Array.Resize(ref numbers, numbers.Length + 1);
            //    Console.WriteLine("Enter the number (or 'q' to exit ) : ");
            //    string input = Console.ReadLine();
            //    if (index < 2)
            //    {
            //        numbers[index] = int.Parse(input);
            //        index++;
            //        continue;
            //    }
            //    if(input.ToLower() == "q")
            //    {
            //        break;
            //    }


            //}

            //int[] numbers = new int[0];
            //int index = 0;

            //while (true)
            //{
            //    if (numbers.Length < 2)
            //    {
            //        Console.WriteLine($"Enter number {numbers.Length + 1}");
            //        Array.Resize(ref numbers, numbers.Length + 1);
            //        numbers[index] = int.Parse(Console.ReadLine());
            //        index++;
            //        continue;
            //    }

            //    Console.WriteLine($"Enter number {numbers.Length + 1} or q to exit");
            //    string input = Console.ReadLine();

            //    if (input == "q")
            //    {
            //        break;
            //    }


            //    Array.Resize(ref numbers, numbers.Length + 1);
            //    numbers[index] = int.Parse(input);
            //    index++;
            //}
            //    int sum = 0;

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        sum += numbers[i];
            //    }

            //    Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //int[] reverseNumber = new int[numbers.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //reverseNumber[i] = numbers[numbers.Length - 1 - i ];
            //}

            //Console.WriteLine("Reversed Array");

            //for (int i = 0;i < reverseNumber.Length; i++)
            //{
            //    Console.WriteLine(reverseNumber[i]);
            //}

           
        }
    }
}
