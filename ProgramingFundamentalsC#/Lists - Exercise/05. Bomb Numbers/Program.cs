using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = comands[0];
            int bombpower = comands[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomb==numbers[i])
                {
                    int startNum = i-bombpower;
                    if (startNum<0)
                    {
                        startNum = 0;
                    }

                    int finalNum = i + bombpower;
                    if (finalNum>=numbers.Count)
                    {
                        finalNum = numbers.Count - 1;
                    }

                    for (int j = startNum; j <=finalNum; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
