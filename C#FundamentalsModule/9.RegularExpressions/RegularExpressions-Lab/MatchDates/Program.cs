using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"\b(?<date>(?:[0][1-9]|[1-2][0-9]|[3][0-2]))(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b";
            var matches = Regex.Matches(dates, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["date"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }
        }
    }
}
