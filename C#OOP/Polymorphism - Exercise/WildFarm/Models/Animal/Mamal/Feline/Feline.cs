﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
     public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingRegion,string breed) 
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
