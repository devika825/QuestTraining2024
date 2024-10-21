using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
               new Patient { Id = 1, Name = "John Doe", Age = 65, Gender = "Male", MedicalCondition = "Diabetes" },
               new Patient { Id = 2, Name = "Jane Smith", Age = 45, Gender = "Female", MedicalCondition = "Hypertension" },
               new Patient { Id = 3, Name = "Bob Brown", Age = 70, Gender = "Male", MedicalCondition = "Diabetes" },
               new Patient { Id = 4, Name = "Alice White", Age = 30, Gender = "Female", MedicalCondition = "Asthma" }
            };

            var appointments = new List<Appointment>
             {
                  new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Consultation" },
                  new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Baker", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Follow-up" },
                  new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Clark", AppointmentDate = DateTime.Now.AddDays(7), AppointmentType = "Surgery" },
                  new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Consultation" },

             };
            //q1
            var upcomingAppointments = appointments
                   .Where(appt => appt.AppointmentDate >= DateTime.Now && appt.AppointmentDate <= DateTime.Now.AddDays(7))
                   .Join(patients, appt => appt.PatientId, patient => patient.Id,
                    (appt, patient) => new
                      {
                          patient.Name,
                          patient.Age,
                          patient.MedicalCondition,
                          appt.AppointmentDate
                      });

            Console.WriteLine("Patients with upcoming appointments within the next 7 days:");
            foreach (var result in upcomingAppointments)
            {
                Console.WriteLine($"Name: {result.Name}, Age: {result.Age}, Medical Condition: {result.MedicalCondition}, Appointment Date: {result.AppointmentDate}");
            }

            //q2

            var upcomingAppointmentsGroupedByCondition = appointments
                    .Where(appt => appt.AppointmentDate >= DateTime.Now && appt.AppointmentDate <= DateTime.Now.AddDays(7))
                    .Join(patients, appt => appt.PatientId, patient => patient.Id,
                    (appt, patient) => new { patient.MedicalCondition })
                    .GroupBy(patient => patient.MedicalCondition)
                    .Select(group => new
                    {
                      MedicalCondition = group.Key,
                      Count = group.Count()
                    });
            Console.WriteLine("\nUpcoming appointments grouped by medical condition:");
            foreach (var result in upcomingAppointmentsGroupedByCondition)
            {
                Console.WriteLine($"Medical Condition: {result.MedicalCondition}, Number of Patients: {result.Count}");
            }

            //q3




            //q4

            var patientsOver60WithMostRecentAppointment = patients
                    .Where(patient => patient.Age > 60)
                    .Join(appointments, patient => patient.Id, appt => appt.PatientId,
                    (patient, appt) => new
                       {
                         patient.Id,
                         patient.Name,
                         appt.DoctorName,
                         appt.AppointmentDate,
                         appt.AppointmentType
                        })
                       .GroupBy(p => p.Id)
                       .Select(group => group
                       .OrderByDescending(appt => appt.AppointmentDate)
                       .First()
                         );

            Console.WriteLine("\nPatients over 60 with their most recent appointment:");
            foreach (var result in patientsOver60WithMostRecentAppointment)
            {
                Console.WriteLine($"Patient Name: {result.Name}, Doctor: {result.DoctorName}, Date: {result.AppointmentDate}, Type: {result.AppointmentType}");
            }



        }
    }
}
