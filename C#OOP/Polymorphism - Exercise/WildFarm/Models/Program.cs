using System;
using System.Collections.Generic;
using WildFarm.Models.Animal;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (input!="End")
            {
                string[] animalInfo = input.Split();
                Animal animal;

                string animalType = animalInfo[0];
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                if (animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    animal = new Owl(name, weight, wingSize);
                }
                else if (animalType == "Hen")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    animal = new Hen(name, weight, wingSize);
                }
                else if (animalType == "Mouse")
                {
                    string livingRegion = animalInfo[3];
                    animal = new Mouse(name, weight, livingRegion);
                }
                else if (animalType == "Dog")
                {
                    string livingRegion = animalInfo[3];
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType=="Cat")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];
                    animal = new Cat(name, weight, livingRegion,breed);
                }
                else
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
                string[] foodInfo = Console.ReadLine().Split();

                Food food;
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);

                if (foodType == "Vegetable")
                {
                    food = new Vegetable(quantity);
                }
                else if (foodType=="Fruit")
                {
                    food = new Fruit(quantity);
                }
                else if (foodType == "Meat")
                {
                    food = new Meat(quantity);
                }
                else
                {
                    food = new Seeds(quantity);
                }
                animal.ProduceSount();
                animal.Eat(food);
                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
