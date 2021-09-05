using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1|| i == n)
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                }
                else
                {
                    for (int j = 1; j <= n * 2; j++)
                    {
                        if (j == 1 || j == n *2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                        
                    }
                    if (n % 2 != 0)
                    {
                        if (i == (n / 2 + 1))
                        {
                            Console.Write(new String('|', n));
                        }
                        else
                        {
                            Console.Write(new String(' ', n));
                        }
                    }
                    else
                    {
                        if (i == n / 2)
                        {
                            Console.Write(new String('|', n));
                        }
                        else
                        {
                            Console.Write(new String(' ', n));
                        }
                    }
                    for (int j = 1; j <= n * 2; j++)
                    {
                        if (j == 1 || j == n * 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
