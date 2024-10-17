using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        public enum ConvertsTo
        {
            Upper,
            Lower,
            SwapCase
        }

        public static void ConvertCasing(string input,ConvertsTo targetType)
        {
            switch(targetType)
            {
                case ConvertsTo.Upper:
                    Console.WriteLine(input.ToUpper());
                    break;
                    case ConvertsTo.Lower:
                    Console.WriteLine(input.ToLower());
                    break;
            }
        }

        static void Main()
        {
                ConvertCasing("Hello",ConvertsTo.Upper);
        }
    }
}
