using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            HashSet<string> parking = new HashSet<string>();
            while (input[0]!="END")
            {
                string command = input[0];
                string licensePlateNumber = input[1];
                if (command=="IN")
                {
                    parking.Add(licensePlateNumber);
                }
                else
                {
                    parking.Remove(licensePlateNumber);
                }
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (parking.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
