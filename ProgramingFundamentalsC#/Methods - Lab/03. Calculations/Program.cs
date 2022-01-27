using System;

namespace _03._Calculations
{
    class Program
    {
        static void addTwoNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void SubtractTwoNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void multiplyTwoNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void devideTwoNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "add":
                    addTwoNumbers(a ,b);
                    break;
                case "multiply":
                    multiplyTwoNumbers(a,b);
                    break;
                case "subtract":
                    SubtractTwoNumbers(a,b);
                    break;
                case "divide":
                    devideTwoNumbers(a,b);
                    break;
            }
        }
    }
}
