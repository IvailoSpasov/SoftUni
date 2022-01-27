using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    if (int.Parse(input[1]) > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = ExchangingArrayByIndex(arr, int.Parse(input[1]));
                    }
                }
                else if (input[0] == "max" || input[0] == "min")
                {
                    ReturnsTheIndexOfTheMaxMinEvenOrOddElement(arr, input[0], input[1]);
                }
                else if (input[0] == "first" || input[0] == "last")
                {
                    ReturnsTheFirstOrLastCountOfElements(arr, input[0], int.Parse(input[1]), input[2]);
                }


                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void ReturnsTheFirstOrLastCountOfElements(int[] arr, string position, int numbers, string evenOrOdd)
        {
            if (numbers > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (numbers == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            int oddOrEvenResult = 1;
            if (evenOrOdd == "even")
            {
                oddOrEvenResult = 0;
            }

            int counter = 0;
            List<int> nums = new List<int>();
            if (position == "first")
            {
                foreach (var num in arr)
                {
                    if (num % 2 == oddOrEvenResult)
                    {
                        counter++;
                        nums.Add(num);
                    }

                    if (counter == numbers)
                    {
                        break;
                    }
                }
            }

            if (position == "last")
            {


                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == oddOrEvenResult)
                    {
                        counter++;
                        nums.Add(arr[i]);
                    }

                    if (counter == numbers)
                    {
                        break;
                    }
                }

                nums.Reverse();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void ReturnsTheIndexOfTheMaxMinEvenOrOddElement(int[] arr, string maxOrMin, string oddOrEven)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int index = -1;
            int evenOrOdd = 1;
            if (oddOrEven == "even")
            {
                evenOrOdd = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == evenOrOdd)
                {

                    if (maxOrMin == "max" && arr[i] >= max)
                    {
                        max = arr[i];
                        index = i;
                    }
                    else if (maxOrMin == "min" && arr[i] <= min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
            }

            if (index > -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }


        private static int[] ExchangingArrayByIndex(int[] arr, int index)
        {
            if (index >= 0)
            {


                for (int k = 0; k <= index; k++)
                {
                    int temp = arr[0];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[arr.Length - 1] = temp;
                }
            }

            return arr;
        }
    }
}
