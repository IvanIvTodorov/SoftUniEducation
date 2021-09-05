using System;

namespace ExerciseSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = k; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 9; j >= l; j--)
                    {
                        if (j % 2 != 0)
                        {
                            for (int c = m; c <= 8; c++)
                            {
                                if (c % 2 == 0)
                                {
                                    for (int o = 9; o >= n; o--)
                                    {
                                        if (o % 2 != 0)
                                        {
                                            if (i == c && j == o)
                                            {
                                                Console.WriteLine("Cannot change the same player.");
                                            }
                                            else
                                            {
                                                count++;
                                                Console.WriteLine($"{i}{j} - {c}{o}");
                                                if (count == 6)
                                                {
                                                    Environment.Exit(0);
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
        }
    }
}
