using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> GetSmallestNumber = numbers
                =>
            {
                int minValue = Int32.MaxValue;
                foreach (var num in numbers)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }

                return minValue;
            };
            int result = GetSmallestNumber(numbers);
            Console.WriteLine(result);
        }
    }
}
