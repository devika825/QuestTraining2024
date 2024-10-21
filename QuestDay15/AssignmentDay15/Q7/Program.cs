using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Amritha", "Sam", "Akhil", "Alen", "John", "Joel", "Bindhu", "Binil" };

            List<int> marks = new List<int> { 85, 78, 90, 82, 76 };

            var res = names
                .Zip(marks, (name, mark) => { return new { name, mark }; })

                              .Where(s => s.mark > 80)
                              .Select(s=>s.name);
            foreach (var student in res)
            {
                Console.WriteLine(student);
            }
        }
    }
}
