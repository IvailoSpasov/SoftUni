using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            GetMultiplyOfEvensAndOdds(GetSumOfEvenDigits(number), GetSumOfOddDigits(number));
        }

        private static void GetMultiplyOfEvensAndOdds(int getSumOfEvenDigits, int getSumOfOddDigits)
        {
            Console.WriteLine(getSumOfEvenDigits * getSumOfOddDigits);
        }


        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currNum = 0;
                currNum = Math.Abs(number % 10);
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currNum = 0;
                currNum = Math.Abs(number % 10);
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
