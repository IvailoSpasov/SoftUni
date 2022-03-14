using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipment;
        private List<IGym> gyms;

        public Controller()
        {
            equipment = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddGym(string gymType, string gymName)
        {
            Models.Gyms.Gym gym;
            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }
            gyms.Add(gym);
            return $"Successfully added {gymType}.";
        }

        public string AddEquipment(string equipmentType)
        {
            Equipment equipment;
            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }
            this.equipment.Add(equipment);
            return $"Successfully added {equipmentType}.";
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment eq = this.equipment.FindByType(equipmentType);
            if (eq == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }

            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);
            int index = gyms.IndexOf(gym);

            gyms[index].AddEquipment(eq);
            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);
            IAthlete athlete;
            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name != "BoxingGym")
                {
                    return "The gym is not appropriate.";
                }
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name != "WeightliftingGym")
                {
                    return "The gym is not appropriate.";
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }

            int index = gyms.IndexOf(gym);
            gyms[index].AddAthlete(athlete);
            return $"Successfully added {athleteType} to {gymName}.";
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);
            int index = gyms.IndexOf(gym);
            gyms[index].Exercise();
            return $"Exercise athletes: {gym.Athletes.Count}.";
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);
            return $"The total weight of the equipment in the gym {gymName} is {gym.EquipmentWeight:f2} grams.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
