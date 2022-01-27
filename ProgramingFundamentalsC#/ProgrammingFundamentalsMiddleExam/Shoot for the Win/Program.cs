using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int counter = 0;


            while (input != "End")
            {
                int index = int.Parse(input);
                if (index < targetsArray.Length && targetsArray[index] != -1)
                {
                    counter++;
                    int targetTemp = targetsArray[index];
                    targetsArray[index] = -1;
                    for (int i = 0; i < targetsArray.Length; i++)
                    {
                        if (targetsArray[i] > targetTemp)
                        {
                            targetsArray[i] -= targetTemp;
                        }
                        else if (targetsArray[i] <= targetTemp && targetsArray[i] != -1)
                        {
                            targetsArray[i] += targetTemp;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.Write($"Shot targets: {counter} -> ");
            Console.Write(string.Join(" ",targetsArray));

        }
    }
}
