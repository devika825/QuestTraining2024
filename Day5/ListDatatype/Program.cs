using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            // var lst = new List<int>();

            list.Add(10); //adds a single element

            //Adding multiple values.

            var valuesToAdd = new int[] { 20, 30, 40, 50 };
            list.AddRange(valuesToAdd);

            //Updating the element

            list[0] = 100;

            //Deleting the element
            // The remove the first occurance of 50
            list.Remove(50);

            // Remove from a specific index

            list.RemoveAt(1);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }

            Console.WriteLine();

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
