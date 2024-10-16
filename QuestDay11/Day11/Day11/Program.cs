using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class Student
    {
        public string Names;
        public void DisplayName()
        {
            Console.WriteLine(Names.ToUpper());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Student s = new Student();
            s.Names  = "Devika";
            s.DisplayName();

            Student s2 = new Student();
            s2.Names = "Madhav";
            s2.DisplayName();

        }
    }
}
