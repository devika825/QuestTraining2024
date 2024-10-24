using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            Patient patient = new Patient();

            while (true)
            {
                Console.WriteLine("Doctor Management Application");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. View Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient(patient);
                        break;
                    case "2":
                        ViewPatients(patient);
                        break;
                    case "3":
                        UpdatePatient(patient);
                        break;
                    case "4":
                        DeletePatient(patient);
                        break;
                    case "5":
                        AddDoctor(doctor);
                        break;
                    case "6":
                        ViewDoctors(doctor);
                        break;
                    case "7":
                        UpdateDoctor(doctor);
                        break;
                    case "8":
                        DeleteDoctor(doctor);
                        break;
                    case "9":
                        return; 
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void AddPatient(Patient patient)
        {
            Console.Write("Enter Patient Name: ");
            patient.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            patient.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            patient.Gender = Console.ReadLine();

            Console.Write("Enter Medical Condition: ");
            patient.MedicalCondition = Console.ReadLine();

            patient.AddPatient(patient);
            Console.WriteLine("Patient added successfully.");
        }

        private static void ViewPatients(Patient patient)
        {
            List<Patient> patients = patient.GetPatients();
            Console.WriteLine("\nPatients:");
            foreach (var p in patients)
            {
                Console.WriteLine(p);
            }
        }

        private static void UpdatePatient(Patient patient)
        {
            Console.Write("Enter Patient ID to update: ");
            int id = int.Parse(Console.ReadLine());
            List<Patient> patients = patient.GetPatients();

            Patient existingPatient = patients.Find(p => p.PatientID == id);
            if (existingPatient != null)
            {
                Console.Write("Enter new Name (leave blank to keep current): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName)) existingPatient.Name = newName;

                Console.Write("Enter new Age (leave blank to keep current): ");
                string newAge = Console.ReadLine();
                if (int.TryParse(newAge, out int age)) existingPatient.Age = age;

                Console.Write("Enter new Gender (leave blank to keep current): ");
                string newGender = Console.ReadLine();
                if (!string.IsNullOrEmpty(newGender)) existingPatient.Gender = newGender;

                Console.Write("Enter new Medical Condition (leave blank to keep current): ");
                string newCondition = Console.ReadLine();
                if (!string.IsNullOrEmpty(newCondition)) existingPatient.MedicalCondition = newCondition;

                patient.UpdatePatient(existingPatient);
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        private static void DeletePatient(Patient patient)
        {
            Console.Write("Enter Patient ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            patient.DeletePatient(id);
            Console.WriteLine("Patient deleted successfully.");
        }

        private static void AddDoctor(Doctor doctor)
        {
            Console.Write("Enter Doctor Name: ");
            doctor.Name = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            doctor.Specialization = Console.ReadLine();

            Console.Write("Enter Assigned Patient ID (leave blank if none): ");
            string patientID = Console.ReadLine();
            doctor.PatientID = string.IsNullOrEmpty(patientID) ? (int?)null : int.Parse(patientID);

            doctor.AddDoctor(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        private static void ViewDoctors(Doctor doctor)
        {
            List<Doctor> doctors = doctor.GetDoctors();
            Console.WriteLine("\nDoctors:");
            foreach (var d in doctors)
            {
                Console.WriteLine(d);
            }
        }

        private static void UpdateDoctor(Doctor doctor)
        {
            Console.Write("Enter Doctor ID to update: ");
            int id = int.Parse(Console.ReadLine());
            List<Doctor> doctors = doctor.GetDoctors();

            Doctor existingDoctor = doctors.Find(d => d.DoctorID == id);
            if (existingDoctor != null)
            {
                Console.Write("Enter new Name (leave blank to keep current): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName)) existingDoctor.Name = newName;

                Console.Write("Enter new Specialization (leave blank to keep current): ");
                string newSpecialization = Console.ReadLine();
                if (!string.IsNullOrEmpty(newSpecialization)) existingDoctor.Specialization = newSpecialization;

                Console.Write("Enter new Assigned Patient ID (leave blank to keep current): ");
                string newPatientID = Console.ReadLine();
                existingDoctor.PatientID = string.IsNullOrEmpty(newPatientID) ? (int?)null : int.Parse(newPatientID);

                doctor.UpdateDoctor(existingDoctor);
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        private static void DeleteDoctor(Doctor doctor)
        {
            Console.Write("Enter Doctor ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            doctor.DeleteDoctor(id);
            Console.WriteLine("Doctor deleted successfully.");
        }
    }
    }
   

