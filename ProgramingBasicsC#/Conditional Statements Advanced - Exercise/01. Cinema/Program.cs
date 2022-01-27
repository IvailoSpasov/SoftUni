using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int collons = int.Parse(Console.ReadLine());
            int rolls = int.Parse(Console.ReadLine());

            if (type == "Premiere")
            {
                Console.WriteLine($"{(collons * rolls) * 12:f2} leva");
            }
            else if (type == "Normal")
            {
                Console.WriteLine($"{(collons * rolls) * 7.5:f2} leva");
            }
            else if (type == "Discount")
            {
                Console.WriteLine($"{(collons * rolls) * 5:f2} leva");
            }
        }
    }
}
