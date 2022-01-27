using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age <= 18 && age >= 0)
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else if (day == "Holiday")
                {
                    price = 5;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age <= 64 && age > 18)
            {
                if (day == "Weekday")
                {
                    price = 18;
                }
                else if (day == "Weekend")
                {
                    price = 20;
                }
                else if (day == "Holiday")
                {
                    price = 12;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age <= 122 && age > 64)
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else if (day == "Holiday")
                {
                    price = 10;
                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
