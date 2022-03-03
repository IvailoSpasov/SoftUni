using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
   public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            products = new List<Product>();
        }

        public IReadOnlyCollection<Product> Products => products;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public string BuyProduct(Product product)
        {
            if (this.money-product.Cost>=0)
            {
                products.Add(product);
                this.money -= product.Cost;
                return $"{this.name} bought {product.Name}";
            }

            return $"{this.name} can't afford {product.Name}";
        }
    }
}
