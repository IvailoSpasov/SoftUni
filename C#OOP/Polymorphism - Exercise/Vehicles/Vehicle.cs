using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double tankCapacity, double fuelQuantity, double fuelConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                this.tankCapacity = value;
            }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > this.TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;

                }
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public abstract string Drive(double distance);

        public abstract void Refuel(double amount);

    }
}
