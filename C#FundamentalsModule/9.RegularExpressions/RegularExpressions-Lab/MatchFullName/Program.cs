using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);

            Console.WriteLine(string.Join(" ", matches));          
        }
    }
}
