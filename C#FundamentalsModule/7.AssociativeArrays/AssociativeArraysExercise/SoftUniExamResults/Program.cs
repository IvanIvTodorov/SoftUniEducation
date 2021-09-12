using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> contests = new Dictionary<string, int>();

            string text = Console.ReadLine();

            while (text != "exam finished")
            {
                string[] command = text.Split("-");

                if (command.Length > 2)
                {
                    if (results.ContainsKey(command[0]))
                    {
                        if (results[command[0]] <= int.Parse(command[2]))
                        {
                            results[command[0]] = int.Parse(command[2]);
                        }
                    }
                    else
                    {
                        results.Add(command[0], int.Parse(command[2]));
                    }
                    if (!contests.ContainsKey(command[1]))
                    {
                        contests.Add(command[1], 1);
                    }
                    else
                    {
                        contests[command[1]]++;
                    }
                }
                else
                {
                    if (results.ContainsKey(command[0]))
                    {
                        results.Remove(command[0]);
                    }
                }

                text = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (var item in results.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var item in contests.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }     
    }
}
