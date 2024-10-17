using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Subject
    {
        public string SubjectName;
        public int MarksObtained;
        public int MaxMark;

        public override string ToString()
        {
            return $"SubjectName : {SubjectName}, MarksObtained : {MarksObtained}, MaxMark : {MaxMark}";
        }
    }
}
