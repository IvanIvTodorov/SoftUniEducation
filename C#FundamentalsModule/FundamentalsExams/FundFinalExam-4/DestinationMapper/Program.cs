using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\=|\/)(?<name>[A-Z][A-Za-z]{2,})\1";

            Regex reg = new Regex(pattern);

            MatchCollection matches = reg.Matches(text);

            Console.WriteLine($"Destinations: {string.Join(", ", matches.Select(n => n.Groups["name"]))}");
           
            int points = 0;
            foreach (Match item in matches)
            {
                points += item.Groups["name"].Length;
            }

            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
