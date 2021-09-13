using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                { 'A' , ".-"},
                { 'B' , "-..."},
                { 'C' , "-.-."},
                { 'D' , "-.."},
                { 'E' , "."},
                { 'F' , "..-."},
                { 'G' , "--."},
                { 'H' , "...."},
                { 'I' , ".."},
                { 'J' , ".---"},
                { 'K' , "-.-"},
                { 'L' , ".-.."},
                { 'M' , "--"},
                { 'N' , "-."},
                { 'O' , "---"},
                { 'P' , ".--."},
                { 'Q' , "--.-"},
                { 'R' , ".-."},
                { 'S' , "..."},
                { 'T' , "-"},
                { 'U' , "..-"},
                { 'V' , "...-"},
                { 'W' , ".--"},
                { 'X' , "-..-"},
                { 'Y' , "-.--"},
                { 'Z' , "--.."}
        };

            string output = string.Empty;

            foreach (var item in text)
            {
                if (item == "|")
                {
                    output += " ";
                }
                else if (morse.ContainsValue(item))
                {
                    foreach (var symbol in morse.Where(n => n.Value == item))
                    {
                        output += symbol.Key;
                        break;
                    }

                }
            }
            Console.WriteLine(output.Trim());
        }
    }
}
