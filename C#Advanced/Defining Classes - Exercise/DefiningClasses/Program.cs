using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int difference = DateModifier.GetDifferenceBetweenTwoDates(firstDate, secondDate);
            Console.WriteLine(difference);

        }
    }
}
