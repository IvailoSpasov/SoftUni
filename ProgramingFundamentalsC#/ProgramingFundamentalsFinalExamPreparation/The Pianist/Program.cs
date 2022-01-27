using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> colection = new Dictionary<string, string[]>(2);
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                string[] composerAndKey = new string[] { composer, key };
                colection.Add(piece, composerAndKey);
            }

            string[] commands = Console.ReadLine().Split("|");
            while (commands[0] != "Stop")
            {
                string command = commands[0];
                if (command == "Add")
                {
                    string piece = commands[1];
                    string composer = commands[2];
                    string key = commands[3];
                    string[] composerAndKey = new string[] { composer, key };
                    if (colection.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        colection.Add(piece,composerAndKey);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    string piece = commands[1];
                    if (colection.ContainsKey(piece))
                    {
                        colection.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command== "ChangeKey")
                {
                    string piece = commands[1];
                    string newKey = commands[2];
                    if (colection.ContainsKey(piece))
                    {
                        colection[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                commands = Console.ReadLine().Split("|");
            }

            foreach (var piece in colection.OrderBy(x=>x.Key).ThenBy(x=>x.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
