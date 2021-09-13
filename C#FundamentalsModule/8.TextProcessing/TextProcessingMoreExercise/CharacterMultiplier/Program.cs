using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int max = 0;
            if (text[0].Length >= text[1].Length)
            {
                max = text[0].Length;
            }
            else
            {
                max = text[1].Length;
            }

            int totalSum = 0;

            for (int i = 0; i < max; i++)
            {
                if (i >= text[0].Length)
                {
                    totalSum += text[1][i];
                }
                else if (i >= text[1].Length)
                {
                    totalSum += text[0][i];
                }
                else
                {
                    totalSum += text[0][i] * text[1][i];
                }
            }

            Console.WriteLine(totalSum);

        }
        
    }
}
