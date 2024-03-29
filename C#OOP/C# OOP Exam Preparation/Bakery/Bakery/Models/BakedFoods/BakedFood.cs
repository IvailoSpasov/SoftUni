﻿using System;
using System.Collections.Generic;
using System.Text;
using Bakery.Models.BakedFoods.Contracts;

namespace Bakery.Models.BakedFoods
{
    public abstract class BakedFood : IBakedFood
    {
        private string name;
        private int portion;
        private decimal price;

        public BakedFood(string name, int portion, decimal price)
        {
            Name = name;
            Portion = portion;
            Price = price;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }

                this.name = value;
            }
        }
        public int Portion
        {
            get => this.portion;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Portion cannot be less or equal to zero");
                }

                this.portion = value;
            }
        }
        public decimal Price
        {
            get => this.price;
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{Name}: {Portion}g - {Price:f2}";
        }
    }
}
