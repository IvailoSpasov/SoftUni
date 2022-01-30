using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private Engine engine;
        private Tire[] tires;
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption):this(make,model,year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption,Engine engine,Tire[] tires):this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.Tires = tires;
            this.Engine = engine;
        }

        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            
            if (FuelQuantity-(distance/100)*FuelConsumption>0)
            {
                FuelQuantity -=(distance/100)*FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make} Model: {this.Model} Year: {this.Year} Fuel: {this.FuelQuantity:f2}";
        }

        public double GetSumOfTiresPressure()
        {
            return Tires.Sum(x => x.Pressure);
        }

    }
}
