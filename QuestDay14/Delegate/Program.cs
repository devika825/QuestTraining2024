using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate void TaskDelegate();

        static void StartTimer(int seconds,TaskDelegate task)
        {
            Console.WriteLine("Timer started");
            Thread.Sleep(seconds * 1000);
            task();
        }

        static void GreetAfterTenSecond()
        {
            Console.WriteLine("Hello from c#");
        }
            
        static void Main(string[] args)
        {
            StartTimer(10, GreetAfterTenSecond);    
        }
    }
}
