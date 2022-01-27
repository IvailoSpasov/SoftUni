using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (numOfPeople % capacity == 0)
            {
                courses = numOfPeople / capacity;
            }
            else
            {
                 courses = (numOfPeople / capacity)+1;
            }
            Console.WriteLine(courses);
        }
    }
}
