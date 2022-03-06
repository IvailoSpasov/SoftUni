using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double tankCapacity, double fuelQuantity, double fuelConsumption)
            : base(tankCapacity, fuelQuantity, fuelConsumption)
        {
        }


        public override string Drive(double distance)
        {
            if (distance * (this.FuelConsumption + 0.9) <= FuelQuantity)
            {
                FuelQuantity -= (this.FuelConsumption + 0.9) * distance;
                return $"Car travelled {distance} km";
            }
            else
            {
                return "Car needs refueling";
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
