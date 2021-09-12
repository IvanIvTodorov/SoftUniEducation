using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            int count = 0;
            string current = string.Empty;
            while (text != "stop")
            {               
                if (count % 2 == 0 && !resources.ContainsKey(text))
                {
                    current = text;
                    resources.Add(text, 0);
                }
                else if (count % 2 == 0)
                {
                    current = text;
                }
                if (count % 2 != 0)
                {
                    resources[current] += int.Parse(text);
                }

                text = Console.ReadLine();
                count++;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
