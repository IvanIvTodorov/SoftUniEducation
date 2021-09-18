using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        public static object Dictiomnary { get; private set; }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (continents.ContainsKey(input[0]))
                {
                    if (continents[input[0]].ContainsKey(input[1]))
                    {
                        continents[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        continents[input[0]].Add(input[1], new List<string>() { input[2] });
                    }
                }
                else
                {
                    continents.Add(input[0], new Dictionary<string, List<string>>());
                    continents[input[0]].Add(input[1], new List<string>() { input[2] });                  
                }
            }

            foreach (var item in continents)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");                   
                }
            }

        }
    }
}
