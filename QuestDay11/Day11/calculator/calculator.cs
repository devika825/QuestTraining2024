using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculator
    {
        private int a;
        private int b;
        public void Add() => Console.WriteLine (a+b);

        public void Substract()=> Console.WriteLine (a-b);

        public void Multiply() => Console.WriteLine(a * b);

        public void Divide() => Console.WriteLine (b / a);


        public void Run()
        {
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            Add();
            Substract();
            Multiply();
            Divide();
        }

        

       
    }
}
