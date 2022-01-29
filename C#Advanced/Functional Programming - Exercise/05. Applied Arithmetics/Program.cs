using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string action = Console.ReadLine();
            while (action != "end")
            {
                Func<int[], int[]> func = ModifyArray(action);
                if (action == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else
                {
                    numbers = func(numbers);

                }
                action = Console.ReadLine();
            }
        }

        private static Func<int[], int[]> ModifyArray(string action)
        {
            switch (action)
            {
                case "add":
                    return array => array.Select(x => x + 1).ToArray();
                case "multiply":
                    return array => array.Select(x => x * 2).ToArray();
                case "subtract":
                    return array => array.Select(x => x - 1).ToArray();
                default:
                    return null;

            }
        }
    }
}
