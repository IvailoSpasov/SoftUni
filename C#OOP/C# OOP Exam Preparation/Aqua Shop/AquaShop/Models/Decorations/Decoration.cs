using System;
using System.Collections.Generic;
using System.Text;
using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Models.Decorations
{
    public abstract class Decoration : IDecoration
    {
        private int comfort;
        private decimal price;

        public Decoration(int comfort, decimal price)
        {
            this.comfort = comfort;
            this.price = price;
        }

        public int Comfort => this.comfort;
        public decimal Price => this.price;
    }
}
