using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentsexample
{
    internal class Program
    {
        static void Main()
        {
            var s1 = new Student
            {
                Name = "Student1",
                Marks = 50
            };
            var s2 = new Student
            {
                Name = "Student2",
                Marks = 90
            };

            var s3= new Student
            {
                Name = "Student3",
                Marks = 50
            };


            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach(var student in students) 
            {
                if (student!= null)
                    Console.WriteLine(student.Name);
            }



           
        }
    }
}
