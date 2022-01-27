using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double grade2 = 0;
            double grade3 = 0;
            double grade4 = 0;
            double grade5 = 0;
            double gradeSum = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2 && grade <= 2.99)
                {
                    grade2 ++;
                    gradeSum += grade;
                }
                else if (grade >=3 && grade <= 3.99)
                {
                    grade3 ++;
                    gradeSum += grade;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    grade4 ++;
                    gradeSum += grade;
                }
                else if (grade >= 5)
                {
                    grade5 ++;
                    gradeSum += grade;
                }
            }
            double totalGrades = grade2 + grade3 + grade4 + grade5;
            double grade2Percent = grade2 / totalGrades * 100;
            double grade3Percent = grade3 / totalGrades * 100;
            double grade4Percent = grade4 / totalGrades * 100;
            double grade5Percent = grade5 / totalGrades * 100;
            double averageGrade = gradeSum / totalGrades;

            Console.WriteLine($"Top students: {grade5Percent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {grade4Percent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {grade3Percent:f2}%");
            Console.WriteLine($"Fail: {grade2Percent:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
