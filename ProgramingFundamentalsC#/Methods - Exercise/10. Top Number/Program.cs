using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {

                if (ChekTheSumOfDigitsIsDivisibleByEight(i) && ChekForOddsInNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ChekForOddsInNumber(int number)
        {
            bool cheker = false;
            while (number > 0)
            {
                int currNum = 0;
                currNum = number % 10;
                if (currNum % 2 != 0)
                {
                    cheker = true;
                    return cheker;
                }

                number /= 10;
            }

            return cheker;
        }

        private static bool ChekTheSumOfDigitsIsDivisibleByEight(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            bool cheker = false;
            if (sum % 8 == 0)
            {
                cheker = true;
            }

            return cheker;
        }
    }
}
