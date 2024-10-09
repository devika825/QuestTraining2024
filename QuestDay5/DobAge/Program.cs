using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth (yyyy-mm-dd):");

            // Read the input from the console
            string input = Console.ReadLine();

            // Manually parse the date
            DateTime dob;
            if (ParseDate(input, out dob))
            {
                // Calculate the age
                int age = CalculateAge(dob);

                // Print the age
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format.");
            }
        }

        // Method to parse the date manually
        static bool ParseDate(string input, out DateTime dob)
        {
            dob = DateTime.MinValue; // Initialize to an invalid date
            string[] parts = input.Split('-'); // Split the input by '-'

            // Check if we have exactly 3 parts
            if (parts.Length != 3)
            {
                return false; // Invalid format
            }

            // Try to parse year, month, and day
            int year, month, day;
            if (int.TryParse(parts[0], out year) &&
                int.TryParse(parts[1], out month) &&
                int.TryParse(parts[2], out day))
            {
                // Validate the month and day ranges
                if (month < 1 || month > 12 || day < 1 || day > 31)
                {
                    return false; // Invalid month or day
                }

                try
                {
                    // Create the DateTime object
                    dob = new DateTime(year, month, day);
                    return true; // Successful parsing
                }
                catch (ArgumentOutOfRangeException)
                {
                    return false; // Invalid date (e.g., Feb 30)
                }
            }

            return false; // Parsing failed
        }

        // Method to calculate age
        static int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            // Adjust the age if the birthday hasn't occurred yet this year
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;

        }

     
        


        
    }
}
