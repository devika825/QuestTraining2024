using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceCartManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem("Product 1", 30, 55));
            cart.Add(new CartItem("Product 2", 10, 890));
            cart.Add(new CartItem("Product 3", 80, 560));

            cart.Update("Product 1", 80, 40);
            cart.Remove("Product 3");

            var bill = new Billing();
            var discount = new PercentageDiscount();
            decimal billValue = bill.TotalPrice(cart, discount);




            Console.WriteLine(billValue);

        }
    }
}
