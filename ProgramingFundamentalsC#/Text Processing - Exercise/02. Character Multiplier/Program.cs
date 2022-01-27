using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = MultipliedTwoStrings(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static int MultipliedTwoStrings(string firstWord, string secondWord)
        {
            int sum = 0;
            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            string biggestWord = firstWord;
            if (secondWord.Length>firstWord.Length)
            {
                biggestWord = secondWord;
            }
            for (int i = minLength; i < biggestWord.Length; i++)
            {
                sum += biggestWord[i];
            }

            return sum;
        }
    }
}
