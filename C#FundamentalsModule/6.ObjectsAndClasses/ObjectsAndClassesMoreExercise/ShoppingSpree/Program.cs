using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(";");

            List<Person> persons = new List<Person>();

            foreach (var item in input)
            {
                string[] result = item.Split("=");
                Person person = new Person(result[0], double.Parse(result[1]));

                persons.Add(person);
            }

            input = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();
            foreach (var item in input)
            {
                string[] result = item.Split("=");
                Product product = new Product(result[0], double.Parse(result[1]));

                products.Add(product);
            }

            

            string text = Console.ReadLine();
                

            while (text != "END")
            {

                string[] result = text.Split();

                if (persons.Any(n => n.Name == result[0]))
                {
                    int index = persons.FindIndex(n => n.Name == result[0]);
                    if (products.Any(n => n.Name == result[1]))
                    {
                        int secIndex = products.FindIndex(n => n.Name == result[1]);

                        if (persons[index].Money - products[secIndex].Cost >= 0)
                        {
                            Console.WriteLine($"{persons[index].Name} bought {products[secIndex].Name}");

                            persons[index].Money -= products[secIndex].Cost;
                            persons[index].Product.Add(products[secIndex].Name);
                        }
                        else
                        {
                            Console.WriteLine($"{persons[index].Name} can't afford {products[secIndex].Name}");
                        }
                    }
                }

                text = Console.ReadLine();
            }

            
            foreach (Person item in persons)
            {
                if (item.Product.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Product)}");
                }
                
            }


        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Product = new List<string>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> Product { get; set; }

    }
    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }

    }
}
