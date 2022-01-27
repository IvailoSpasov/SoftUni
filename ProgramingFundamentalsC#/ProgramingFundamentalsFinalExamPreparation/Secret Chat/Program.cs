using System;
using System.Linq;
using System.Text;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(":|:");
            while (commands[0] != "Reveal")
            {
                string command = commands[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(commands[1]);
                    message = message.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string substring = commands[1];
                    if (message.IndexOf(substring) >= 0)
                    {
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            message = message + substring[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                        commands = Console.ReadLine().Split(":|:");
                        continue;
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);
                commands = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
