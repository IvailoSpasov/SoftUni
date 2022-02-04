using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine();
                if (input.Length == 4)
                {
                    engine.Model = input[0];
                    engine.Power = int.Parse(input[1]);
                    engine.Displacement = int.Parse(input[2]);
                    engine.Efficiency = input[3];
                }
                else if (input.Length == 3)
                {
                    bool isDigit = int.TryParse(input[2], out var displacement);
                    if (isDigit)
                    {
                        engine.Model = input[0];
                        engine.Power = int.Parse(input[1]);
                        engine.Displacement = int.Parse(input[2]);
                    }
                    else
                    {
                        engine.Model = input[0];
                        engine.Power = int.Parse(input[1]);
                        engine.Efficiency = input[2];

                    }
                }
                else
                {
                    engine.Model = input[0];
                    engine.Power = int.Parse(input[1]);
                }
                engines.Add(engine.Model, engine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                if (input.Length == 4)
                {
                    car.Model = input[0];
                    car.Engine = engines[input[1]];
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                else if (input.Length == 3)
                {
                    bool isDigit = int.TryParse(input[2], out var displacement);
                    if (isDigit)
                    {
                        car.Model = input[0];
                        car.Engine = engines[input[1]];
                        car.Weight = int.Parse(input[2]);
                    }
                    else
                    {
                        car.Model = input[0];
                        car.Engine = engines[input[1]];
                        car.Color = input[2];

                    }
                }
                else
                {
                    car.Model = input[0];
                    car.Engine = engines[input[1]];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                if (car.Engine.Displacement == null)
                {
                    Console.WriteLine("  Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency==null)
                {
                    Console.WriteLine("  Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight==null)
                {
                    Console.WriteLine(" Weight: n/a");
                }
                else
                {
                    Console.WriteLine($" Weight: {car.Weight}");
                }

                if (car.Color==null)
                {
                    Console.WriteLine("Color: n/a");
                }
                else
                {
                    Console.WriteLine($"Color: {car.Color}");
                }
            }
            

        }

    }
}



