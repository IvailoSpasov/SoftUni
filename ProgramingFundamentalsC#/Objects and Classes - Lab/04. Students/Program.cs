using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Student> students = new List<Student>();
            while (input[0] != "end")
            {
                Student student = new Student();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Age = int.Parse(input[2]);
                student.HomeTown = input[3];
                students.Add(student);
                input = Console.ReadLine().Split();
            }

            string town = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
