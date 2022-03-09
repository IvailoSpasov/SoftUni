using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double Modifire => 0.35;

        public override void Eat(Food food)
        {
            base.Eat(food);
        }


        public override void ProduceSount()
        {
            Console.WriteLine("Cluck");
        }
    }
}
