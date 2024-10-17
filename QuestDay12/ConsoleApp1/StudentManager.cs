using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentManager
    {
       private List<StudentDetails> students = new List<StudentDetails>();

        public void Add(StudentDetails student)
        {
          if(GetStudentByRegNo(student.RegNo) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }
           students.Add(student);
            Console.WriteLine("Added successfully");
        }

        public void Search(int RegNo)
        {
            var student = GetStudentByRegNo(RegNo);
            Console.WriteLine(student);
        }

        public void Update(string Name,int Class,int RegNo)
        {
            var student = GetStudentByRegNo(RegNo);
            if(student == null)
            {
                Console.WriteLine("student not found");
                return;
            }

            student.Name = Name;
            student.Class = Class;
            student.RegNo = RegNo;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(int RegNo)
        {
            var student = GetStudentByRegNo(RegNo);
            if(student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }
            students.Remove(student);
            Console.WriteLine("Deleted successfully");
        }

        private StudentDetails GetStudentByRegNo(int regNo)
        {
          foreach(var student in students)
            {
                if(student.RegNo == regNo)
                {
                    return student;
                }
            }
          return null;
        }

    }
}
