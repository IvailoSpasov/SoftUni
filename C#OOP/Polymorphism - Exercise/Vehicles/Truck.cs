using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double tankCapacity, double fuelQuantity, double fuelConsumption)
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
        }

        public override string Drive(double distance)
        {
            if (distance * (this.FuelConsumption + 1.6) <= FuelQuantity)
            {
                FuelQuantity -= (this.FuelConsumption + 1.6) * distance;
                return $"Truck travelled {distance} km";
            }
            else
            {
                return "Truck needs refueling";
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
                this.FuelQuantity += amount * 0.95;
            }

        }
    }
}
