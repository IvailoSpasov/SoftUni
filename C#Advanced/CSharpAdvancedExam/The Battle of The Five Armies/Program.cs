using System;

namespace The_Battle_of_The_Five_Armies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armyArmor = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] field = new char[numberOfRows][];
            int armyRow = 0;
            int armiCol = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                string rowsInput = Console.ReadLine().Trim();
                field[i] = new char[rowsInput.Length];
                for (int j = 0; j < rowsInput.Length; j++)
                {
                    field[i][j] = rowsInput[j];
                    if (field[i][j] == 'A')
                    {
                        armyRow = i;
                        armiCol = j;
                    }
                }
            }

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string direction = input[0];
                int orcsRow = int.Parse(input[1]);
                int orcsCol = int.Parse(input[2]);
                field[orcsRow][orcsCol] = 'O';

                if (direction == "up")
                {
                    if (IsCordinatesValid(armyRow - 1, armiCol, field))
                    {
                        armyArmor -= 1;
                        if (armyArmor <= 0)
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow - 1][armiCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow - 1};{armiCol}.");
                            PrintMatrix(field);
                            return;
                        }
                        if (field[armyRow - 1][armiCol] == 'O')
                        {
                            armyArmor -= 2;
                            if (armyArmor <= 0)
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow - 1][armiCol] = 'X';
                                Console.WriteLine($"The army was defeated at {armyRow - 1};{armiCol}.");
                                PrintMatrix(field);
                                return;
                            }
                            else
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow - 1][armiCol] = 'A';
                                armyRow -= 1;
                            }
                        }

                        else if (field[armyRow - 1][armiCol] == 'M')
                        {
                            field[armyRow - 1][armiCol] = '-';
                            field[armyRow][armiCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                            PrintMatrix(field);
                            return;
                        }
                        else
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow - 1][armiCol] = 'A';
                            armyRow -= 1;
                        }

                    }
                    else
                    {
                        armyArmor -= 1;
                    }
                }
                else if (direction == "down")
                {
                    if (IsCordinatesValid(armyRow + 1, armiCol, field))
                    {
                        armyArmor -= 1;
                        if (armyArmor <= 0)
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow + 1][armiCol] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow + 1};{armiCol}.");
                            PrintMatrix(field);
                            return;
                        }
                        if (field[armyRow + 1][armiCol] == 'O')
                        {
                            armyArmor -= 2;
                            if (armyArmor <= 0)
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow + 1][armiCol] = 'X';
                                Console.WriteLine($"The army was defeated at {armyRow + 1};{armiCol}.");
                                PrintMatrix(field);
                                return;
                            }
                            else
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow + 1][armiCol] = 'A';
                                armyRow += 1;
                            }
                        }

                        else if (field[armyRow + 1][armiCol] == 'M')
                        {
                            field[armyRow + 1][armiCol] = '-';
                            field[armyRow][armiCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                            PrintMatrix(field);
                            return;
                        }
                        else
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow + 1][armiCol] = 'A';
                            armyRow += 1;
                        }

                    }
                    else
                    {
                        armyArmor -= 1;
                    }
                }
                else if (direction == "left")
                {
                    if (IsCordinatesValid(armyRow, armiCol - 1, field))
                    {
                        armyArmor -= 1;
                        if (armyArmor <= 0)
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow][armiCol - 1] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armiCol - 1}.");
                            PrintMatrix(field);
                            return;
                        }
                        if (field[armyRow][armiCol - 1] == 'O')
                        {
                            armyArmor -= 2;
                            if (armyArmor <= 0)
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow][armiCol - 1] = 'X';
                                Console.WriteLine($"The army was defeated at {armyRow};{armiCol - 1}.");
                                PrintMatrix(field);
                                return;
                            }
                            else
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow][armiCol - 1] = 'A';
                                armiCol -= 1;
                            }
                        }

                        else if (field[armyRow][armiCol - 1] == 'M')
                        {
                            field[armyRow][armiCol - 1] = '-';
                            field[armyRow][armiCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                            PrintMatrix(field);
                            return;
                        }
                        else
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow][armiCol - 1] = 'A';
                            armiCol -= 1;
                        }

                    }
                    else
                    {
                        armyArmor -= 1;
                    }
                }
                else if (direction == "right")
                {
                    if (IsCordinatesValid(armyRow, armiCol + 1, field))
                    {
                        armyArmor -= 1;
                        if (armyArmor <= 0)
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow][armiCol + 1] = 'X';
                            Console.WriteLine($"The army was defeated at {armyRow};{armiCol + 1}.");
                            PrintMatrix(field);
                            return;
                        }
                        if (field[armyRow][armiCol + 1] == 'O')
                        {
                            armyArmor -= 2;

                            if (armyArmor <= 0)
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow][armiCol + 1] = 'X';
                                Console.WriteLine($"The army was defeated at {armyRow};{armiCol + 1}.");
                                PrintMatrix(field);
                                return;
                            }
                            else
                            {
                                field[armyRow][armiCol] = '-';
                                field[armyRow][armiCol + 1] = 'A';
                                armiCol += 1;
                            }
                        }

                        else if (field[armyRow][armiCol + 1] == 'M')
                        {
                            field[armyRow][armiCol + 1] = '-';
                            field[armyRow][armiCol] = '-';
                            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                            PrintMatrix(field);
                            return;
                        }
                        else
                        {
                            field[armyRow][armiCol] = '-';
                            field[armyRow][armiCol + 1] = 'A';
                            armiCol += 1;
                        }

                    }
                    else
                    {
                        armyArmor -= 1;
                    }
                }

                
                input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void PrintMatrix(char[][] field)
        {
            foreach (var row in field)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static bool IsCordinatesValid(int armyRow, int armiCol, char[][] field)
        {
            if (armyRow >= 0 && armyRow < field[0].Length && armiCol >= 0 && armiCol < field.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
