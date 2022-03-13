using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private int exploredPlanets = 0;

        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;
            if (type != "Biologist" && type != "Geodesist" && type != "Meteorologist")
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else
            {
                astronaut = new Meteorologist(astronautName);
            }
            astronauts.Add(astronaut);
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronauts.FindByName(astronautName);
            if (astronauts.Remove(astronaut))
            {
                astronauts.Remove(astronaut);
                return $"Astronaut {astronautName} was retired!";
            }
            else
            {
                return $"Astronaut {astronautName} doesn't exists!";
            }
        }

        public string ExplorePlanet(string planetName)
        {
            ICollection<IAstronaut> astronautsForMission = astronauts.Models.Where(x => x.Oxygen > 60).ToList();
            if (astronautsForMission.Count < 1)
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet");
            }
            IMission mission = new Mission();
            exploredPlanets++;
            mission.Explore(planets.FindByName(planetName),astronautsForMission);
            int deadAstronauts = astronautsForMission.Count(x => x.CanBreath == false);
            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var astronaut in astronauts.Models)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
