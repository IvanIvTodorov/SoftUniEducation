using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                int current = 0;
                current = i;
                int count = 0;

                while (i > 0)
                {
                    count += i % 10;
                    i = i / 10;
                }
                bool special = false;
                special = (count == 5) || (count == 7) || (count == 11);
                Console.WriteLine("{0} -> {1}", current, special);
                count = 0;
                i = current;
            }

        }
    }
}
