using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "End")
            {
                string comand = input[0];
                if (comand == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                else if (comand == "Insert")
                {
                    if (int.Parse(input[2]) > numbers.Count - 1 || int.Parse(input[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));

                    }
                }
                else if (comand == "Remove")
                {
                    if (int.Parse(input[1]) > numbers.Count - 1 || int.Parse(input[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(input[1]));
                    }
                }
                else if (comand == "Shift")
                {
                    if (input[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count-1);
                        }
                    }

                }

                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
