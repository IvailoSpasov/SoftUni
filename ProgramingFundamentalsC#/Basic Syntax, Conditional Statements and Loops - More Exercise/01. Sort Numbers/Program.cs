using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.MinValue;
            int secondNumber = int.MinValue;
            int thirdNumber = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                int numberToCheck = int.Parse(Console.ReadLine());
                if (numberToCheck > firstNumber)
                {
                    thirdNumber = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = numberToCheck;
                }
                else if (numberToCheck > secondNumber)
                {
                    thirdNumber = secondNumber;
                    secondNumber = numberToCheck;
                }
                else if (numberToCheck > thirdNumber)
                {
                    thirdNumber = numberToCheck;
                }

            }
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
