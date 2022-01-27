using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ").ToArray());
            List<string> commands = Console.ReadLine().Split().ToList();

            while (true)
            {
                if (commands[0] == "Play" && songs.Count > 0)
                {
                    songs.Dequeue();
                }
                else if (commands[0] == "Add")
                {
                    commands.RemoveAt(0);
                    string currSong = string.Join(" ", commands);
                    if (songs.Contains(currSong))
                    {
                        Console.WriteLine($"{currSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(currSong);
                    }
                }
                else if (commands[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
                commands = Console.ReadLine().Split().ToList();
            }


        }
    }
}
