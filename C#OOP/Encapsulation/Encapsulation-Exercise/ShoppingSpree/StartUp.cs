using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personsInput = SplitInput();
            string[] productsInput = SplitInput();

            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                foreach (var item in personsInput)
                {
                    string[] current = item.Split("=");
                    Person person = new Person(current[0], decimal.Parse(current[1]));
                    persons.Add(person);
                }

                foreach (var item in productsInput)
                {
                    string[] current = item.Split("=");
                    Product product = new Product(current[0], decimal.Parse(current[1]));
                    products.Add(product);
                }
                
                string text = Console.ReadLine();
                while (text != "END")
                {
                    string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    int index = persons.FindIndex(n => n.Name == command[0]);
                    int secIndex = products.FindIndex(n => n.Name == command[1]);

                    persons[index].CanAfford(products[secIndex]);

                    text = Console.ReadLine();
                }

                foreach (var item in persons)
                {
                    if (item.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{item.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            static string[] SplitInput()
            {
                string[] current = Console.ReadLine()
                   .Split(";", StringSplitOptions.RemoveEmptyEntries);

                return current;
            }
        }
    }
}
