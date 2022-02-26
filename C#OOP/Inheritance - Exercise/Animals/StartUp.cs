using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                {
                    break;
                }

                string[] animalData = Console.ReadLine().Split();
                string name = animalData[0];
                int age = int.Parse(animalData[1]);
                string gender = animalData[1];

                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                Animal animal = null;

                if (type == "Cat")
                {
                    animal = new Cat(name, age, gender);
                }
                else if (type == "Dog")
                {
                    animal = new Dog(name, age, gender);
                }
                else if (type == "Frog")
                {
                    animal = new Frog(name, age, gender);
                }
                else if (type == "Kitten")
                {
                    animal = new Kitten(name, age);
                }
                else
                {
                    animal = new Tomcat(name, age);
                }
                
                Console.WriteLine(type);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
                
            }

        }
    }
}
