using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    class Employee
    {
        public string Name { get; set; }

        public static string CompanyName { get; set; }

        public Employee()
        {
            CompanyName = "Microsoft";
        }

        public Employee(string name)
        {
            Name = name;
        }

            public override string ToString()
        {
            return base.ToString();
        }
    
    }

    

    //class Person
    //{
    //    public string Name { get; set; }

    //    public DateTime CreatedAt { get; set; }

    //    public string[] PhoneNumber { get; set; }
    //    public Person(int phoneNumberCount)
    //    {
    //        CreatedAt = DateTime.Now;
    //        PhoneNumber = new string[phoneNumberCount];
    //    }

    //    public Person(string name,int phoneNumberCount)
    //    {
    //        Name = name;
    //        CreatedAt = DateTime.Now;
    //        PhoneNumber = new string[phoneNumberCount];

    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //var obj1 = new Person(2);
            //var obj2 = new Person("Devika",2);
            Console.WriteLine("companyName :" +Employee.CompanyName);
            var e1 = new Employee("joe");
            Console.WriteLine(e1);

        }
    }
}
