using System;
using System.Collections.Generic;

namespace Vehicles
{
   public class StartUp

    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            IVehicle car = new Car(double.Parse(carInfo[3]), double.Parse(carInfo[1]),double.Parse(carInfo[2]));
            IVehicle truck = new Truck(double.Parse(truckInfo[3]), double.Parse(truckInfo[1]),double.Parse(truckInfo[2]));
            IVehicle bus = new Bus(double.Parse(busInfo[3]), double.Parse(busInfo[1]),double.Parse(busInfo[2]));
            Dictionary<string, IVehicle> repository = new Dictionary<string, IVehicle>();
            repository.Add("car", car);
            repository.Add("truck", truck);
            repository.Add("bus",bus);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                string vehicle = command[1].ToLower();
                double value = double.Parse(command[2]);

                if (action == "Drive")
                {
                    Console.WriteLine(repository[vehicle].Drive(value));
                    
                }

                else if (action == "Refuel")
                {
                    repository[vehicle].Refuel(value);
                }
                else if (action== "DriveEmpty")
                {
                    Console.WriteLine(((Bus)repository[vehicle]).DriveEmpty(value));
                }
            }

            Console.WriteLine($"Car: {repository["car"].FuelQuantity:f2}");
            Console.WriteLine($"Truck: {repository["truck"].FuelQuantity:f2}");
            Console.WriteLine($"Bus: {repository["bus"].FuelQuantity:f2}");

        }


    }
}
