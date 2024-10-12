using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            int newSize = 8;

            int[] resizedArray = new int[newSize];

            for(int i = 0; i < arr.Length && i < resizedArray.Length; i++)
{
                resizedArray[i] = arr[i];
            }

           arr = resizedArray;

            Console.WriteLine("Resized array:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
