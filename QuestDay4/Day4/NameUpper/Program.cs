using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Number of names :");
            //int numberOfNames = int.Parse(Console.ReadLine());

            //String[] names = new string[numberOfNames];

            //for (int i = 0; i < numberOfNames; i++)
            //{
            //    Console.Write("Enter name " + (i + 1) + ": ");
            //    names[i] = Console.ReadLine();
            //}

            //Console.WriteLine("\nNames in Uppercase:");
            //for (int i = 0; i < numberOfNames; i++)
            //{
            //    Console.WriteLine(names[i].ToUpper());
            //}

            //string[] names = { "devika", "arya", "madhav" };

            //Console.WriteLine("Names in Uppercase:");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i].ToUpper());
            //}

            var names = new string[] { "devu", "arya", "ammu" };
                var toSearch = "John";

            for (int i = 0; i < names.Length; i++)
            {

                var n = names[i].ToLower();
                if(n == toSearch.ToLower()) {
                    {
                        Console.WriteLine("Name found");
                    
                    }  
        }
    }
}
