using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();
            string[] commands = Console.ReadLine().Split(" - ").ToArray();

            while (commands[0] != "End")
            {
                if (commands[0] == "Add" && !phones.Contains(commands[1]))
                {
                    phones.Add(commands[1]);
                }
                else if (commands[0] == "Remove" && phones.Contains(commands[1]))
                {
                    phones.Remove(commands[1]);
                }
                else if (commands[0] == "Bonus phone")
                {
                    string[] oldAndNewPhones = commands[1].Split(":").ToArray();
                    if (phones.Contains(oldAndNewPhones[0]))
                    {
                        int index = phones.IndexOf(oldAndNewPhones[0]);
                        phones.Insert(index + 1, oldAndNewPhones[1]);
                    }
                }
                else if (commands[0] == "Last" && phones.Contains(commands[1]))
                {
                    phones.Remove(commands[1]);
                    phones.Add(commands[1]);
                }
                commands = Console.ReadLine().Split(" - ").ToArray();
            }

            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
