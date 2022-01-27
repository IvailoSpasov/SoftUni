using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> findUppercaseWords = x => char.IsUpper(x[0]);
            foreach (var word in words.Where(findUppercaseWords))
            {
                Console.WriteLine(word);
            }
        }
    }
}
