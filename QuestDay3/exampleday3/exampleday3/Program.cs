using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleday3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] numbers = { 1,2,3,4,5};
            //int[] reverse = new int[numbers.Length];

            //bool isEven = numbers.Length %2 == 0;
            //if (!isEven)
            //{

            //   int centerIndex = (numbers.Length / 2);
            //    reverse[centerIndex] = numbers[centerIndex];

            //    for (int i = 0; i < centerIndex; i++) 
            //    {
            //        reverse[i] = numbers[centerIndex-1-i];
            //    }

            //    int count = 0;

            //    for (int i = centerIndex; i < numbers.Length; i++)
            //    {
            //        reverse[i] = numbers[numbers.Length - 1 -count];
            //        count++;
            //    }
            //    Console.WriteLine(string.Join(" ",reverse));


            //}

            int[] numbers = { 1, 2, 3, 4, 5, };


            var firstHalf = numbers.Take(numbers.Length / 2).Reverse().ToArray();
            var secondHalf = numbers.Skip(numbers.Length / 2 + 1).Reverse().ToArray();

            firstHalf.CopyTo(numbers, 0);
            secondHalf.CopyTo( numbers,numbers.Length / 2 +1);

            Console.WriteLine(String.Join(" ",numbers));


        }
    }
}
