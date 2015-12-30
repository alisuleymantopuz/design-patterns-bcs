using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern2
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this.DiscountedPrice = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal DiscountedPrice { get; set; }

    }
}
