using System;
using System.Collections.Generic;
using System.Text;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        public Planet(string name)
        {
            Name = name;
            Items = new List<string>();
        }
        public ICollection<string> Items { get; set; }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                this.name = value;
            }
        }
    }
}
