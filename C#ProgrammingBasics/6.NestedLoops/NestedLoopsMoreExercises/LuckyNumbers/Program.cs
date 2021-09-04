using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (i + k == c + m)
                            {
                                if (n % (i+k) == 0)
                                {
                                    Console.Write($"{i}{k}{c}{m} ");
                                }
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
