using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CardDetails
    {
        public int CardNumber;
        public string CardHolderName;
        public byte ExpiryMonth;
        public int ExpiryYear;
        public int Cvc;

        public List<CardDetails> Card = new List<CardDetails>();

        public void AddCreditCard()
        {

            Console.WriteLine("Enter Card Number:");
            var cardNumber = Console.ReadLine();

            Console.WriteLine("Enter the Card Holder's Name:");
            var cardHolderName = Console.ReadLine();

            Console.WriteLine("Enter the Expiry Date (MM/YY):");
            var expiry = Console.ReadLine();

            Console.WriteLine("Enter the CVC:");
            var cvc = Console.ReadLine();

            CardDetails newCard = new CardDetails();
            {
                CardNumber = int.Parse(cardNumber);
                CardHolderName = cardHolderName;
                ExpiryMonth = byte.Parse(expiry.Split('/')[0]);
                ExpiryYear = int.Parse("20" + expiry.Split('/')[1]);
                Cvc = int.Parse(cvc);
            };

            Card.Add(newCard);
            Console.WriteLine("Credit Card added successfully!");
        }
           public void UpdateCreditCard()
            {
                Console.WriteLine("Enter the Card Number to update:");
                var cardNumber = Console.ReadLine();
            }
            
    }
}
