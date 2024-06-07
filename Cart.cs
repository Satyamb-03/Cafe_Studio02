using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Studio02
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.Price * i.Quantity);

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItem(string name, decimal price, int quantity = 1)
        {
            var item = Items.Find(i => i.Name == name);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem { Name = name, Price = price, Quantity = quantity });
            }
        }

        public void UpdateQuantity(string name, int quantity)
        {
            var item = Items.Find(i => i.Name == name);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public List<string> AddOns { get; set; }

        public CartItem()
        {
            AddOns = new List<string>();
        }
    }

}


