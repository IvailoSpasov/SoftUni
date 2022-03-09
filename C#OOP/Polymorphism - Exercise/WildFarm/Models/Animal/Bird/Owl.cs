using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double Modifire => 0.25;

        public override void Eat(Food food)
        {
            if (CanIEatThis(food))
            {
                base.Eat(food);
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        private bool CanIEatThis(Food food)
        {
            if (food is Meat)
            {
                return true;
            }

            return false;
        }

        public override void ProduceSount()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
