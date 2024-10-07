using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Dictionary<string, string> studentMarks = new Dictionary<string, string>();

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"Entering marks for Student {i + 1}:");

            //        Console.Write("Enter Student ID : ");
            //        string studentId = Console.ReadLine();

            //        Console.Write("Enter marks : ");
            //        string marks = Console.ReadLine();


            //        studentMarks[studentId] = marks;
            //        Console.WriteLine();

            //    }

            //    Console.WriteLine("Student Marks:");
            //    foreach (var items in studentMarks)
            //    {
            //        Console.WriteLine($"Student ID: {items.Key}, Marks: {items.Value}");
            //    }

            var d = new Dictionary<string, List<int>>();

            while (true)
            {
                Console.Write("Enter an ID or q to exist: ");
                var option = Console.ReadLine();

                if(option == "q")
                {
                    break;
                }
                if (d.ContainsKey(option))
                {
                    Console.WriteLine($"ID '{option}' already exists.");
                    Console.Write("Do you want to overwrite it? (y/n): ");
                    var choice = Console.ReadLine();

                    if (choice.ToLower() != "y")
                    {
                        Console.WriteLine("Keeping existing marks.");
                        continue; 
                    }
                }
                var marks = new List<int>();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter  mark {i}:");
                    var mark = int.Parse( Console.ReadLine() );
                    marks.Add( mark );
                }
                d.Add(option, marks);
            }

            foreach(var item in d)
            {
                Console.WriteLine($"{item.Key}: {string.Join(",",item.Value)}");
            }



        }
    }
}
