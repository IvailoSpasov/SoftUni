using System;
using System.Threading.Channels;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractOfTwoNumbers(SumOfTwoNumbers(num1,num2),num3));
        }

        private static int SumOfTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        private static int SubstractOfTwoNumbers(int sumOfTwoNumbers, int num3)
        {
            int result = sumOfTwoNumbers - num3;
            return result;
        }
    }
}
