using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new Dictionary<string, Car>();
        }


        public readonly Dictionary<string, Car> Participants;

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void Add(Car car)
        {
            if (!Participants.ContainsKey(car.LicensePlate))
            {
                if (Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
                {
                    Participants.Add(car.LicensePlate, car);
                }
            }
        }

        public bool Remove(string licensePlate)
        {
            if (Participants.ContainsKey(licensePlate))
            {
                Participants.Remove(licensePlate);
                return true;
            }

            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            if (Participants.ContainsKey(licensePlate))
            {
                return Participants[licensePlate];
            }

            return null;
        }

        public Car GetMostPowerfulCar()
        {
            if (Participants.Count > 0)
            {
                foreach (var car in Participants.OrderByDescending(x => x.Value.HorsePower).Take(1))
                {
                    return car.Value;
                }
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(
                    $"Make: {car.Value.Make}\nModel: {car.Value.Model}\nLicense Plate: {car.Value.LicensePlate}\nHorse Power: {car.Value.HorsePower}\nWeight: {car.Value.Weight}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
