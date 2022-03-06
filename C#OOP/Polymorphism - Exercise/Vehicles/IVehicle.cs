using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public double TankCapacity { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public abstract string Drive(double distance);

        public abstract void Refuel(double amount);
    }
}
