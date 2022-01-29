using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] splitedCommands = command.Split();
                string method = splitedCommands[0];
                string action = splitedCommands[1];
                string value = splitedCommands[2];

                if (method == "Double")
                {
                    List<string> doubleNames = names.FindAll(GetPredicate(action, value));
                    if (doubleNames.Count > 0)
                    {
                        int index = names.FindIndex(GetPredicate(action, value));
                        names.InsertRange(index, doubleNames);
                    }
                }
                else
                {
                    names.RemoveAll(GetPredicate(action, value));
                }

                command = Console.ReadLine();
            }

            if (names.Count > 0)
            {

                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string action, string value)
        {
            if (action == "StartsWith")
            {
                return x => x.StartsWith(value);
            }
            else if (action == "EndsWith")
            {
                return x => x.EndsWith(value);
            }

            int intValue = int.Parse(value);
            return x => x.Length == intValue;
        }
    }
}
