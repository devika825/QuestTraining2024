using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
       
            static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number : ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator : (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            double result = Calculate(num1, num2, op);
            Console.WriteLine("The result is: " + result);
        }
        static double Calculate(double a, double b, char operation)
        {
            double result = 0;


            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':

                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        result = double.NaN;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator entered.");
                    break;
            }

            return result;
        }

    }
}
