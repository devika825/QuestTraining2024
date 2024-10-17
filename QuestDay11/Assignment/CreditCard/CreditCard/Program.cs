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
            var ccManager = new CreditCardManager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Credit Card");
                Console.WriteLine("2. Update Credit Card");
                Console.WriteLine("3. Delete Credit Card");
                Console.WriteLine("4. Search Credit Card");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var card = GetCardData();
                        ccManager.Add(card);
                        break;
                    case "2":
                        Console.WriteLine("Enter the number to search");
                        var cardNumber = Console.ReadLine();
                        ccManager.Search(cardNumber);
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
                private static CardDetails GetCardData()
                {
                   CardDetails card = new CardDetails();

                    Console.Write("Enter the card holder name: ");
                    card.CardHolderName = Console.ReadLine();

                    Console.Write("Enter the card number: ");
                    card.CardNumber = Console.ReadLine();

                    Console.Write("Enter the card expiry date: ");
                    card.Expiry = Console.ReadLine();

                    Console.Write("Enter the security number: ");
                    card.Cvc = int.Parse(Console.ReadLine());
                    return card;
                }
            
        
    }
}
