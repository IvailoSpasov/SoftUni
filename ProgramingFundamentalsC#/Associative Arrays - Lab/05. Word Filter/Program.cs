using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (var word in words.Where(x => x.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}
