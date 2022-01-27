using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDna = new int[n];
            int sample = 0;
            int bestDnaCounter = 0;
            int countOfBestDna1 = 0;
            int bestDnaSample = 0;
            int bestDnaIndex = 0;
            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                sample++;
                int[] dna = input.Split("!".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int counterOf1 = 0;
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 1)
                    {
                        counterOf1++;
                    }
                }

                for (int j = 0; j < dna.Length; j++)
                {
                    int counter = 0;
                    int index = 0;
                    for (int k = j + 1; k < dna.Length; k++)
                    {
                        if (dna[j] == dna[k] && dna[j] == 1)
                        {
                            counter++;
                            index = j;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (counter > bestDnaCounter)
                    {
                        bestDnaCounter = counter;
                        countOfBestDna1 = counterOf1;
                        bestDnaSample = sample;
                        bestDna = dna;
                        bestDnaIndex = index;
                    }
                    else if (counter == bestDnaCounter)
                    {
                        if (index < bestDnaIndex)
                        {
                            bestDnaCounter = counter;
                            countOfBestDna1 = counterOf1;
                            bestDnaSample = sample;
                            bestDna = dna;
                            bestDnaIndex = index;
                        }
                        else if (index == bestDnaIndex)
                        {
                            if (counterOf1 > countOfBestDna1)
                            {
                                bestDnaCounter = counter;
                                countOfBestDna1 = counterOf1;
                                bestDnaSample = sample;
                                bestDna = dna;
                                bestDnaIndex = index;
                            }
                        }

                    }

                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Best DNA sample {bestDnaSample} with sum: {countOfBestDna1}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
