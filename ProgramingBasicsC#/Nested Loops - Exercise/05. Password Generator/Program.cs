using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (char c = 'a'; c < 97 + l; c++)
                    {
                        for (char d = 'a'; d < 97 + l; d++)
                        {
                            for (int e = 1; e <= n; e++)
                            {
                                if (e > a && e > b)
                                {
                                    Console.Write($"{a}{b}{c}{d}{e} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
