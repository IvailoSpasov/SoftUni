using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = N1 + N2;
                    break;
                case "-":
                    result = N1 - N2;
                    break;
                case "*":
                    result = N1 * N2;
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = (double)N1 / N2;
                    }
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 % N2;
                    }
                    break;
            }

            if (symbol == "+" || symbol == "-" || symbol =="*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
                
            }
            else if (symbol == "/" && N2 != 0)
            {
                Console.WriteLine($"{N1} {symbol} {N2} = {result:f2}");
            }
            else if (symbol == "%" && N2 != 0)
            {
                Console.WriteLine($"{N1} {symbol} {N2} = {result}");
            }
        }
    }
}
