using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    Console.WriteLine($"{quantity * 2.5:f2}");
                }
                else if (product == "apple")
                {
                    Console.WriteLine($"{quantity * 1.2:f2}");
                }
                else if (product == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:f2}");
                }
                else if (product == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:f2}");
                }
                else if (product == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.7:f2}");
                }
                else if (product == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.5:f2}");
                }
                else if (product == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    Console.WriteLine($"{quantity * 2.7:f2}");
                }
                else if (product == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:f2}");
                }
                else if (product == "orange")
                {
                    Console.WriteLine($"{quantity * 0.90:f2}");
                }
                else if (product == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.60:f2}");
                }
                else if (product == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3:f2}");
                }
                else if (product == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.6:f2}");
                }
                else if (product == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.2:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
