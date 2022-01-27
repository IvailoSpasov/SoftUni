using System;

namespace BirthDayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall = double.Parse(Console.ReadLine());
            double cake = hall * 0.2;
            double drinks = cake - (cake * 0.45);
            double animaor = hall / 3;

            Console.WriteLine(hall + cake + drinks + animaor);
        }
    }
}
