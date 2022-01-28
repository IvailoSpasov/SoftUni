using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startNumber = range[0];
            int finalNumber = range[1];
            string filter = Console.ReadLine();
            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            List<int> result = new List<int>();

            for (int i = startNumber; i <= finalNumber; i++)
            {
                result.Add(i);
            }

            if (filter=="even")
            {
                result = result.Where(x => isEven(x)).ToList();
                Console.WriteLine(string.Join(" ",result));
            }
            else
            {
                result = result.Where(x => isOdd(x)).ToList();
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
