using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }

        public string Material { get; set; }

        public int Capacity { get; set; }

        public IReadOnlyCollection<Fish> Fish => fish;

        public int Count => this.fish.Count;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrEmpty(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }

            if (this.fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }

            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            Fish fish = this.fish.FirstOrDefault(x => x.Weight == weight);
            return this.fish.Remove(fish);
        }

        public Fish GetFish(string fishType)
        {
            Fish fish = this.fish.FirstOrDefault(x => x.FishType == fishType);
            return fish;
        }

        public Fish GetBiggestFish()
        {
            Fish fish = this.fish.OrderByDescending(x => x.Length).FirstOrDefault();
            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in this.fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
