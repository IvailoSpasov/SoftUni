using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            StringBuilder product = new StringBuilder();

            int rest = 0;
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int num = int.Parse((firstNumber[i]).ToString());
                int sum = (num * secondNumber) + rest;
                rest = sum / 10;
                string digitToAdd = (sum % 10).ToString();
                product.Insert(0, digitToAdd);

            }

            if (rest > 0)
            {
                product.Insert(0, rest);
            }

            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(product);
        }
    }
}
