using System;

namespace _02._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            bool isFirstNumberBigger = firstNumber > secondNumber;

            if (isFirstNumberBigger)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }

        }
    }
}
