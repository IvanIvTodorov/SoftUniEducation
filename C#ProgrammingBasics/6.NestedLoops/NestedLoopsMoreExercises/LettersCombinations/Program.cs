using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = start; i <= end; i++)
            {
                if (i != miss)
                {
                    for (char j = start; j <= end; j++)
                    {
                        if (j != miss)
                        {
                            for (char c = start; c <= end; c++)
                            {
                                if (c != miss)
                                {
                                    count++;
                                    Console.Write($"{i}{j}{c} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.Write($"{count}");

        }
    }
}
