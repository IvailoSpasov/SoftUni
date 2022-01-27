using System;
using System.Text;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(">>>");
            while (commands[0]!= "Generate")
            {
                string cmd = commands[0];
                if (cmd== "Contains")
                {
                    string substring = commands[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmd== "Flip")
                {
                    string upperOrLower = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    int lendth = (endIndex - startIndex);
                    string substring = key.Substring(startIndex, lendth);
                    string newSub = String.Empty;
                        if (upperOrLower=="Upper")
                        {
                            newSub = substring.ToUpper();
                        }
                        else
                        {
                            newSub = substring.ToLower();
                        }

                        key = key.Replace(substring, newSub);
                        Console.WriteLine(key);

                }
                else if (cmd == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int lendth = (endIndex - startIndex);
                    key = key.Remove(startIndex, lendth);
                    Console.WriteLine(key);
                }
                commands = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
