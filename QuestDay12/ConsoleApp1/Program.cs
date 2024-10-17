using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Search");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");

                var option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        var student = GetStudentData();
                        stManager.Add(student);
                        break;

                    case "2":
                        Console.WriteLine("Enter the Register Number to search");
                        var RegNo = int.Parse(Console.ReadLine());
                        stManager.Search(RegNo);
                        break;

                    case "3":
                     var studentUpdate = GetStudentData();
                        stManager.Update(studentUpdate.Name,
                            studentUpdate.Class,
                            studentUpdate.RegNo);
                        break;


                    case "4":
                        Console.WriteLine("Enter the Regno to delete");
                        var RegNoToDelete = int.Parse(Console.ReadLine());
                        stManager.Delete(RegNoToDelete);
                        break;

                    default:
                        Console.WriteLine("Invalide Option");
                        break;
                              
                }

            }
        }

        private static StudentDetails GetStudentData()
        {

           StudentDetails student = new StudentDetails();

            Console.WriteLine("Enter the student name");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the class");
            student.Class = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the RegNo");
            student.RegNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of subjects: ");
            int numberOfSubjects = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSubjects; i++)
            {
                Subject subjects = new Subject();
                Console.Write($"Enter subject name for subject {i + 1}: ");
                subjects.SubjectName = Console.ReadLine();

                Console.Write($"Enter marks obtained for {subjects.SubjectName}: ");
                subjects.MarksObtained = int.Parse(Console.ReadLine());

                Console.Write($"Enter max marks for {subjects.SubjectName}: ");
                subjects.MaxMark = int.Parse(Console.ReadLine());

                
            }


            return student;


        }
    }
}
