using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int GetMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (input == "string")
            {
                Console.WriteLine(GetMax(a, b));
            }
            else if (input == "int")
            {
                Console.WriteLine(GetMax(int.Parse(a), int.Parse(b)));
                
            }
            else
            {
                Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
               
            }
        }
    }
}
