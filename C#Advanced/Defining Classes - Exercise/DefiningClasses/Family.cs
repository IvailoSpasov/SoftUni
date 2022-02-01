using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

        public void AddMember(Person person)
        {
            Persons.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = Persons.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }

        public List<Person> GetPeopleOverThirty()
        {
            List<Person> persons = Persons.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            return persons;
        }
    }
}
