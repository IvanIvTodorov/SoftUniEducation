using System;
using System.Collections.Generic;

namespace ListsOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            
            products.Sort();

            int count = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{count}.{product}");
                count++;
            }


        }
    }
}
