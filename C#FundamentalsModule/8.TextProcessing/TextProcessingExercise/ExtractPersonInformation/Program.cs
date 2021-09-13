using System;
using System.Linq;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;

                int start = text.IndexOf('@') + 1;
                int end = text.IndexOf('|');

                for (int c = start; c < end; c++)
                {
                    name += text[c];
                }

                start = text.IndexOf('#') + 1;
                end = text.IndexOf('*');

                for (int j = start; j < end; j++)
                {
                    age += text[j];
                }

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
