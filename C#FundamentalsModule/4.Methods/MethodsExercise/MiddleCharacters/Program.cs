using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(PrintMiddle(text));
        }

        private static string PrintMiddle(string text)
        {
            string current = text;
            if (text.Length % 2 == 0)
            {
                text = text[current.Length / 2 - 1].ToString() + text[current.Length / 2].ToString();
            }
            else
            {
                text = text[current.Length / 2].ToString();
            }
            return text;
        }
    }
}
