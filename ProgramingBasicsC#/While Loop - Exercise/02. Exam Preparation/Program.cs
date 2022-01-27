using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrade = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();

            int poorGradeCounter = 0;

            double gradesum = 0;
            double gradeCounter = 0;
            
            string lastProblem = "";

            while (problem != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                gradesum += grade;
                gradeCounter++;
                if (grade <= 4)
                {
                    poorGradeCounter++;
                    if (poorGradeCounter == poorGrade)
                    {
                        Console.WriteLine($"You need a break, {poorGradeCounter} poor grades.");
                        break;
                    }
                }
                    lastProblem = problem;

                problem = Console.ReadLine();

            }
            double averageGrade = gradesum / gradeCounter;
            if (problem == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {gradeCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }

        }
    }
}
