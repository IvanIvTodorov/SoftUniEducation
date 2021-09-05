using System;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int aOne = int.Parse(Console.ReadLine());
            int aTwo = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = aOne; i <= aTwo - 1; i++)
            {
                char first = Convert.ToChar(i);
                int firstN = (int)first;
                if (firstN % 2 != 0)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        for (int k = 1; k <= n / 2 - 1; k++)
                        {
                            if ((j + k + firstN) % 2 != 0)
                            {
                                Console.WriteLine($"{first}-{j}{k}{firstN}");
                            }
                        }
                    }
                }
            }
        }
    }
}
