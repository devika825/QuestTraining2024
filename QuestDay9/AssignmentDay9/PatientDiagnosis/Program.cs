using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDiagnosis
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();

        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptoms as comma seperated values :");
            patient.Add("symptoms", Console.ReadLine());

           var id = Guid.NewGuid().ToString();
            patient.Add("id", id);
            patients.Add(patient);

            Console.WriteLine($"patient added successfully: {id}");


        }

        static void GetPatientById()
        {
            Console.WriteLine("Enter patient id: ");
            var id = Console.ReadLine();
            bool found = false;

            foreach (var patient in patients)
            {
                if (patient.TryGetValue("id", out var patientId) && patientId == id)
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Symptoms: " + patient["symptoms"]);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Patient not found.");
            }
        }


    

    static void GetPatientsBySymptom()
        {
            Console.WriteLine("Enter the symptom to search for: ");
            var symptomToSearch = Console.ReadLine();

            Console.WriteLine("Patients with the symptom: " + symptomToSearch);
            bool found = false;

            foreach (var patient in patients)
            {
                var symptoms = patient["symptoms"].Split(',');

                if (Array.Exists(symptoms, symptom => symptom.Trim().Equals(symptomToSearch, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Patient ID: " + patient["id"] + ", Name: " + patient["name"]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients found with the symptom: " + symptomToSearch);
            }
        }

    

            static void Main(string[] args)
            {
               
                while (true)
                {
                    Console.WriteLine("1. Add patient");
                    Console.WriteLine("2. Search patient");
                    Console.WriteLine("3. Search patients by symptom");
                    Console.WriteLine("4. Exit");

                var option = Console.ReadLine();

              

                    switch (option)
                    {
                        case "1":
                            AddPatient();
                            break;
                        case "2":
                            GetPatientById(); 
                             break;
                    case "3":
                        GetPatientsBySymptom();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                    }
                }
            }
    }
}
