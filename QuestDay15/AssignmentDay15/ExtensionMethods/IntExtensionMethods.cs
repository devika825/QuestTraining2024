using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class IntExtensionMethods
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        // Extension method to check if a number is odd
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
}
