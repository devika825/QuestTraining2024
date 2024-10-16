using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Students
    {
        public string name;
        public int mark1;
        public int mark2;
        public int mark3;

        public void TotalMark()
        {
            int total = mark1 + mark2 + mark3;
            Console.WriteLine($"Total marks for{name}: {total}");
            
        }
        public void AverageMark()
        {
            decimal average = (mark1 + mark2 + mark3) / 3;
            Console.WriteLine($"Average marks for{name} : {average}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.name = "John";
            s1.mark1 = 90;
            s1.mark2 = 99;
            s1.mark3 = 97;

            Students s2 = new Students();
            s2.name = "James";
            s2.mark1 = 98;
            s2.mark2 = 95;
            s2.mark3 = 92;

            s1.TotalMark();
            s1.AverageMark();

            s2.TotalMark();
            s2.AverageMark();

        }
    }
}
