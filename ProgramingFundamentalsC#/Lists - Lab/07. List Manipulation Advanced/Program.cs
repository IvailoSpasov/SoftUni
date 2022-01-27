using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();
            bool changesAreMade = false;

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    AddNumberToList(numbers, int.Parse(input[1]));
                    changesAreMade = true;
                }
                else if (input[0] == "Remove")
                {
                    RemoveNumberFromList(numbers, int.Parse(input[1]));
                    changesAreMade = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    RemoveNumberAtIndex(numbers, int.Parse(input[1]));
                    changesAreMade = true;
                }
                else if (input[0] == "Insert")
                {
                    InsertNumberInIndex(numbers, int.Parse(input[1]), int.Parse(input[2]));
                    changesAreMade = true;
                }
                else if (input[0] == "Contains")
                {
                    SerchIfNumberContains(numbers, int.Parse(input[1]));
                }
                else if (input[0] == "PrintEven" || input[0] == "PrintOdd")
                {
                    PrintEvenOrOddNumbers(numbers, input[0]);
                }
                else if (input[0] == "GetSum")
                {
                    PrintigSumOfAllNumbers(numbers);
                }
                else if (input[0] == "Filter")
                {
                    FilteringTheListByGivenCondition(numbers, input[1], int.Parse(input[2]));
                }


                input = Console.ReadLine().Split();

            }

            if (changesAreMade)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void FilteringTheListByGivenCondition(List<int> numbers, string condition, int number)
        {
            List<int> currList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (condition == "<" && numbers[i] < number)
                {
                    currList.Add(numbers[i]);
                }
                else if (condition == ">" && numbers[i] > number)
                {
                    currList.Add(numbers[i]);
                }
                else if (condition == ">=" && numbers[i] >= number)
                {
                    currList.Add(numbers[i]);
                }
                else if (condition == "<=" && numbers[i] <= number)
                {
                    currList.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ",currList));
        }

        private static void PrintigSumOfAllNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        private static void PrintEvenOrOddNumbers(List<int> numbers, string evenOrOdd)
        {
            List<int> currList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0 && evenOrOdd == "PrintEven")
                {
                    currList.Add(numbers[i]);
                }
                else if (numbers[i] % 2 == 1 && evenOrOdd == "PrintOdd")
                {
                    currList.Add(numbers[i]);
                }

            }

            Console.WriteLine(string.Join(" ", currList));
        }

        private static void SerchIfNumberContains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void InsertNumberInIndex(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }

        private static void RemoveNumberAtIndex(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        private static void RemoveNumberFromList(List<int> numbers, int number)
        {
            numbers.Remove(number);
        }

        static void AddNumberToList(List<int> numbers, int number)
        {
            numbers.Add(number);
        }
    }
}