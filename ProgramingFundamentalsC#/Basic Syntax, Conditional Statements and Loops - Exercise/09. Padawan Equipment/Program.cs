using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {


            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double sabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double freeBelts = Math.Floor(students / 6);
            double sabersPrice = Math.Ceiling(students * 1.1) * sabers;
            double robesPrice = robes * students;
            double beltsPrice = (students - freeBelts) * belts;

            double totalPrice = sabersPrice + robesPrice + beltsPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalPrice - money):F2}lv more.");
            }


        }
    }
}
