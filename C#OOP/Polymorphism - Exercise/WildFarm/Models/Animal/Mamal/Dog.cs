using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
   public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double Modifire => 0.40;

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
            Console.WriteLine("Woof!");
        }
    }
}
