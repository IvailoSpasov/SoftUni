using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
   public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double Modifire => 0.30;

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
            if (food is Meat || food is Vegetable)
            {
                return true;
            }

            return false;
        }

        public override void ProduceSount()
        {
            Console.WriteLine("Meow");
        }
    }
}
