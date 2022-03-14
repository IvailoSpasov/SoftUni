﻿using System;
using System.Collections.Generic;
using System.Text;
using Gym.Models.Equipment.Contracts;

namespace Gym.Models.Equipment
{
    public abstract class Equipment : IEquipment
    {
        private double weight;
        private decimal price;

        public Equipment(double weight, decimal price)
        {
            this.Weight = weight;
            this.Price = price;
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                this.weight = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }
    }
}
