using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (text != "Revision")
            {
                string[] input = text
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (shops.ContainsKey(input[0]))
                {
                    shops[input[0]].Add(input[1], double.Parse(input[2]));
                }
                else
                {
                    shops.Add(input[0], new Dictionary<string, double>());
                    shops[input[0]].Add(input[1], double.Parse(input[2]));
                }

                text = Console.ReadLine();
            }

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var shop in item.Value)
                {
                    Console.WriteLine($"Product: {shop.Key}, Price: {shop.Value}");
                }
            }
        }
    }
}
