using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != "FreshwaterAquarium" && aquariumType != "SaltwaterAquarium")
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            IAquarium aquarium;
            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            aquariums.Add(aquarium);
            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            IDecoration decoration;
            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else
            {
                decoration = new Plant();
            }
            decorations.Add(decoration);

            return $"Successfully added {decorationType}.";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoratin = decorations.FindByType(decorationType);
            if (decoratin == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            decorations.Remove(decoratin);
            aquariums.First(x => x.Name == aquariumName).AddDecoration(decoratin);
            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            IFish fish;
            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }

            string aquariumType = aquariums.First(x => x.Name == aquariumName).GetType().Name;
            if (aquariumType == "FreshwaterAquarium" && fishType == "SaltwaterFish")
            {
                return "Water not suitable.";
            }
            else if (aquariumType == "SaltwaterAquarium" && fishType == "FreshwaterFish")
            {
                return "Water not suitable.";
            }
            else
            {
                aquariums.First(x=>x.Name==aquariumName).AddFish(fish);
                return $"Successfully added {fishType} to {aquariumName}.";
            }

        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            aquarium.Feed();
            return $"Fish fed: {aquarium.Fish.Count}";
        }

        public string CalculateValue(string aquariumName)
        {
            decimal fishSum = aquariums.First(x => x.Name == aquariumName).Fish.Sum(x => x.Price);
            decimal decorationSum = aquariums.First(x => x.Name == aquariumName).Decorations.Sum(x => x.Price);
            decimal totalSum = fishSum + decorationSum;
            return $"The value of Aquarium {aquariumName} is {totalSum:f2}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
