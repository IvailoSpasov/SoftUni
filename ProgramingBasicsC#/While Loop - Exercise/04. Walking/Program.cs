using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stepsSum = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                stepsSum += steps;
                if (stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                stepsSum += stepsToHome;
                if (stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(10000 - stepsSum)} more steps to reach goal.");
                }
            }


        }
    }
}
