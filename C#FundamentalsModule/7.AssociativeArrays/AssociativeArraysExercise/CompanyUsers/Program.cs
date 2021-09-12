using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (text != "End")
            {
                string[] input = text.Split(" -> ");

                if (companies.ContainsKey(input[0]))
                {
                    if (!companies[input[0]].Contains(input[1]))
                    {
                        companies[input[0]].Add(input[1]);
                    }
                }
                else
                {
                    companies.Add(input[0], new List<string>() { input[1] });
                }

                text = Console.ReadLine();
            }

            foreach (var item in companies.OrderBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var person in item.Value)
                {
                    Console.WriteLine($"-- {person}");
                }
            }
        }
    }
}
