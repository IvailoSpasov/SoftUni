using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string tiresInput = Console.ReadLine();
            List<Tire[]> tiresList = new List<Tire[]>();

            while (tiresInput != "No more tires")
            {
                double[] tires = tiresInput.Split().Select(double.Parse).ToArray();
                Tire[] tire = new Tire[4]
                {
                    new Tire((int)tires[0], tires[1]),
                    new Tire((int)tires[2], tires[3]),
                    new Tire((int)tires[4], tires[5]),
                    new Tire((int)tires[6], tires[7])
                };
                tiresList.Add(tire);
                tiresInput = Console.ReadLine();
            }

            string enginesInput = Console.ReadLine();
            List<Engine> enginesList = new List<Engine>();

            while (enginesInput != "Engines done")
            {
                double[] engins = enginesInput.Split().Select(double.Parse).ToArray();
                Engine engine = new Engine((int)engins[0], engins[1]);
                enginesList.Add(engine);
                enginesInput = Console.ReadLine();
            }

            string carsInput = Console.ReadLine();
            List<Car> carsList = new List<Car>();

            while (carsInput != "Show special")
            {
                string[] cars = carsInput.Split();
                string make = cars[0];
                string model = cars[1];
                int year = int.Parse(cars[2]);
                double fuelQuantity = double.Parse(cars[3]);
                double fuelConsumption = double.Parse(cars[4]);
                int engineIndex = int.Parse(cars[5]);
                int tiresIndex = int.Parse(cars[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex],
                    tiresList[tiresIndex]);
                carsList.Add(car);

                carsInput = Console.ReadLine();
            }

            foreach (var car in carsList.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.GetSumOfTiresPressure() > 9).Where(x => x.GetSumOfTiresPressure() < 10))
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");

            }

        }
    }
}
