using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] colsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[colsArray.Length];
                for (int col = 0; col < colsArray.Length; col++)
                {
                    jaggedArray[row][col] = colsArray[col];
                }
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                string action = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || col < 0 || row >= jaggedArray.Length || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (action == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
                command = Console.ReadLine().Split();
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
