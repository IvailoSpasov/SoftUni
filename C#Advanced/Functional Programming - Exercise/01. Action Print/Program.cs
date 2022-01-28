using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printingOnNewLine = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            printingOnNewLine(names);
        }
    }
}
