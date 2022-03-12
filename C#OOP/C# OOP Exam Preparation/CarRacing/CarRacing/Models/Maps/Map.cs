using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (!(racerOne.IsAvailable() && racerTwo.IsAvailable()))
            {
                return "Race cannot be completed because both racers are not available!";
            }
            else if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (!racerTwo.IsAvailable())
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            racerOne.Race();
            racerTwo.Race();
            double racerOneMultiplier = 0;
            double racerTwoMultiplier = 0;
            if (racerOne.RacingBehavior == "strict")
            {
                racerOneMultiplier = 1.2;
            }
            else
            {
                racerOneMultiplier = 1.1;
            }
            if (racerTwo.RacingBehavior == "strict")
            {
                racerTwoMultiplier = 1.2;
            }
            else
            {
                racerTwoMultiplier = 1.1;
            }

            double oneChance = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOneMultiplier;
            double twoChance = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racerTwoMultiplier;
            if (oneChance>twoChance)
            {
                return
                    $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerOne.Username} is the winner!";
            }
            else
            {
                return
                    $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerTwo.Username} is the winner!";
            }
        }
    }
}
