using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double tankCapacity, double fuelQuantity, double fuelConsumption)
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
        }

        public override string Drive(double distance)
        {
            if (distance * (this.FuelConsumption + 1.4) <= FuelQuantity)
            {
                FuelQuantity -= (this.FuelConsumption + 1.4) * distance;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

        public string DriveEmpty(double distance)
        {
            if (distance * this.FuelConsumption <= FuelQuantity)
            {
                FuelQuantity -= this.FuelConsumption * distance;
                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

        public override void Refuel(double amount)
        {
            if (amount < 1)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + amount > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += amount;
            }
        }
    }
}
