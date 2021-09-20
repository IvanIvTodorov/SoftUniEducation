using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

        public void AddMemeber(Person persons)
        {
            this.Persons.Add(persons);
        }

        public Person GetOldestMember()
        {          
            return this.Persons.OrderByDescending(n => n.Age).FirstOrDefault();
        }

        public List<Person> OlderThanThirty()
        {

           return this.Persons.Where(n => n.Age > 30).OrderBy(n => n.Name).ToList();
        
        }
    }
}
