using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1console
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, Money price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void ApplyDiscount(int percent)
        {
            int totalCents = Price.Dollars * 100 + Price.Cents;
            totalCents = totalCents - (totalCents * percent / 100);
            Price.SetValue(totalCents / 100, totalCents % 100);
        }

        public override string ToString()
        {
            return $"{Name}: {Quantity} шт. по {Price}";
        }
    }
}