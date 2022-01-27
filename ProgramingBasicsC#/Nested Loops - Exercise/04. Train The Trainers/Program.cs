using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalSum = 0;
            int counter = 0;
            while (presentation != "Finish")
            {
                double sum = 0;
                counter++;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }

                double avgGrade = sum / n;
                totalSum += avgGrade;

                Console.WriteLine($"{presentation} - {avgGrade:f2}.");
                presentation = Console.ReadLine();
            }
            double totalAvg = totalSum / counter;
            Console.WriteLine($"Student's final assessment is {totalAvg:f2}.");
        }
    }
}
