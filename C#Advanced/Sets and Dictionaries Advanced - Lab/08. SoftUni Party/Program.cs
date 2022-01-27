using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipsSet = new HashSet<string>();
            HashSet<string> normalGuestsSet = new HashSet<string>();

            string input = Console.ReadLine().Trim();
            while (input != "END")
            {
                if (input.Length == 8)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipsSet.Add(input);
                    }
                    else
                    {
                        normalGuestsSet.Add(input);
                    }
                }

                if (input == "PARTY")
                {
                    string guestsWhoCame = Console.ReadLine().Trim();
                    while (guestsWhoCame != "END")
                    {
                        if (char.IsDigit(guestsWhoCame[0]))
                        {
                            if (vipsSet.Contains(guestsWhoCame))
                            {
                                vipsSet.Remove(guestsWhoCame);
                            }
                        }
                        else
                        {
                            if (normalGuestsSet.Contains(guestsWhoCame))
                            {
                                normalGuestsSet.Remove(guestsWhoCame);
                            }
                        }

                        guestsWhoCame = Console.ReadLine().Trim();
                    }

                    int didntCome = vipsSet.Count + normalGuestsSet.Count;
                    Console.WriteLine(didntCome);
                    foreach (var vips in vipsSet)
                    {
                        Console.WriteLine(vips);
                    }

                    foreach (var guests in normalGuestsSet)
                    {
                        Console.WriteLine(guests);
                    }
                    return;
                }

                input = Console.ReadLine().Trim();
            }
            int didntComee = vipsSet.Count + normalGuestsSet.Count;
            Console.WriteLine(didntComee);
            foreach (var vips in vipsSet)
            {
                Console.WriteLine(vips);
            }

            foreach (var guests in normalGuestsSet)
            {
                Console.WriteLine(guests);
            }
        }
    }
}
