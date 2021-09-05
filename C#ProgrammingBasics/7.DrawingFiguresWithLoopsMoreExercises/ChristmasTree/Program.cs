using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n ; i++)
            {
                for (int j = i; j <= n - 1 ; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(" ");
                        
                    }
                    else if (i >= 1 && i < n)
                    {
                        Console.Write(" ");
                    }
                    
                }
                if (i == 0)
                {
                    Console.Write(" |");
                    Console.WriteLine(new String(' ', n));
                    continue;
                }
                for (int c = 1; c <= i; c++)
                {
                    
                    Console.Write("*");                       
                }
                Console.Write(" | ");
                for (int q = 1; q <= i; q++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
