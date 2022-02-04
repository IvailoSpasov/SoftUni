using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Trainer
    {
        private int numberOfBadges;
        private List<Pokemon> pokemons;


        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            pokemons = new List<Pokemon>();

        }
        public string Name { get; set; }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }

        }
        public int NumberOfBadges { get; set; }

        
    }
}
