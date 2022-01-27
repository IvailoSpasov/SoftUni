using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            double power = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double exhaustionFactory = double.Parse(Console.ReadLine());
            int counter = 0;
            int exactPower = (int)power;
            while (exactPower >= distance)
            {
                exactPower -= (int)distance;
                counter++;
                if (power/2 == exactPower)
                {
                    if (exactPower/ exhaustionFactory >0)
                    {
                    exactPower /= (int)exhaustionFactory;
                    }
                }

            }
            Console.WriteLine(exactPower);
            Console.WriteLine(counter);
        }
    }
}
