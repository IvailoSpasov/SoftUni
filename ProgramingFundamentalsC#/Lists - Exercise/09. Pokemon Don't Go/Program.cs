using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                int removedElement;
                if (index < 0)
                {
                    index = 0;
                    removedElement = numbers[index];
                    numbers.RemoveAt(index);
                    sum += removedElement;
                    IncreaseAndDecreaseElements(numbers, removedElement);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index > numbers.Count - 1)
                {
                    index = numbers.Count - 1;
                    removedElement = numbers[index];
                    numbers.RemoveAt(index);
                    sum += removedElement;
                    IncreaseAndDecreaseElements(numbers, removedElement);
                    numbers.Add(numbers[0]);
                }
                else
                {
                    removedElement = numbers[index];
                    numbers.RemoveAt(index);
                    sum += removedElement;
                    IncreaseAndDecreaseElements(numbers, removedElement);
                }


            }

            Console.WriteLine(sum);
        }

        private static void IncreaseAndDecreaseElements(List<int> numbers, int removedElement)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (removedElement >= numbers[i])
                {
                    numbers[i] += removedElement;
                }
                else if (removedElement < numbers[i])
                {
                    numbers[i] -= removedElement;
                }
            }
        }
    }
}
