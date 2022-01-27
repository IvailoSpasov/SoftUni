using System;

namespace _09PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double totalDogFood = dogCount * 2.5;
            double totalOtherAnimals = otherAnimalsCount * 4.0;

            double totalFood = totalDogFood + totalOtherAnimals;

            Console.WriteLine($"{totalFood} lv.");
        }
    }
}
