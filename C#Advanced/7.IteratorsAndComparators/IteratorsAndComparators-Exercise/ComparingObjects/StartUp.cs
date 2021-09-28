using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (text != "END")
            {
                string[] input = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(input[0], int.Parse(input[1]), input[2]);

                persons.Add(person);
                text = Console.ReadLine();
            }

            int number = int.Parse(Console.ReadLine());
            Person pickedPerson = persons[--number];

            int equal = 0;
            int different = 0;
            
            foreach (var person in persons)
            {
                if (person.CompareTo(pickedPerson) == 0)
                {
                    equal++;
                }
                else
                {
                    different++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {different} {persons.Count}");
            }
        }
    }
}
