using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dash = 2;
            int count = (n - 2) / 2;
            int dashOdd = 1;
            int countOdd = (n - 1) / 2;

            if (n == 1 || n == 2)
            {
                Console.Write(new String('*', n));
                Environment.Exit(0);
            }
            if (n % 2 == 0)
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == n - 1)
                        {
                            if (n / 2 == j || n / 2 + 1 == j)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }
                        else if (i < n / 2)
                        {
                            Console.Write(new String('-', count - 1));
                            Console.Write("*");
                            Console.Write(new String('-', dash));
                            Console.Write("*");
                            Console.Write(new String('-', count - 1));
                            dash += 2;
                            count--;
                            break;
                        }
                        else if (i == n / 2)
                        {
                            if (j == 1 || j == n)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            Console.Write(new String('-', count));
                            Console.Write("*");
                            Console.Write(new String('-', dash - 2));
                            Console.Write("*");
                            Console.Write(new String('-', count));
                            dash -= 2;
                            count++;
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == n)
                        {
                            if (n / 2 + 1 == j)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }
                        else if (i < n / 2 + 1)
                        {
                            Console.Write(new String('-', countOdd - 1));
                            Console.Write("*");
                            Console.Write(new String('-', dashOdd));
                            Console.Write("*");
                            Console.Write(new String('-', countOdd - 1));
                            dashOdd += 2;
                            countOdd--;
                            break;
                        }
                        else if (i == n / 2 + 1)
                        {
                            if (j == 1 || j == n)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }
                        else
                        {
                            Console.Write(new String('-', countOdd));
                            Console.Write("*");
                            Console.Write(new String('-', dashOdd - 2));
                            Console.Write("*");
                            Console.Write(new String('-', countOdd));
                            dashOdd -= 2;
                            countOdd++;
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
