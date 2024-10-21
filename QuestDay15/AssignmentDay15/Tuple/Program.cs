using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    
    internal class Program
    {
        static (int add,int sub) AddAndSub(int a,int b)
        {
            return (a+b,a - b);
        }
        static void Main(string[] args)
        {
            var res = AddAndSub(1,2);
            Console.WriteLine(res.add);
            Console.WriteLine(res.sub);

            (int, int) data = (2, 3);
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);

            (int num1,int num2) numbers =(2, 3);
            Console.WriteLine(numbers.num1);
            Console.WriteLine(numbers.num2);
                


        }
    }
}
