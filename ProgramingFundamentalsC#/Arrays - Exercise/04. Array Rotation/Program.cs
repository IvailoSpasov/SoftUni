using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int j = 0; j < rotations; j++)
            {
                int temp = numbers[0];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];

                }

                numbers[numbers.Length - 1] = temp;

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
