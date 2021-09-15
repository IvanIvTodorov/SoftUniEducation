using System;
using System.Text.RegularExpressions;

namespace RegularExpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\|([A-Z]{4,})\|\:\#([A-Za-z]+\s?[A-Za-z]+)\#";

            Regex reg = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var match = reg.Match(input);

                if (reg.IsMatch(input))
                {
                    Console.WriteLine($"{match.Groups[1]}, The {match.Groups[2]}");
                    Console.WriteLine($">> Strength: {match.Groups[1].Length}");
                    Console.WriteLine($">> Armor: {match.Groups[2].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
