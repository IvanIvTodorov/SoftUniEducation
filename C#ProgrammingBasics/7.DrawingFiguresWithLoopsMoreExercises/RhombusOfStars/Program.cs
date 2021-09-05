using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k < n; k++)
                {
                    if (i == 1)
                    {
                        Console.Write(" ");
                    }
                    else if (i == n)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(new String(' ', n-i));
                        break;
                    }
                    
                }
                if (i == 1)
                {
                    Console.Write("*");
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (j == n)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(new String(' ', j));
                        break;
                    }
                }
                if (j == n - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    for (int k = n - 1; k >= j ; k--)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
