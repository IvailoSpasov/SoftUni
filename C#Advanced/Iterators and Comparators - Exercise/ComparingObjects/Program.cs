using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> srtedSet = new SortedSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                hashSet.Add(person);
                srtedSet.Add(person);
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(srtedSet.Count);
        }
    }
}
