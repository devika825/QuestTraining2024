using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CardDetails
    {
        public string CardNumber;
        public string CardHolderName;
        public string Expiry;
        public int Cvc;

        public override string ToString()
        {
            return $"CardHolderName: {CardHolderName}, CardNumber: {CardNumber},  Expiry: {Expiry}, Cvc: {Cvc}";

        }
    }
}
