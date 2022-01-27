using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Vehicle> vehicles = new List<Vehicle>();
            while (input[0] != "End")
            {
                string type = input[0];
                string model = input[1];
                string color = input[2];
                double horsePower = double.Parse(input[3]);

                Vehicle vehicle = new Vehicle();
                vehicle.Type = type;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePower = horsePower;
                vehicles.Add(vehicle);
                input = Console.ReadLine().Split();
            }

            string cmd = Console.ReadLine();
            while (cmd != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles.Where(vehicle => vehicle.Model == cmd))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
                cmd = Console.ReadLine();
            }

            double CarHP = 0;
            double TruckHP = 0;
            int carCounter = 0;
            int truckCounter = 0;
            foreach (Vehicle vehicle in vehicles.Where(car=>car.Type=="car"))
            {
                carCounter++;
                CarHP += vehicle.HorsePower;
            }
            foreach (Vehicle vehicle in vehicles.Where(truck => truck.Type == "truck"))
            {
                truckCounter++;
                TruckHP += vehicle.HorsePower;
            }

            double avgCarHP = CarHP / carCounter;
            double avgTruckHp = TruckHP / truckCounter;
            Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");
        }
    }
}
