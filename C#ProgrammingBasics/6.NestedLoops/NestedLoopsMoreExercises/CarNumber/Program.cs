using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int c = start; c <= end; c++)
                        {
                            if ((i % 2 == 0 && c % 2 != 0) || (i % 2 != 0 && c % 2 == 0))
                            {
                                if (i > c)
                                {
                                    if ((j+k) % 2 == 0)
                                    {
                                        Console.Write($"{i}{j}{k}{c} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
