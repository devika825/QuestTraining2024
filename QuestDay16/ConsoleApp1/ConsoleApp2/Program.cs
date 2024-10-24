using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyDictionary<Tkey,Tvalue>
    {
        private Dictionary<Tkey,Tvalue> _data = new Dictionary<Tkey,Tvalue>();

        public void Add(Tkey key, Tvalue value)
        {
            _data.Add(key, value);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new MyDictionary<string,string>();
            data.Add("Name", "Devika");
        }
    }
}
