using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Action1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hello from Action 1");
        }

        static void Action2()
        {
            Console.WriteLine("Hello from Action 2");
        }
        static void Main(string[] args)
        {
            //Action1();
            //Action2();
           
            var t1 = new Thread(Action1);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();  
            Console.WriteLine("Completed");
        }
    }
}
