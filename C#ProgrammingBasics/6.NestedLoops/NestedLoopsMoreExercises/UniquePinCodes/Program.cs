using System;

namespace UniquePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            for (int i = 2; i <= first; i++)
            {
                if (i % 2 == 0 )
                {
                    for (int j = 2; j <= second; j++)
                    {
                        if (j <=7 && (j == 2 || j % 2 != 0))
                        {
                            for (int c = 2; c <= third; c++)
                            {
                                if (c % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {c}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
