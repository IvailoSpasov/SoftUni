using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private int capacity;
        private ICollection<IEquipment> equipment;
        private ICollection<IAthlete> athletes;

        public Gym(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            equipment = new List<IEquipment>();
            athletes = new List<IAthlete>();

        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Capacity
        {
            get => this.capacity;
            set
            {
                this.capacity = value;
            }
        }
        public double EquipmentWeight
        {
            get => equipment.Sum(x => x.Weight);
        }

        public ICollection<IEquipment> Equipment
        {
            get => this.equipment;
        }

        public ICollection<IAthlete> Athletes
        {
            get => this.athletes;
        }

        public void AddAthlete(IAthlete athlete)
        {
            if (this.Capacity == this.Athletes.Count)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }
            this.athletes.Add(athlete);
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return this.athletes.Remove(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {this.GetType().Name}:");
            if (athletes.Count != 0)
            {
                sb.AppendLine($"Athletes: {string.Join(", ", athletes.Select(x => x.FullName))}");
            }
            else
            {
                sb.AppendLine("Athletes: No athletes");
            }

            sb.AppendLine($"Equipment total count: {equipment.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight} grams");
            return sb.ToString().TrimEnd();
        }
    }
}
