using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int endPower = int.Parse(Console.ReadLine());

            for (int n = 0; n <= endPower; n += 2)
            {
                Console.WriteLine(Math.Pow(2, n));
            }
        }
    }
}
