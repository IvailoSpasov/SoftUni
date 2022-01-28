using System;
using System.Linq;

namespace _11._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int asciiSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> isSumOfLettersEqualOrLarger = (name, sumOfLetters) => name.Sum(x=>x) >= sumOfLetters;
            Func<string[], int, Func<string, int, bool>, string> getName = (names, ascii, func) =>
                names.Where(x => func(x, ascii)).FirstOrDefault();

            string name = getName(names, asciiSum, isSumOfLettersEqualOrLarger);
            Console.WriteLine(name);
        }
    }
}
