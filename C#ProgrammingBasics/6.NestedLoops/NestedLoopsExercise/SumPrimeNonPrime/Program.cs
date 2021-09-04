using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int prime = 0;
            int nonPrime = 0;

            while (number != "stop")
            {
                int num = int.Parse(number);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    number = Console.ReadLine();
                    continue;
                }
                else if (num == 1 || num == 0)
                {
                    nonPrime += num;
                    number = Console.ReadLine();
                    continue;
                }
                int cPrime = 0;
                int cNon = 0;
                    for (int i = 2; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                        cNon++;
                        }
                        else
                        {
                        cPrime++;
                        }
                    }
                if (cNon >= 2)
                {
                    nonPrime += num;
                }
                else
                {
                    prime += num;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}


