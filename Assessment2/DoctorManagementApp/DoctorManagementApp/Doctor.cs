using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
  public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int? PatientID { get; set; }

        public override string ToString()
        {
            return $"ID: {DoctorID}, Name: {Name}, Specialization: {Specialization}, Assigned Patient ID: {PatientID}";
        }
    }
}
