using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();
            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);
                if (persons.Any(person => person.ID == id))
                {
                    Person currPerson = persons.Find(person => person.ID == id);
                    currPerson.Age = age;
                    currPerson.Name = name;
                }
                else
                {
                    Person person = new Person(name,id,age);
                    persons.Add(person);
                }
                input = Console.ReadLine().Split();
            }

            foreach (Person person in persons.OrderBy(person=>person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
