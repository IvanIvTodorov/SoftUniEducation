using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine()
                 .Split();

            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string current = text[i];
                for (int j = 0; j < current.Length; j++)
                {
                    if (!count.ContainsKey(current[j]))
                    {
                        count.Add(current[j], 0);
                    }
                    count[current[j]]++;
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
