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
            DoctorManageRepo repo = new DoctorManageRepo();

            while (true)
            {
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
                        AddPatient(repo);
                        break;
                    case "2":
                        ViewPatients(repo);
                        break;
                    case "3":
                        UpdatePatient(repo);
                        break;
                    case "4":
                        DeletePatient(repo);
                        break;
                    case "5":
                        AddDoctor(repo);
                        break;
                    case "6":
                        ViewDoctors(repo);
                        break;
                    case "7":
                        UpdateDoctor(repo);
                        break;
                    case "8":
                        DeleteDoctor(repo);
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void AddPatient(DoctorManageRepo repo)
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter Medical Condition (optional): ");
            string medicalCondition = Console.ReadLine();

            var patient = new Patient
            {
                Name = name,
                Age = age,
                Gender = gender,
                MedicalCondition =medicalCondition
            };
            repo.AddPatient(patient);
            Console.WriteLine("Patient added successfully.");
        }

        private static void ViewPatients(DoctorManageRepo repo)
        {
            List<Patient> patients = repo.GetPatients();
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }
        }

        private static void UpdatePatient(DoctorManageRepo repo)
        {
            Console.Write("Enter Patient ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var patient = repo.GetPatients().Find(p => p.PatientID == id);
            if (patient != null)
            {
                Console.Write("Enter new Name: ");
                patient.Name = Console.ReadLine();
                Console.Write("Enter new Age: ");
                patient.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter new Gender: ");
                patient.Gender = Console.ReadLine();
                Console.Write("Enter new Medical Condition (optional): ");
                string medicalCondition = Console.ReadLine();
                patient.MedicalCondition = string.IsNullOrWhiteSpace(medicalCondition) ? null : medicalCondition;

                repo.UpdatePatient(patient);
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        private static void DeletePatient(DoctorManageRepo repo)
        {
            Console.Write("Enter Patient ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            repo.DeletePatient(id);
            Console.WriteLine("Patient deleted successfully.");
        }

        private static void AddDoctor(DoctorManageRepo repo)
        {
            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Specialization: ");
            string specialization = Console.ReadLine();
            Console.Write("Enter Assigned Patient ID (optional): ");
            int? patientId = null;
            string patientIdInput = Console.ReadLine();
            if (int.TryParse(patientIdInput, out int id))
            {
                patientId = id;
            }

            var doctor = new Doctor
            {
                Name = name,
                Specialization = specialization,
                PatientID = patientId
            };
            repo.AddDoctor(doctor);
            Console.WriteLine("Doctor added successfully.");
        }

        private static void ViewDoctors(DoctorManageRepo repo)
        {
            List<Doctor> doctors = repo.GetDoctors();
            foreach (var doctor in doctors)
            {
                Console.WriteLine(doctor);
            }
        }

        private static void UpdateDoctor(DoctorManageRepo repo)
        {
            Console.Write("Enter Doctor ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var doctor = repo.GetDoctors().Find(d => d.DoctorID == id);
            if (doctor != null)
            {
                Console.Write("Enter new Name: ");
                doctor.Name = Console.ReadLine();
                Console.Write("Enter new Specialization: ");
                doctor.Specialization = Console.ReadLine();
                Console.Write("Enter new Patient ID (optional): ");
                string patientIdInput = Console.ReadLine();
                doctor.PatientID = string.IsNullOrWhiteSpace(patientIdInput) ? (int?)null : int.Parse(patientIdInput);

                repo.UpdateDoctor(doctor);
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }
        }

        private static void DeleteDoctor(DoctorManageRepo repo)
        {
            Console.Write("Enter Doctor ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            repo.DeleteDoctor(id);
            Console.WriteLine("Doctor deleted successfully.");
        }
    }
    }

