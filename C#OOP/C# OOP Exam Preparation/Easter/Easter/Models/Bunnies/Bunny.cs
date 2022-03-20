using System;
using System.Collections.Generic;
using System.Text;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private string name;
        private int energy;

        public Bunny(string name, int energy)
        {
            Name = name;
            Energy = energy;
            Dyes = new List<IDye>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Bunny name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Energy
        {
            get => this.energy;
            set
            {
                if (value < 0)
                {
                    this.energy = 0;
                }

                this.energy = value;
            }
        }

        public ICollection<IDye> Dyes { get; set; }
    

        public abstract void Work();


        public void AddDye(IDye dye)
        {
            Dyes.Add(dye);
        }
    }
}
