using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private Dictionary<string, Dictionary<string, Ski>> data;
        private int counter;

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.data = new Dictionary<string, Dictionary<string, Ski>>();
            this.counter = 0;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => counter;

        public void Add(Ski ski)
        {
            if (this.counter < Capacity)
            {
                if (!data.ContainsKey(ski.Manufacturer))
                {
                    data.Add(ski.Manufacturer, new Dictionary<string, Ski>());

                }
                data[ski.Manufacturer].Add(ski.Model, ski);
                counter++;

            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.ContainsKey(manufacturer) && data[manufacturer].ContainsKey(model))
            {
                data[manufacturer].Remove(model);
                counter--;
                return true;
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            Ski newestSki = null;
            if (data.Count > 0)
            {
                int newestYear = 0;
                foreach (var kvp in data)
                {
                    foreach (var ski in kvp.Value)
                    {
                        if (ski.Value.Year > newestYear)
                        {
                            newestYear = ski.Value.Year;
                            newestSki = ski.Value;
                        }
                    }
                }
            }

            return newestSki;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (data.ContainsKey(manufacturer) && data[manufacturer].ContainsKey(model))
            {
                return data[manufacturer][model];
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var kvp in data)
            {
                foreach (var ski in kvp.Value)
                {
                    sb.AppendLine(ski.Value.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
