using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentDetails
    {
        public string Name;
        public int RegNo;
        public int Class;
        

        public override string ToString()
        {
            return $"Name: {Name},RegNo: {RegNo},Class: {Class}";
        }
    }
}
