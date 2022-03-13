using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Repositories.Contracts
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> planets;

        public PlanetRepository()
        {
            planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.planets;

        public void Add(IPlanet model)
        {
            this.planets.Add(model);
        }

        public bool Remove(IPlanet model)
        {
            return planets.Remove(model);
        }

        public IPlanet FindByName(string name)
        {
            IPlanet planet = planets.FirstOrDefault(x => x.Name == name);
            return planet;
        }
    }
}
