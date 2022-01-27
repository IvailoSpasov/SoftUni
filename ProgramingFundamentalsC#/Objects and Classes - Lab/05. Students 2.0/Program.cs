using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

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
                if (IsStudentExisting(students, input[0], input[1]))
                {
                    Student student = GetExistingStudent(students, input[0], input[1]);
                    student.Age = int.Parse(input[2]);
                    student.HomeTown = input[3];
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Age = int.Parse(input[2]);
                    student.HomeTown = input[3];
                    students.Add(student);
                }
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

        private static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
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