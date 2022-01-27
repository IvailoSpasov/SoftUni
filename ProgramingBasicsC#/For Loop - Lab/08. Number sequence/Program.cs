using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;
            int largestNumber = int.MinValue;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
            Console.WriteLine($"Max number: {largestNumber}");
            Console.WriteLine($"Min number: {smallestNumber}");
        }
    }
}
