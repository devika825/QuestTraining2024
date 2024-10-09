using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedList
{
    internal class Program
    {
        static void NestedList()
        {
            var lst = new List<List<int>>();
            lst.Add(new List<int>());
            lst[0].Add(1);

            var lst1 = new List<List<int>>
            {
              new List<int> {1,2},
              new List<int> {2,3},
            }
}

        static void Main(string[] args)
            {

            }
        
    }
}
