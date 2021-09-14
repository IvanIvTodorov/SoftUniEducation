using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Match> atackers = new List<Match>();
            List<Match> defenders = new List<Match>();
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();

                int count = 0;
                foreach (char item in text)
                {
                    if (item == 'S' || item == 's' ||
                        item == 'T' || item == 't' || 
                        item == 'A' || item == 'a' ||
                        item == 'R' || item == 'r')
                    {
                        count++;
                    }
                }
                string result = string.Empty;
                foreach (char item in text)
                {
                    result += (char)(item - count);
                }

                string attack = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<ppl>[0-9]+)[^@\-!:>]*!(?<command>[A])![^@\-!:>]*->(?<soldier>[0-9]+)";
                string deffense = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<ppl>[0-9]+)[^@\-!:>]*!(?<command>[D])![^@\-!:>]*->(?<soldier>[0-9]+)";

                Match match = Regex.Match(result, attack);
                Match secMatch = Regex.Match(result, deffense);

                if (Regex.IsMatch(result, attack))
                {
                    atackers.Add(match);
                }
                else if (Regex.IsMatch(result, deffense))
                {
                    defenders.Add(secMatch);
                }
            }

            Console.WriteLine($"Attacked planets: {atackers.Count}");
            if (atackers.Count > 0)
            {
                foreach (Match item in atackers.OrderBy(n => n.Groups["name"].Value))
                {
                    Console.WriteLine($"-> {item.Groups["name"].Value}");
                }
            }
            Console.WriteLine($"Destroyed planets: {defenders.Count}");
            if (defenders.Count > 0)
            {
                foreach (Match item in defenders.OrderBy(n => n.Groups["name"].Value))
                {
                    Console.WriteLine($"-> {item.Groups["name"].Value}");
                }
            }

        }
    }
}
