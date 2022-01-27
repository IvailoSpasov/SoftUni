using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> carsList = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split("|");
                string car = cars[0];
                int mileage = int.Parse(cars[1]);
                int fuel = int.Parse(cars[2]);
                carsList.Add(car, new int[2] { mileage, fuel });
            }

            string[] commands = Console.ReadLine().Split(" : ");
            while (commands[0] != "Stop")
            {
                string command = commands[0];
                if (command == "Drive")
                {
                    string car = commands[1];
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    if (fuel > carsList[car][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsList[car][0] += distance;
                        carsList[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (carsList[car][0] >= 100000)
                    {
                        carsList.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    string car = commands[1];
                    int fuel = int.Parse(commands[2]);
                    int currFuel = carsList[car][1];
                    carsList[car][1] += fuel;
                    if (carsList[car][1] > 75)
                    {
                        carsList[car][1] = 75;
                        fuel = 75 - currFuel;
                    }

                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (command == "Revert")
                {
                    string car = commands[1];
                    int kilometers = int.Parse(commands[2]);
                    if (carsList[car][0] - kilometers < 10000)
                    {
                        carsList[car][0] = 10000;
                    }
                    else
                    {
                        carsList[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                commands = Console.ReadLine().Split(" : ");
            }

            foreach (var car in carsList.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
