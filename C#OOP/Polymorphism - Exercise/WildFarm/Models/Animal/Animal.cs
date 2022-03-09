using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public abstract class Animal
    {
        public Animal(string name,double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public virtual double Modifire { get; set; }


        public abstract void ProduceSount();

        public virtual void Eat(Food food)
        {
            FoodEaten += food.Quantity;
            Weight += food.Quantity * Modifire;
        }

    }
}
