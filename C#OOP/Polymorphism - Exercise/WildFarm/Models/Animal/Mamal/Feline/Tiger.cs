using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double Modifire => 1.0;

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
            Console.WriteLine("ROAR!!!");
        }
    }
}
