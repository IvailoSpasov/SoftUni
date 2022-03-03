using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private readonly Dictionary<string, double> modifires = new Dictionary<string, double>()
        {
            {"white", 1.5},
            {"wholegrain", 1.0},
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0},

        };
        private string doughType;
        private string bakingTechnique;
        private int weight;

        public Dough(string doughType, string bakingTechnique, int weight)
        {
            this.DoughType = doughType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string DoughType
        {
            get
            {
                return doughType;
            }
            private set
            {
                if (!modifires.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                doughType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                if (!modifires.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double Calories =>
            (Weight * 2) * modifires[DoughType.ToLower()] * modifires[BakingTechnique.ToLower()];



    }
}
