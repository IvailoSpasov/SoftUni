using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            char[,] field = new char[fieldSize, fieldSize];
            field = FilingTheField(field);

            int numberOfCoals = 0;
            int playerRowIndex = 0;
            int playerColIndex = 0;

            for (int rowIndex = 0; rowIndex < field.GetLength(0); rowIndex++)
            {
                for (int coIndex = 0; coIndex < field.GetLength(1); coIndex++)
                {
                    if (field[rowIndex, coIndex] == 'c')
                    {
                        numberOfCoals++;
                    }

                    if (field[rowIndex, coIndex] == 's')
                    {
                        playerColIndex = coIndex;
                        playerRowIndex = rowIndex;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string action = commands[i];
                if (action == "left" && IndexValidation(field, playerRowIndex, playerColIndex - 1))
                {
                    if (field[playerRowIndex, playerColIndex - 1] == 'c')
                    {
                        numberOfCoals--;
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex, playerColIndex - 1] = 's';
                        playerColIndex = playerColIndex - 1;
                    }
                    else if (field[playerRowIndex, playerColIndex - 1] == '*')
                    {
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex, playerColIndex - 1] = 's';
                        playerColIndex = playerColIndex - 1;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! ({playerRowIndex}, {playerColIndex - 1})");
                        return;
                    }
                }
                else if (action == "right" && IndexValidation(field, playerRowIndex, playerColIndex + 1))
                {
                    if (field[playerRowIndex, playerColIndex + 1] == 'c')
                    {
                        numberOfCoals--;
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex, playerColIndex + 1] = 's';
                        playerColIndex = playerColIndex + 1;
                    }
                    else if (field[playerRowIndex, playerColIndex + 1] == '*')
                    {
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex, playerColIndex + 1] = 's';
                        playerColIndex = playerColIndex + 1;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! ({playerRowIndex}, {playerColIndex + 1})");
                        return;
                    }
                }
                else if (action == "up" && IndexValidation(field, playerRowIndex - 1, playerColIndex))
                {
                    if (field[playerRowIndex - 1, playerColIndex] == 'c')
                    {
                        numberOfCoals--;
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex - 1, playerColIndex] = 's';
                        playerRowIndex = playerRowIndex - 1;
                    }
                    else if (field[playerRowIndex - 1, playerColIndex] == '*')
                    {
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex - 1, playerColIndex] = 's';
                        playerRowIndex = playerRowIndex - 1;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! ({playerRowIndex - 1}, {playerColIndex })");
                        return;
                    }
                }
                else if (action == "down" && IndexValidation(field, playerRowIndex + 1, playerColIndex))
                {
                    if (field[playerRowIndex + 1, playerColIndex] == 'c')
                    {
                        numberOfCoals--;
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex +1, playerColIndex] = 's';
                        playerRowIndex = playerRowIndex + 1;
                    }
                    else if (field[playerRowIndex + 1, playerColIndex] == '*')
                    {
                        field[playerRowIndex, playerColIndex] = '*';
                        field[playerRowIndex +1, playerColIndex] = 's';
                        playerRowIndex = playerRowIndex + 1;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! ({playerRowIndex + 1}, {playerColIndex })");
                        return;
                    }
                }

                if (numberOfCoals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({playerRowIndex}, {playerColIndex})");
                    return;
                }
            }

            Console.WriteLine($"{numberOfCoals} coals left. ({playerRowIndex}, {playerColIndex})");
        }

        private static bool IndexValidation(char[,] field, int playerRowIndex, int playerColIndex)
        {
            if (playerColIndex >= 0 && playerColIndex < field.GetLength(1) && playerRowIndex >= 0 && playerRowIndex < field.GetLength(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static char[,] FilingTheField(char[,] field)
        {
            for (int rowIndex = 0; rowIndex < field.GetLength(0); rowIndex++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();
                for (int coIndex = 0; coIndex < field.GetLength(1); coIndex++)
                {
                    field[rowIndex, coIndex] = input[coIndex];
                }
            }
            return field;
        }
    }
}
