using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitters = new string[] { " ", "," };
            string[] inputs = Console.ReadLine()
                 .Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<int, double>> names = new Dictionary<string, Dictionary<int, double>>();

            foreach (var text in inputs)
            {
                string wordPattern = @"[^0-9\-+*/.]";
                string numberPattern = @"-?[0-9]*\.?[0-9]+";       
                string commandsPattern = @"[*/]";

                var matchWord = Regex.Matches(text, wordPattern);
                var matchNum = Regex.Matches(text, numberPattern);
                var matchCommand = Regex.Matches(text, commandsPattern);

                string name = string.Empty;
                string forHealth = string.Empty;
                double damage = 0;
                int health = 0;
                if (text.Length == 0)
                {
                    continue;
                }            
                foreach (var item in matchWord)
                {
                    forHealth += item;
                }
                foreach (char item in forHealth)
                {
                    health += (char)item;
                }
                foreach (var item in matchNum)
                {
                    damage += double.Parse(item.ToString());
                }
                foreach (var item in matchCommand)
                {
                    if (item.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                    
                }
                names.Add(text, new Dictionary<int, double>());
                names[text].Add(health, damage);
            }

            foreach (var item in names.OrderBy(n => n.Key))
            {
                Console.Write($"{item.Key}");
                foreach (var text in item.Value)
                {
                    Console.WriteLine($" - {text.Key} health, {text.Value:f2} damage");
                }
            }
        }
    }
}
