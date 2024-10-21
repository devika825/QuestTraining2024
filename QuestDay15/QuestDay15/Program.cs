using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestDay15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -3, -4 };
            //var res = from i in data
            //          where i is < 0
            //          select i;

                          //var r = data.Where(i => i < 0);

            var res = data.Skip(3).Take(5).Where(n=>n%2 == 0).Sum();
            Console.WriteLine($"Anser is {res}");

            var first = data.First();
            var last = data.Last();

            var sortAsc = data.OrderBy(x=>x);
            var sorDesc = data.OrderByDescending(x=>x);

            var min = data.Min();
            var max = data.Max();

            var count = data.Count();

            var MaxGreaterThanFive = data.Max(x=>x>5);
            
            var MinGreaterThanFive = data.Min(x=>x>5);

            var DistinctElements = data.Distinct();

            var FirstFive = data.Take(5);
             var SkipFirstFive = data.Skip(5);
            //var LastFive = data.TakeLast(5);

            var TakeWhile = data.TakeWhile(x=>x>5);
            var SkipWhile = data.SkipWhile(x=>x>5);

            var where = data.Where(x=>x>0);


        }
    }
}
