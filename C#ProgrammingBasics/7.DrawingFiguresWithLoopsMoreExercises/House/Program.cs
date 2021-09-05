using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOdd = 0;
            int countEven = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n == 2)
                {
                    Console.WriteLine("**");
                    Console.WriteLine("||");
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (n % 2 == 0)
                        {
                            if (n / 2 >= i)
                            {
                                if (i == 1)
                                {
                                    if ((n / 2 == j || n / 2 + 1 == j))
                                    {
                                        Console.Write("*");
                                        countEven++;
                                    }
                                    else
                                    {
                                        Console.Write("-");
                                    }
                                }
                                else
                                {
                                    if (n / 2 == i)
                                    {
                                        Console.Write("*");
                                    }
                                    else if ((n - (countEven + 2)) / 2 >= j)
                                    {
                                        Console.Write("-");
                                        count++;
                                    }
                                    else
                                    {
                                        Console.Write(new String('*', countEven + 2));
                                        Console.Write(new String('-', count));
                                        countEven += 2;
                                        count = 0;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (j == 1 || j == n)
                                {
                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                        }
                        else
                        {
                            if (n / 2 + 1 >= i)
                            {
                                if (i == 1)
                                {
                                    if (n / 2 + 1 == j)
                                    {
                                        Console.Write("*");
                                        countOdd++;
                                    }
                                    else
                                    {
                                        Console.Write("-");
                                    }
                                }
                                else
                                {
                                    if (n / 2 + 1 == i)
                                    {
                                        Console.Write("*");
                                    }
                                    else if ((n - (countOdd + 2)) / 2 >= j)
                                    {
                                        Console.Write("-");
                                        count++;
                                    }
                                    else
                                    {
                                        Console.Write(new String('*', countOdd + 2));
                                        Console.Write(new String('-', count));
                                        countOdd += 2;
                                        count = 0;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (j == 1 || j == n)
                                {
                                    Console.Write("|");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
