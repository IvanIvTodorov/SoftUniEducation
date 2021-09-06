using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int open = 0;
            int close = 0;
            int count = 0;


            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                count++;
                char first = text[0];

                if (count == 1 && text[0] == '(')
                {
                    open++;
                }
                else if (count == 1 && text[0] == ')')
                {
                    Console.WriteLine("UNBALANCED");
                    Environment.Exit(0);
                }
                else if (text[0] == ')')
                {
                    close++;
                    if (open == 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        Environment.Exit(0);
                    }
                    else if (close < 2)
                    {
                        open = 0;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        Environment.Exit(0);
                    }
                }
                else if (text[0] == '(')
                {
                    open++;
                    if (open == 2)
                    {
                        Console.WriteLine("UNBALANCED");
                        Environment.Exit(0);
                    }
                    else
                    {
                        close = 0;
                    }
                }               
            }
            if (open > close)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
