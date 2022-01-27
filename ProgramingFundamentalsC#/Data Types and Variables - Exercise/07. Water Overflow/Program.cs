using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int tankCapacity = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (tankCapacity + input <= 255)
                {
                    tankCapacity += input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
