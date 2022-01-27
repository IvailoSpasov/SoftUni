using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char symbul = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(OperationsWithTwoNumbers(num1,symbul,num2));
        }

        private static double OperationsWithTwoNumbers(double num1, char symbul, double num2)
        {
            double result = 0;
            if (symbul == '+')
            {
                result = num1 + num2;
            }
            else if (symbul =='-')
            {
                result = num1 - num2;
            }
            else if (symbul == '*')
            {
                result = num1 * num2;
            }
            else if (symbul=='/')
            {
                result = num1 / num2;
            }

            return result;
        }
    }
}
