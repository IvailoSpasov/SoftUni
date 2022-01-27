using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "register")
                {
                    string user = input[1];
                    string licensePlate = input[2];
                    if (parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                    }
                    else
                    {
                        parking.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    string user = input[1];
                    if (!parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        parking.Remove(user);
                    }
                }
            }

            foreach (var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
