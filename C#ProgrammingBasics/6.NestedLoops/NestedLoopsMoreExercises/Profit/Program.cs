using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= one; i++)
            {
                for (int j = 0; j <= two; j++)
                {
                    for (int c = 0; c <= five; c++)
                    {
                        if (i * 1 + j * 2 + c * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
