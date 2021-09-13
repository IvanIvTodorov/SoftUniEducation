using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                output.Append($"{(char)(text[i] + 3)}");
            }

            Console.WriteLine(output);
        }
    }
}
