using System;
using System.Collections.Generic;
using System.Linq;

namespace Beaver_at_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] pond = new char[n, n];

            int numberOfBranches = 0;
            int beaverRow = 0;
            int beaverCol = 0;

            for (int i = 0; i < n; i++)
            {
                char[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    pond[i, j] = cols[j];
                    if (char.IsLower(pond[i, j]))
                    {
                        numberOfBranches++;
                    }
                    else if (pond[i, j] == 'B')
                    {
                        beaverRow = i;
                        beaverCol = j;
                    }
                }
            }

            List<char> colectedBranches = new List<char>();
            string action = Console.ReadLine();
            while (action != "end")
            {
                if (action == "up" && beaverRow - 1 >= 0)
                {
                    pond[beaverRow, beaverCol] = '-';
                    beaverRow--;
                    if (char.IsLower(pond[beaverRow, beaverCol]))
                    {
                        colectedBranches.Add(pond[beaverRow, beaverCol]);
                        numberOfBranches--;
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else if (pond[beaverRow, beaverCol] == 'F')
                    {
                        pond[beaverRow, beaverCol] = '-';
                        if (beaverRow - 1 >= 0)
                        {
                            beaverRow = 0;
                        }
                        else
                        {
                            beaverRow = n - 1;
                        }
                        if (char.IsLower(pond[beaverRow, beaverCol]))
                        {
                            colectedBranches.Add(pond[beaverRow, beaverCol]);
                            numberOfBranches--;
                        }
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        pond[beaverRow, beaverCol] = 'B';
                    }

                }
                else if (action == "down" && beaverRow + 1 < n)
                {
                    pond[beaverRow, beaverCol] = '-';
                    beaverRow++;
                    if (char.IsLower(pond[beaverRow, beaverCol]))
                    {
                        colectedBranches.Add(pond[beaverRow, beaverCol]);
                        numberOfBranches--;
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else if (pond[beaverRow, beaverCol] == 'F')
                    {
                        pond[beaverRow, beaverCol] = '-';
                        if (beaverRow + 1 < n)
                        {
                            beaverRow = n-1;
                        }
                        else
                        {
                            beaverRow = 0;
                        }
                        if (char.IsLower(pond[beaverRow, beaverCol]))
                        {
                            colectedBranches.Add(pond[beaverRow, beaverCol]);
                            numberOfBranches--;
                        }
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        pond[beaverRow, beaverCol] = 'B';
                    }

                }
                else if (action == "right" && beaverCol + 1 < n)
                {
                    pond[beaverRow, beaverCol] = '-';
                    beaverCol++;
                    if (char.IsLower(pond[beaverRow, beaverCol]))
                    {
                        colectedBranches.Add(pond[beaverRow, beaverCol]);
                        numberOfBranches--;
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else if (pond[beaverRow, beaverCol] == 'F')
                    {
                        pond[beaverRow, beaverCol] = '-';
                        if (beaverCol + 1 < n)
                        {
                            beaverCol = n - 1;
                        }
                        else
                        {
                            beaverCol = 0;
                        }
                        if (char.IsLower(pond[beaverRow, beaverCol]))
                        {
                            colectedBranches.Add(pond[beaverRow, beaverCol]);
                            numberOfBranches--;
                        }
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        pond[beaverRow, beaverCol] = 'B';
                    }

                }
                else if (action == "left" && beaverCol - 1 >= 0)
                {
                    pond[beaverRow, beaverCol] = '-';
                    beaverCol--;
                    if (char.IsLower(pond[beaverRow, beaverCol]))
                    {
                        colectedBranches.Add(pond[beaverRow, beaverCol]);
                        numberOfBranches--;
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else if (pond[beaverRow, beaverCol] == 'F')
                    {
                        pond[beaverRow, beaverCol] = '-';
                        if (beaverCol - 1 >= 0)
                        {
                            beaverCol = 0;
                        }
                        else
                        {
                            beaverCol = n - 1;
                        }
                        if (char.IsLower(pond[beaverRow, beaverCol]))
                        {
                            colectedBranches.Add(pond[beaverRow, beaverCol]);
                            numberOfBranches--;
                        }
                        pond[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        pond[beaverRow, beaverCol] = 'B';
                    }

                }
                else
                {
                    if (colectedBranches.Count>0)
                    {
                        colectedBranches.RemoveAt(colectedBranches.Count-1);
                    }
                }

                if (numberOfBranches==0)
                {
                    Console.WriteLine($"The Beaver successfully collect {colectedBranches.Count} wood branches: {string.Join(", ",colectedBranches)}.");
                    PrintingMatrix(pond);
                    return;
                }
                action = Console.ReadLine();
            }

            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {numberOfBranches} branches left.");
            PrintingMatrix(pond);
        }

        private static void PrintingMatrix(char[,] pond)
        {
            for (int i = 0; i < pond.GetLength(0); i++)
            {
                for (int j = 0; j < pond.GetLength(1); j++)
                {
                    Console.Write($"{pond[i,j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
