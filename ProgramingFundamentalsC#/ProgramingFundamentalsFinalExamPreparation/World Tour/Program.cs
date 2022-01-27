using System;
using System.Text;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stopsList = new StringBuilder(input);
            string[] commands = Console.ReadLine().Split(":");
            while (commands[0] != "Travel")
            {
                string command = commands[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string stop = commands[2];
                    if (index >= 0 && index < stopsList.Length)
                    {
                        stopsList.Insert(index, stop);
                        Console.WriteLine(stopsList);
                    }
                    else
                    {
                        Console.WriteLine(stopsList);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex >= 0 && endIndex >= 0 && startIndex < stopsList.Length && endIndex < stopsList.Length && startIndex <= endIndex)
                    {
                        stopsList.Remove(startIndex, ((endIndex - startIndex)+1));
                        Console.WriteLine(stopsList);
                    }
                    else
                    {
                        Console.WriteLine(stopsList);
                    }

                }
                else if (command== "Switch")
                {
                    string oldStop = commands[1];
                    string newStop = commands[2];
                    stopsList.Replace(oldStop, newStop);
                    Console.WriteLine(stopsList);
                }
                commands = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stopsList}");
        }
    }
}
