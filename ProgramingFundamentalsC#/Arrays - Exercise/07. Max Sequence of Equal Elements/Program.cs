using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalCounter = 0;
            int longesElement = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                int element = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > totalCounter)
                {
                    totalCounter = counter;
                    longesElement = element;

                }

            }

            for (int m = 0; m <= totalCounter; m++)
            {
                Console.Write(longesElement + " ");
            }
        }
    }
}
