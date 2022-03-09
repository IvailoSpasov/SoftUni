using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double Modifire => 0.1;

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
            if (food is Vegetable || food is Fruit)
            {
                return true;
            }

            return false;
        }
        public override void ProduceSount()
        {
            Console.WriteLine("Squeak");
        }
    }
}
