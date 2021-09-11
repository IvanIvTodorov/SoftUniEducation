using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> collection = new List<People>();

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split();

                People people = new People(command[0], command[1], int.Parse(command[2]));
                collection.Add(people);

                text = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, collection.OrderBy(n => n.Age)));
        }
    }
    class People
    {
        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old."; 
        }

    }
}
