using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestDay16
{
   
    internal class Program
    {
        static int Calculator(bool doAddition, int a, int b)
        {
            return doAddition ? a +b : a-b;
        }
        static void Main(string[] args)
        {
            var result = Calculator(true, 2, 3);
            Console.WriteLine(result);
        }
    }
}
