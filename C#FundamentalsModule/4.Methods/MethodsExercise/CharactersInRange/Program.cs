using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
           char start = char.Parse(Console.ReadLine());
           char end = char.Parse(Console.ReadLine());

            PrintChars(start, end);
        }

        private static void PrintChars(char start, char end)
        {
            int count = 0;
            char empty = end;

            if ((int)start > (int)end)
            {
                end = start;
                start = empty;      
                
            }
            for (char i = start; i < end; i++)
            {
                if (count > 0)
                {
                    Console.Write($"{i} ");
                }

                count++;
            }
        }
    }
}
