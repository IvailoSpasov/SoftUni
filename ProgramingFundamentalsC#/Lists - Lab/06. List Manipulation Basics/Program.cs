using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    AddNumberToList(numbers, int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    RemoveNumberFromList(numbers, int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    RemoveNumberAtIndex(numbers, int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    InsertNumberInIndex(numbers, int.Parse(input[1]), int.Parse(input[2]));
                }

                input = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        private static void InsertNumberInIndex(List<int> numbers, int number, int index)
        {
            numbers.Insert(index,number);
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
