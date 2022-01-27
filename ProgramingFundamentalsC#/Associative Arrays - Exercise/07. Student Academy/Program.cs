using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }
                studentsGrades[name].Add(grade);
            }

            Dictionary<string, double> avgStudentGrades = new Dictionary<string, double>();

            foreach (var student in studentsGrades)
            {
                double averageGrade = student.Value.Sum() / student.Value.Count;
                if (averageGrade >= 4.50)
                {
                    avgStudentGrades.Add(student.Key, averageGrade);
                }
            }

            foreach (var student in avgStudentGrades.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
