using System;
using System.Collections.Generic;
using System.Text;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        private const int oxygenToBreath = 10;

        public Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
            Bag = new Backpack();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Astronaut name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public double Oxygen
        {
            get => this.oxygen;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot create Astronaut with negative oxygen!");
                }

                this.oxygen = value;
            }
        }
        public bool CanBreath => Oxygen > 0 ? true : false;

        public IBag Bag { get; set; }
        
        public virtual void Breath()
        {
            if (Oxygen>=oxygenToBreath)
            {
                Oxygen -= oxygenToBreath;
            }
            else
            {
                Oxygen = 0;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Oxygen: {Oxygen}");
            if (Bag.Items.Count>0)
            {
                sb.AppendLine($"Bag items: {string.Join(", ", Bag.Items)}");
            }
            else
            {
                sb.AppendLine($"Bag items: none");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
