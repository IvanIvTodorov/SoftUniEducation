using System;
using System.Collections.Generic;
using System.Linq;

namespace Ramking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] text = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                contests.Add(text[0], text[1]);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<Person> persons = new List<Person>();
            while (input != "end of submissions")
            {
                string[] text = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (contests.ContainsKey(text[0]))
                {
                    if (contests[text[0]].Contains(text[1]))
                    {
                        if (!persons.Any(n => n.Name == text[2]))
                        {

                            Person person = new Person(text[2]);
                            person.Result.Add(text[0], int.Parse(text[3]));

                            persons.Add(person);

                        }
                        else
                        {
                            int index = persons.FindIndex(n => n.Name == text[2]);

                            if (!persons[index].Result.ContainsKey((text[0])))
                            {
                                persons[index].Result.Add(text[0], int.Parse(text[3]));

                            }
                            else
                            {
                                if (persons[index].Result[text[0]] < int.Parse(text[3]))
                                {
                                    persons[index].Result[text[0]] = int.Parse(text[3]);
                                }
                            }
                        }
                    }

                }
                input = Console.ReadLine();
            }

            foreach (var item in persons.OrderByDescending(n => n.Result.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {item.Name} with total {item.Result.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking: ");
            foreach (var item in persons.OrderBy(n => n.Name).ThenByDescending(n => n.Result.Values))
            {

                Console.WriteLine(item.Name);
                foreach (var result in item.Result.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"#  {result.Key} -> {result.Value}");
                }

            }
        }
    }
    class Person
    {
        public Person(string name)
        {
            Name = name;
            Result = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> Result { get; set; }

    }
}
