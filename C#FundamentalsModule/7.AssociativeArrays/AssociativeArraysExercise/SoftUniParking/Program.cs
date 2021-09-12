using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> people = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split();

                if (text[0] == "register")
                {
                    if (people.ContainsKey(text[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {text[2]}");
                    }
                    else
                    {
                        people.Add(text[1], text[2]);
                        Console.WriteLine($"{text[1]} registered {text[2]} successfully");
                    }
                }
                else
                {
                    if (!people.ContainsKey(text[1]))
                    {
                        Console.WriteLine($"ERROR: user {text[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{text[1]} unregistered successfully");
                        people.Remove(text[1]);
                    }
                }             
            }
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
