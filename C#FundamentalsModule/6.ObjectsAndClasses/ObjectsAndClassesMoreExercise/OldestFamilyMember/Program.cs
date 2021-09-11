using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();
            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine().Split();

                Person person = new Person(text[0], int.Parse(text[1]));

                persons.Add(person);
            }

            foreach (var item in persons.OrderByDescending(n => n.Age))
            {
                Console.WriteLine($"{item.Name} {item.Age}");
                break;
            }
        }

        
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
