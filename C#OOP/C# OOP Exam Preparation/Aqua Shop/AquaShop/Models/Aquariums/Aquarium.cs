using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;

        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Decorations = new List<IDecoration>();
            Fish = new List<IFish>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }

                this.name = value;
            }
        }
        public int Capacity { get; set; }

        public int Comfort => Decorations.Sum(x => x.Comfort);

        public ICollection<IDecoration> Decorations { get; set; }

        public ICollection<IFish> Fish { get; set; }

        public void AddFish(IFish fish)
        {
            if (Fish.Count == Capacity)
            {
                throw new ArgumentException("Not enough capacity.");
            }
            Fish.Add(fish);
        }

        public bool RemoveFish(IFish fish)
        {
            return Fish.Remove(fish);
        }

        public void AddDecoration(IDecoration decoration)
        {
            Decorations.Add(decoration);
        }

        public void Feed()
        {
            foreach (var fish in Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} ({this.GetType().Name}):");
            if (Fish.Count != 0)
            {
                sb.AppendLine($"Fish: {string.Join(", ", Fish.Select(x => x.Name))}");
            }
            else
            {
                sb.AppendLine("Fish: none");
            }

            sb.AppendLine($"Decorations: {Decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");
            return sb.ToString().TrimEnd();
        }
    }
}
