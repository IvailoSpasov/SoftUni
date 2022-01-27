using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "END")
            {
                if (input == "green")
                {
                    int currGreenLight = greenLight;
                    int currFreeWindow = freeWindow;
                    while (carsQueue.Count != 0)
                    {
                        int currCar = carsQueue.Peek().Length;
                        if (currGreenLight - currCar > 0)
                        {
                            carsQueue.Dequeue();
                            counter++;
                            currGreenLight -= currCar;
                            continue;
                        }
                        else if (currGreenLight + currFreeWindow - currCar >= 0)
                        {
                            carsQueue.Dequeue();
                            counter++;
                            break;
                        }
                        else
                        {
                            int totalTime = currGreenLight + freeWindow;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{carsQueue.Peek()} was hit at {carsQueue.Peek()[totalTime]}.");
                            return;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");

        }
    }
}
