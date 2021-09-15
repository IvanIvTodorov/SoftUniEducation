using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"([#|@])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            Regex reg = new Regex(pattern);

            MatchCollection matches = reg.Matches(text);

            if (matches.Count != 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine($"No word pairs found!");
            }
            
            List<string> words = new List<string>();
            foreach (Match item in matches)
            {
                string first = item.Groups["first"].ToString();
                string second = item.Groups["second"].ToString();
                char[] arr = second.ToCharArray();
                Array.Reverse(arr);
                second = new string (arr);

                if (first == second)
                {
                    words.Add($"{first} <=> {item.Groups["second"].ToString()}");
                }

            }
            if (words.Count != 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", words));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
