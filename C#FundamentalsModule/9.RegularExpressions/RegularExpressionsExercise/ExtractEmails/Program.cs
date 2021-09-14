using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^[A-Za-z0-9]+[\w\.\-]*[A-Za-z0-9]+@[A-Za-z]+[a-z\-\.]*\.[a-z]+";

            foreach (var item in text)
            {
                var match = Regex.Match(item, pattern);
                if (match.Length > 0)
                {
                    Console.WriteLine(string.Join("", match));
                }
            }
        }
    }
}
