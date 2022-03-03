using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private List<Topping> topings;
        private string name;
        private Dough dough;

        public Pizza(string name,Dough dough)
        {
            Name = name;
            this.dough = dough;
            topings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)||value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public int NumberOfTopings => topings.Count;

        public double TotalCalories => dough.Calories + topings.Sum(x => x.Calories);

        public void AddTopping(Topping topping)
        {
            if (this.topings.Count==10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.topings.Add(topping);
        }
    }
}
