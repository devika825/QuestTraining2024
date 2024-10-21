using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; } 
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Devika", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Amritha", DepartmentId = 2 },
                new Employee { Id = 3, Name = "Aleena", DepartmentId = 1 },
                new Employee { Id = 4, Name = "David", DepartmentId = 3 }
            };


            List<Department> departments = new List<Department>
            {
                new Department { Id = 1, DepartmentName = "HR" },
                new Department { Id = 2, DepartmentName = "IT" },
                new Department { Id = 3, DepartmentName = "Finance" }
            };

            var empWithDep = employees
                .Join(departments,
                e => e.DepartmentId,
                d => d.Id,
                (e, d) => new
                {
                EmployeeName = e.Name,
                DepName = d.DepartmentName
                }

                );
            foreach (  var item in empWithDep )
            {
                Console.WriteLine(item.EmployeeName + " - " + item.DepName);
            }

        }
    }
}
