using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            while (command != "Print")
            {
                string[] splitedCommands = command.Split(";");
                string method = splitedCommands[0];
                string action = splitedCommands[1];
                string value = splitedCommands[2];

                if (method == "Add filter")
                {
                    filters.Add(action+value,GetPredicate(action,value));
                }
                else
                {
                    filters.Remove(action + value);
                }

                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                names.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ",names));
        }

        private static Predicate<string> GetPredicate(string action, string value)
        {
            if (action == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            else if (action == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            else if (action == "Contains")
            {
                return x => x.Contains(value);
            }

            int intValue = int.Parse(value);
            return x => x.Length == intValue;
        }
    }
}
