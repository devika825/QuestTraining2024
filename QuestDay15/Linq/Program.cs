using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public string person { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person{Name="person1",Country="Us",Age =20},
                new Person{Name="person2",Country="US",Age=30},
                new Person{Name="person3",Country="US",Age=40},
                new Person{Name="person4",Country="IN",Age=50},



            };
            var minAge = data.Where(p=>p.Country == "US").Min(p=>p.Age);
            var person = data.Where(p=>p.Country == "US" && p.Age == minAge).FirstOrDefault();

            var sortAgeByDescending = data.OrderByDescending(p=>p.Age).ToList();


            var distinctCountries = data.Select(p=>p.Country).Distinct().ToList();

            var groups = data.GroupBy(p=>p.Country).ToList();

            foreach(var group in groups)
            {
                Console.WriteLine($"{ group.Key} - { group.Count()}");

                foreach(var person in group)
                {
                    Console.WriteLine($"\t{person}");
                }

            }
            
        }
    }
}
