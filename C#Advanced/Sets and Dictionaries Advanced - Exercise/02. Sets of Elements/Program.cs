using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLength = array[0];
            int secondSetLength = array[1];
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < firstSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }
            for (int j = 0; j < secondSetLength; j++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }

            foreach (var number in set1)
            {
                if (set2.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
