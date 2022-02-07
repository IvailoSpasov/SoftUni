using System;
using System.Linq;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndCityImput = Console.ReadLine().Split();

            string name = $"{nameAndCityImput[0]} {nameAndCityImput[1]}";
            string street = nameAndCityImput[2];
            string city = nameAndCityImput[3];

            MyTuple<string, string,string> nameCity = new MyTuple<string, string,string>(name, street,city);

            string[] beerInput = Console.ReadLine().Split();

            string beer = beerInput[0];
            int beerQuantity = int.Parse(beerInput[1]);
            string drunkOrNot = beerInput[2];
            bool IsDrunk = drunkOrNot == "drunk";

            MyTuple<string, int,bool> beerMyTuple = new MyTuple<string, int,bool>(beer, beerQuantity,IsDrunk);

            string[] numbers = Console.ReadLine().Split();

            string accName = numbers[0];
            double ballance = double.Parse(numbers[1]);
            string bankName = numbers[2];

            MyTuple<string, double,string> numbersMyTuple = new MyTuple<string, double,string>(accName, ballance,bankName);
            Console.WriteLine(nameCity);
            Console.WriteLine(beerMyTuple);
            Console.WriteLine(numbersMyTuple);
        }
    }
}
