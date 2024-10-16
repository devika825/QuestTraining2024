using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc = new CreditCard();

            Console.WriteLine("Enter Card Number");
            cc.CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry");
            cc.Expiry = Console.ReadLine();

            Console.WriteLine("Enter the cvc");
            cc.Cvc = int.Parse(Console.ReadLine());
        }
    }       
}
