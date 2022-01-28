using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printingOnNewLine = name => Console.WriteLine("Sir "+string.Join(Environment.NewLine+ "Sir ", name));
            printingOnNewLine(names);
        }
    }
}
