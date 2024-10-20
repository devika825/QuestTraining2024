using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelSumQue10
{
    internal class Program
    {
        public static void PrintSum(int a,int b)
        {
            int res = a + b;
            Console.WriteLine($"sum of a and b is {res}");
        }
        static void Main(string[] args)
        {
            Action<int, int> sumDelegate = PrintSum;

            sumDelegate(10, 20);
            sumDelegate(5, 15);

        }
    }
}
