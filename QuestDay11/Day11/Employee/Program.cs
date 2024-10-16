using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void TotalSalary()
        {
            Console.WriteLine($"Total Salary : {Salary * 12}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.FirstName = "Devika";
            e1.LastName = "Jayan";
            e1.Salary = 1000;

            Employee e2 = new Employee();
            e2.FirstName = "Madhav";
            e2.LastName = "Biju";
            e2.Salary = 200000;

            e1.TotalSalary();
            e2.TotalSalary();
        }
    }
}
