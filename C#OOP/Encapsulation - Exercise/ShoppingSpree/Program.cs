using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] persons = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Person> personsDictionary = new Dictionary<string, Person>();
                for (int i = 0; i < persons.Length; i += 2)
                {
                    string name = persons[i];
                    decimal money = decimal.Parse(persons[i + 1]);
                    Person person = new Person(name, money);
                    personsDictionary.Add(person.Name, person);
                }
                string[] products = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Product> productsDictionary = new Dictionary<string, Product>();
                for (int i = 0; i < products.Length; i += 2)
                {
                    string name = products[i];
                    decimal cost = decimal.Parse(products[i + 1]);
                    Product product = new Product(name, cost);
                    productsDictionary.Add(product.Name, product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] splitedCommand = command.Split();
                    string personName = splitedCommand[0];
                    string productName = splitedCommand[1];
                    Console.WriteLine(personsDictionary[personName].BuyProduct(productsDictionary[productName]));
                    command = Console.ReadLine();
                }

                foreach (var person in personsDictionary)
                {
                    if (person.Value.Products.Count != 0)
                    {
                        Console.WriteLine($"{person.Key} - {string.Join(", ", person.Value.Products.Select(x => x.Name))}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Key} - Nothing bought");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
