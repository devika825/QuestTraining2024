using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int>>();

            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());



            for (int i = 0; i < 2; i++)
            {
                var marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Enter mark {j}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                data.Add(marks);

            }


            Console.ReadKey();
        }
    }
}
