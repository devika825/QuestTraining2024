using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
