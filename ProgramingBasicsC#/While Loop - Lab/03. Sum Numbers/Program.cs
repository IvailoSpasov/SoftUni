using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double targedSum = double.Parse(Console.ReadLine());
            double sum = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                    sum += number;

                if (sum >= targedSum)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
