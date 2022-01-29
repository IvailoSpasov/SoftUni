using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string[], int, string[]> GetNames = (names, n) => names.Where(name => name.Length <= n).ToArray();
            names = GetNames(names, n);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
