using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameStringbuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Devika", "Meenu", "Anjana" };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < names.Length; i++)
            {
                sb.AppendLine($"{names[i]} is {i} years old");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
