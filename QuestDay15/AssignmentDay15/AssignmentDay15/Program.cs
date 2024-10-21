using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay15
{
    internal class Program
    {
        //Question1
        static void Main(string[] args)
        {
           List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            var EvenNumber = numbers.Where(n=>n%2==0);

            foreach(int num in EvenNumber)
            {
                Console.WriteLine(num);
            }

        }
    }
}
