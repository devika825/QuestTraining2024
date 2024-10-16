using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Credit Card");
                Console.WriteLine("2. Update Credit Card");
                Console.WriteLine("3. Delete Credit Card");
                Console.WriteLine("4. Search Credit Card");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();

                 switch(option)
                    {
                    case "1":
                        
                        break;
                    case "2":
                       
                        break;
                    case "3":
                    
                        break;
                    case "4":
                      
                        break;
                    case "5":
                        return; 
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;

                }
                
            }
        }
    }
}
