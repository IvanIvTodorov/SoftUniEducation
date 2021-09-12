using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            List<Product> products = new List<Product>();
            while (text != "buy")
            {
                string[] input = text.Split();

                if (products.Any(n => n.Name.Contains(input[0])))
                {
                    int index = products.FindIndex(n => n.Name.Contains(input[0]));

                    products[index].NameAndQty[input[0]] += int.Parse(input[2]);
                    products[index].Price = double.Parse(input[1]);
                }
                else
                {
                    Product product = new Product(double.Parse(input[1]), input[0]);
                    product.NameAndQty.Add(input[0], int.Parse(input[2]));

                    products.Add(product);
                }

                text = Console.ReadLine();
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} -> {item.NameAndQty[item.Name] * item.Price:F2}");           
            }
        }
    }
    class Product
    {
        public Product(double price, string name)
        {
            Price = price;
            Name = name;
            NameAndQty = new Dictionary<string, int>();
        }
        public Dictionary<string, int> NameAndQty { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
