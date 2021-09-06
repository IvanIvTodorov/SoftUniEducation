using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());

            int count = 0;
            int i = 0;
            double percent = n * 0.5;

            for (i = n; i >= m; i-=m)
            {
                if (percent == i && y != 0)
                {
                    i /= y;
                }
                if (i >= m)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(i);
            Console.WriteLine(count);          
        }
    }
}
