using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());

            List<string> output = GetResult(inputs);

            Console.WriteLine(string.Join(Environment.NewLine, output));


        }

        private static List<string> GetResult(int inputs)
        {
            
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            for (int i = 0; i < inputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                pairs.Add(input[0], input[1]);
            }

            string old = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string[] pick = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> returnIt = ReturnList(pairs, old, age, pick);

            return returnIt;
        }

        private static List<string> ReturnList(Dictionary<string, string> pairs, string old, int age, string[] pick)
        {
            List<string> years = new List<string>();
            List<string> names = new List<string>();
            List<string> yearsAndNames = new List<string>();
            Dictionary<string, string> current = new Dictionary<string, string>();
 
            if (old == "older")
            {
                foreach (var item in pairs.Where(n => int.Parse(n.Value) >= age))
                {
                    current.Add(item.Key, item.Value);
                }
            }
            else
            {
                foreach (var item in pairs.Where(n => int.Parse(n.Value) < age))
                {
                    current.Add(item.Key, item.Value);
                }
            }

            if (pick.Length < 2)
            {
                if (pick[0] == "age")
                {
                    foreach (var item in current)
                    {
                        years.Add(item.Value);
                    }
                    return years;
                }
                else
                {
                    foreach (var item in current)
                    {
                        names.Add(item.Key);
                    }
                    return names;
                }
            }
            else
            {
                foreach (var item in current)
                {
                    yearsAndNames.Add($"{item.Key} - {item.Value}");                    
                }

                return yearsAndNames;
            }
        }
    }
}
