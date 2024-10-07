using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, string>();


            //Adding values
            d.Add("First Name", "John");
            d.Add("Last Name", "Doe");

            //Accessing Values

            Console.WriteLine(d["First Name"]);

            //Updating Values

            d["First Name"] = "Jane";

            //Removing a value

            d.Remove("Last Name");

            //check if a key exists

            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists");
            }
            else
            {
                Console.WriteLine("Age does not exist");
            }

            //Looping a dictionary
            Console.WriteLine("------------");
            foreach(var item in d)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
