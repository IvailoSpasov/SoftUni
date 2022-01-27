using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            if (numbers.Count <= 2)
            {
                Console.WriteLine("No");
                return;
            }
            double sum = numbers.Sum();
            double avg = sum / numbers.Count;
            numbers.Sort();
            numbers.Reverse();
            List<int> topFive = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < 5 && numbers[i] > avg)
                {
                    topFive.Add(numbers[i]);
                }
            }

            if (topFive.Count==0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ", topFive));
        }
    }
}
