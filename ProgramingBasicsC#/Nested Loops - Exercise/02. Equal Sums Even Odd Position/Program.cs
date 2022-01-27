using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            

            for (int i = num1; i <= num2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string current = i.ToString();

                for (int index = 0; index < current.Length; index++)
                {

                    int currentDigit = int.Parse(current[index].ToString());

                    if (index % 2 == 0)
                    {
                        oddSum += currentDigit;
                    }
                    else
                    {
                        evenSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(current + " ");
                }

            }
        }
    }
}
