using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = input[1];
                    car.Model = input[2];
                    car.HorsePower = double.Parse(input[3]);
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = input[1];
                    truck.Model = input[2];
                    truck.Weight = double.Parse(input[3]);
                    trucks.Add(truck);
                }
                input = Console.ReadLine().Split("/");
            }

            WehicleCatalog catalog = new WehicleCatalog();
            catalog.Cars = cars;
            catalog.Trucks = trucks;
            Console.WriteLine("Cars:");
            foreach (Car car in cars.OrderBy(o => o.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (Truck truck in trucks.OrderBy(o => o.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }

    class WehicleCatalog
    {
        public WehicleCatalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}