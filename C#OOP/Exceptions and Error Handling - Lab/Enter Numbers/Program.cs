using System;

namespace Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 1;
            int finalNumber = 100;
            int[] inputNumbers = new int[10];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                try
                {
                    inputNumbers[i] = ReadNumber(startingNumber, finalNumber);


                    if (inputNumbers[i] <= startingNumber || inputNumbers[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                    i--;
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be bigger than {0} and smaller than {1}!", startingNumber, finalNumber);
                    i--;
                    continue;
                }


                startingNumber = inputNumbers[i];
            }

            Console.Write("Your numbers are: ");
            foreach (var n in inputNumbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();

        }
        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int num;

            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }


            return num;
        }
    }
    
}
