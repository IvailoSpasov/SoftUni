using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstRange = 0;
            double secondRange = 0;
            double thirdRange = 0;
            double fourthRange = 0;
            double fivethRange = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    firstRange++;
                }
                else if (num <= 399 && num >= 200)
                {
                    secondRange++;
                }
                else if (num >= 400 && num <= 599)
                {
                    thirdRange++;
                }
                else if (num >= 600 && num <= 799)
                {
                    fourthRange++;
                }
                else
                {
                    fivethRange++;
                }
            }
            double p1 = firstRange / n * 100;
            double p2 = secondRange / n * 100;
            double p3 = thirdRange / n * 100;
            double p4 = fourthRange / n * 100;
            double p5 = fivethRange / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
