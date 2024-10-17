using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CreditCardManager
    {
       private List<CardDetails> creditCards = new List<CardDetails>();

        public void Add(CardDetails card)
        {
            foreach(var item in creditCards)
            {
                if (item.CardNumber == card.CardNumber)
                {
                    Console.WriteLine("card already exists");
                    return;
                }

            }
            creditCards.Add(card);
            Console.WriteLine("Added successfully");
        }

        public void Search(string CardNumber)
        {
            foreach (var card in creditCards)
            {
               if(card.CardNumber == CardNumber)
                {
                    Console.WriteLine(card);
                }
            }
        }
    }
}
