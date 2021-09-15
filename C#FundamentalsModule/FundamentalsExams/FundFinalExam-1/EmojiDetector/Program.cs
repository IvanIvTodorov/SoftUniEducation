using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string coolPatt = @"[0-9]";
            string emojiPatt = @"(::|\*\*)([A-Z][a-z]{2,})\1";

            Regex count = new Regex(coolPatt);
            Regex emoji = new Regex(emojiPatt);

            var matches = count.Matches(input);
            int number = 1;
            foreach (Match item in matches)
            {
                number *= int.Parse(item.ToString());
            }

            Console.WriteLine($"Cool threshold: {number}");
            matches = emoji.Matches(input);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match item in matches)
            {
                string current = item.ToString();
                BigInteger value = 0; 
                for (int i = 2; i < current.Length - 2; i++)
                {
                    value += current[i];
                }
                if (value > number)
                {
                    Console.WriteLine(current);
                }
            }
        }
    }
}
