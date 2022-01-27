using System;

namespace _01bgnToUsd
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. promenliva za dolarite
            double usd = double.Parse(Console.ReadLine());
            //2.promenliva za levovete
            double lev = usd * 1.79549;
            Console.WriteLine(lev);

        }
    }
}
