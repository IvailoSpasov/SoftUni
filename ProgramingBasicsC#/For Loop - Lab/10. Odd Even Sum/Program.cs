using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            

            for (int i = 0; i < sequenceCount; i++)
            {
                int Number = int.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    evenSum += Number;
                }
                else
                {
                    oddSum += Number;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
