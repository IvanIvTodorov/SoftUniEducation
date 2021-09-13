using System;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            while (text != "find")
            {
                string name = string.Empty;
                string location = string.Empty;
                string newText = string.Empty;

                int length = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (length == numbers.Length)
                    {
                        length = 0;
                    }

                    newText += (char)(text[i] - numbers[length++]);
                }

                int start = newText.IndexOf('&') + 1;
                int end = newText.LastIndexOf('&');

                for (int i = start; i < end; i++)
                {
                    name += newText[i];
                }

                start = newText.IndexOf('<') + 1;
                end = newText.IndexOf('>');

                for (int i = start; i < end; i++)
                {
                    location += newText[i];
                }

                Console.WriteLine($"Found {name} at {location}");
                text = Console.ReadLine();
            }
        }
    }
}
