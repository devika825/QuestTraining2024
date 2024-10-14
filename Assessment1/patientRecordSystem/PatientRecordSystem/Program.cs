using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecordSystem
{
    internal class Program
    {

        static Dictionary<string, Dictionary<string, object>> patientHistory = new Dictionary<string, Dictionary<string, object>>();

        static void AddPatient()
        {
            var patientDetails = new Dictionary<string, object>();

            Console.WriteLine("Enter the patient's Name");
            patientDetails["Name"] = Console.ReadLine();

            Console.WriteLine("Enter the patient's age");
            patientDetails["Age"] = Console.ReadLine();

            Console.WriteLine("Enter patient's Diagnosis");
            patientDetails["Diagnosis"] = Console.ReadLine();

            Console.WriteLine("Is the patient admitted or not");
            patientDetails["IsAdmitted"] = Console.ReadLine().Trim().ToLower() == "yes";

            string patientId = Guid.NewGuid().ToString();
            patientHistory[patientId] = patientDetails;

            Console.WriteLine($"Patient added successfully! Patient ID: {patientId}");

        }

        static void SearchPatient()
        {
            Console.Write("Enter Patient ID or Name to search: ");
            string input = Console.ReadLine().Trim();

           
            if (patientHistory.TryGetValue(input, out var patientDetails))
            {
              
                Console.WriteLine("Patient found:");
                Console.WriteLine($"Patient ID: {input}");
                Console.WriteLine($"Name: {patientDetails["Name"]}");
                Console.WriteLine($"Age: {patientDetails["Age"]}");
                Console.WriteLine($"Diagnosis: {patientDetails["Diagnosis"]}");
                Console.WriteLine($"Admission Status: {((bool)patientDetails["IsAdmitted"] ? "Admitted" : "Discharged")}");
            }

        
            else
            {
               
                bool found = false;
                foreach (var patientEntry in patientHistory)
                {
                    if (patientEntry.Value["Name"].ToString().Trim().ToLower() == input.ToLower())
                    {
                        
                        Console.WriteLine("Patient found:");
                        Console.WriteLine($"Patient ID: {patientEntry.Key}");
                        Console.WriteLine($"Name: {patientEntry.Value["Name"]}");
                        Console.WriteLine($"Age: {patientEntry.Value["Age"]}");
                        Console.WriteLine($"Diagnosis: {patientEntry.Value["Diagnosis"]}");
                        Console.WriteLine($"Admission Status: {((bool)patientEntry.Value["IsAdmitted"] ? "Admitted" : "Discharged")}");


                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No patients found with the given ID or Name.");
                }
            }
        }


        static void UpdatePatient()
        {
            Console.WriteLine("Enter the patient id to update");
            string patientId = Console.ReadLine();

            if (patientHistory.TryGetValue(patientId, out var patientDetails))
            {
                Console.Write("Enter the new Diagnosis: ");
                patientDetails["Diagnosis"] = Console.ReadLine();

                Console.Write("Is the patient admitted? (yes/no): ");
                patientDetails["IsAdmitted"] = Console.ReadLine().Trim().ToLower() == "yes";

                Console.WriteLine("Patient details updated successfully!");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }

        }


        static void ListAdmittedPatients()
        {
            Console.WriteLine("Currently Admitted Patients Details:");

            bool found = false;
            foreach (var patient in patientHistory)
            {
                if ((bool)patient.Value["IsAdmitted"])
                {
                    Console.WriteLine($"Patient ID: {patient.Key}");
                    Console.WriteLine($"Name: {patient.Value["Name"]}");
                    Console.WriteLine($"Age: {patient.Value["Age"]}");
                    Console.WriteLine($"Diagnosis: {patient.Value["Diagnosis"]}");
                    Console.WriteLine("Admission Status: Admitted");
                   

                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients are currently admitted.");
            }
        }




        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("PATIENT RECORD SYSTEM");
                Console.WriteLine("1.ADD PATIENT");
                Console.WriteLine("2.SEARCH PATIENT");
                Console.WriteLine("3.UPDATE PATIENT HISTORY");
                Console.WriteLine("4.LIST OF ADMITTED PATIENTS");
                Console.WriteLine("5. EXIT");

                Console.WriteLine("Choose an option");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchPatient();
                        break;
                    case "3":
                        UpdatePatient();
                        break;
                    case "4":
                        ListAdmittedPatients();
                        break;
                    case "5":return;

                    default: Console.WriteLine("Invalid option");
                        break;
                }

            }
        }
    }
}
