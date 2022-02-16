using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> racers;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }


        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => racers.Count;

        public void Add(Racer racer)
        {
            if (racers.Count < Capacity)
            {
                racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = racers.FirstOrDefault(x => x.Name == name);
            return racers.Remove(racer);
        }

        public Racer GetOldestRacer()
        {
            Racer racer = racers.OrderByDescending(x => x.Age).FirstOrDefault();
            return racer;
        }

        public Racer GetRacer(string name)
        {
            Racer racer = racers.FirstOrDefault(x => x.Name == name);
            return racer;
        }

        public Racer GetFastestRacer()
        {
            Racer racer = racers.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            return racer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in racers)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
