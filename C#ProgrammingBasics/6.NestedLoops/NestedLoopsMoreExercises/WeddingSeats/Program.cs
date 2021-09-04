using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seatsOdd = int.Parse(Console.ReadLine());

            int count = 0;
            int countOdd = 0;
            int countEven = 0;

            for (char i = 'A'; i <= sector; i++)
            {
                if (i != 'A')
                {
                    rows++; ;
                }
                for (int j = 1; j <= rows; j++)
                {
                    if (j % 2 != 0)
                    {
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            countOdd++;
                            if (countOdd <= seatsOdd)
                            {
                                Console.WriteLine($"{i}{j}{c}");
                                count++;
                            }
                            else
                            {
                                countOdd = 0;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            countEven++;
                            if (countEven <= seatsOdd + 2)
                            {
                                Console.WriteLine($"{i}{j}{c}");
                                count++;
                            }
                            else
                            {
                                countEven = 0;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
