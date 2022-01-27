using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsPassOnGreenLight = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int counter = 0;

            while (input!="end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < numberOfCarsPassOnGreenLight; i++)
                    {
                        if (queue.Count==0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
