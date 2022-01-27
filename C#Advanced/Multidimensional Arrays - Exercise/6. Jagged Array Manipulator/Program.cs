using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = new double[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    jaggedArray[row][col] = input[col];
                }
            }

            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    jaggedArray[i] = Multiply(jaggedArray[i]);
                    jaggedArray[i + 1] = Multiply(jaggedArray[i + 1]);
                }
                else
                {
                    jaggedArray[i] = Divide(jaggedArray[i]);
                    jaggedArray[i+1] = Divide(jaggedArray[i + 1]);
                }
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0] != "End")
            {
                string cmd = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (cmd == "Add")
                {
                    if (jaggedArray.Length > row && row >= 0 && jaggedArray[row].Length > col && col >= 0)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (cmd == "Subtract")
                {
                    if (jaggedArray.Length > row && row >= 0 && jaggedArray[row].Length > col && col >= 0)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }

        }

        private static double[] Divide(double[] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = jagged[i] / 2;
            }

            return jagged;
        }

        private static double[] Multiply(double[] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = jaggedArray[i] * 2;
            }

            return jaggedArray;
        }
    }

}
