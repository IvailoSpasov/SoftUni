using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                string comand = input[0];
                if (comand == "Delete")
                {
                    numbers.RemoveAll(el => el == int.Parse(input[1]));
                }
                else
                {
                    numbers.Insert(int.Parse(input[2]),int.Parse(input[1]));
                }

                input = Console.ReadLine().Split().ToArray();

            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
