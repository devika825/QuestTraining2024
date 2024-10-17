using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal interface IStudent
    {
        string Name { get; set; }
        void Display();


    }
    class SchoolStudent : IStudent
    {
        public string Name { get; set; }
        public const string SchoolName = "School X";

        public void Display()
        {
            Console.WriteLine($"Student Name : {Name} | school Name = {SchoolName}");
        }
    }

    class CollegeStudent : IStudent
    {
        public string Name { get; set; }
        public const string CollegeName = "College Y";

        public void Display()
        {
            Console.WriteLine($"Student Name : {Name} | College Name = {CollegeName} ");
        }
    }
    internal class program
    {
        static void Main()
        {
            var Student = new List<IStudent>
            {
                new SchoolStudent { Name = "John" },
                new SchoolStudent { Name = "Joe" },
                new SchoolStudent { Name = "DEV" }
            };
        }
    }
}