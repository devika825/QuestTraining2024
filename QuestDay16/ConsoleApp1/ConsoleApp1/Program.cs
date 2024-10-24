using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortedList<T>
    {
        private List<T> _data = new List<T>();
        public int Count => _data.Count;

        public void Add(T data)
        {
            _data.Add(data);    
            _data.Sort();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberList = new SortedList<int>();
            numberList.Add(1);
            numberList.Add(2);

            var numberList2 = new SortedList<string>();
            numberList.Add("Hello");
        }
    }
}
