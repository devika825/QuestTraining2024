using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
   public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }

        public override string ToString()
        {
            return $"ID: {PatientID}, Name: {Name}, Age: {Age}, Gender: {Gender}, Medical Condition: {MedicalCondition}";
        }
    }
}
