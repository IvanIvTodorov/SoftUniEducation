using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > start && text[i] < end)
                {
                    sum += text[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
