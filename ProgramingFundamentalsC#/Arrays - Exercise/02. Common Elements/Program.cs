using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrTwo.Length; i++)
            {
                string currentElement = arrTwo[i];

                for (int j = 0; j < arrOne.Length; j++)
                {
                    if (currentElement == arrOne[j])
                    {
                        Console.Write(currentElement + " ");
                    }
                }
            }
        }
    }
}
