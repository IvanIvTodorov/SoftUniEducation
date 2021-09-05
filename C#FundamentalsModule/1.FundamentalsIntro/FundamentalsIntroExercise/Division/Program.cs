using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int secNumber = 0;

            if (number % 2 == 0)
            {
                secNumber = 2;
                if (number % 3 == 0)
                {
                    secNumber = 3;
                    if (number % 6 == 0)
                    {
                        secNumber = 6;
                    }
                }
            }
            if (number % 3 == 0)
            {
                secNumber = 3;
                if (number % 6 == 0)
                {
                    secNumber = 6;
                }
            }
            if (number % 7 == 0)
            {
                secNumber = 7;
            }
            if (number % 10 == 0)
            {
                secNumber = 10;
            }
            else if (number % 2 != 0 && number % 3 != 0 && number % 6 != 0 && number % 7 != 0)
            {
                Console.WriteLine("Not divisible");
                Environment.Exit(0);
            }
            Console.WriteLine($"The number is divisible by {secNumber}");
        }
    }
}
