using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightforGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            List<int> plates = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool flag = true;
            for (int i = 1; i <= numberOfWaves; i++)
            {
                Stack<int> orcsStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                if (i % 3 == 0 && flag)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Add(extraPlate);
                }



                while (plates.Count > 0 && orcsStack.Count > 0)
                {


                    if (plates[0] > orcsStack.Peek())
                    {
                        int plate = plates[0] - orcsStack.Pop();
                        plates[0] = plate;
                    }
                    else if (orcsStack.Peek() > plates[0])
                    {
                        int warior = orcsStack.Pop() - plates[0];
                        plates.RemoveAt(0);
                        orcsStack.Push(warior);
                    }
                    else
                    {
                        plates.RemoveAt(0);
                        orcsStack.Pop();
                    }

                    if (plates.Count == 0)
                    {
                        Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                        Console.WriteLine($"Orcs left: {string.Join(", ", orcsStack)}");
                        flag = false;
                        break;
                    }

                }

            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");

            }


        }
    }
}
