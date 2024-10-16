using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartphone
{
    class smartPhone
    {
        public string Name;
        public string Brand;
        public List<int> storageVarients;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            smartPhone s1 = new smartPhone();
            s1.Name = "Galaxy S21";
            s1.Brand = "Samsung";
            s1.storageVarients = new List<int>() { 32,64};
            
            var s2 = new smartPhone()
            {
                Name = "redmi not 12",
                Brand = "Redmi",
                storageVarients = new List<int> { 32,64}
            };



        }
    }
}
