using System;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (arr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 1; i < arr.Length - 1; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");
        }
    }
}
