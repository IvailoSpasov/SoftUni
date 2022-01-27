using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int curentNum = int.Parse(Console.ReadLine());
                sum += curentNum;

                if (curentNum > maxNumber)
                {
                    maxNumber = curentNum;
                }
            }
            sum -= maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNumber)}");
            }


        }
    }
}
