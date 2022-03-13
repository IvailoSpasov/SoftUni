using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const int oxygenToBreath = 5;
        public Biologist(string name)
            : base(name, 70)
        {
        }

        public override void Breath()
        {
            if (Oxygen >= oxygenToBreath)
            {
                Oxygen -= oxygenToBreath;
            }
            else
            {
                Oxygen = 0;
            }
        }
    }
}
