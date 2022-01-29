using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(1, n).ToArray();
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> isDivisible = (x, y) => x % y == 0;
            foreach (var number in numbers)
            {
                bool flag = true;
                foreach (var divider in dividers)
                {
                    if (!isDivisible(number, divider))
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
