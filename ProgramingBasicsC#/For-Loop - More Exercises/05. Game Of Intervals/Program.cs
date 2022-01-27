using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int stroke = int.Parse(Console.ReadLine());

            double f0To9 = 0;
            double f10To19 = 0;
            double f20To29 = 0;
            double f30To39 = 0;
            double f40To50 = 0;
            double invalid = 0;
            double points = 0;

            for (int i = 0; i < stroke; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <=9)
                {
                    f0To9++;
                    points += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    f10To19++;
                    points += number * 0.3;
                }
                else if(number >= 20 && number <= 29)
                {
                    f20To29++;
                    points += number * 0.4;
                }
                else if(number >= 30 && number <= 39)
                {
                    f30To39++;
                    points += 50;
                }
                else if(number >= 40 && number <= 50)
                {
                    f40To50++;
                    points += 100;
                }
                else if(number < 0 || number > 50)
                {
                    invalid++;
                    points /= 2;
                }
            }
            double numberSum = f0To9 + f10To19 + f20To29 + f30To39 + f40To50 + invalid;
            double f0to9Percent = f0To9 / numberSum * 100;
            double f10to19Percent = f10To19 / numberSum * 100;
            double f20to29Percent = f20To29 / numberSum * 100;
            double f30to39Percent = f30To39 / numberSum * 100;
            double f40to50Percent = f40To50 / numberSum * 100;
            double invalidPercent = invalid / numberSum * 100;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {f0to9Percent:f2}%");
            Console.WriteLine($"From 10 to 19: {f10to19Percent:f2}%");
            Console.WriteLine($"From 20 to 29: {f20to29Percent:f2}%");
            Console.WriteLine($"From 30 to 39: {f30to39Percent:f2}%");
            Console.WriteLine($"From 40 to 50: {f40to50Percent:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidPercent:f2}%");
        }
    }
}
