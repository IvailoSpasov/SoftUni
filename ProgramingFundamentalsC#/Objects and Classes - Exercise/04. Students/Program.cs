using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);
                students.Add(student);
            }

            students = students.OrderByDescending(o => o.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
