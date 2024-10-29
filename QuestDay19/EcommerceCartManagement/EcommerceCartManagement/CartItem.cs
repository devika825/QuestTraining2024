using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceCartManagement
{
    public class CartItem
    {
        public string Name { get; }
        public int Quantity { get; set; }

        public int Price { get; set; }

        public CartItem(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
