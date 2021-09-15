using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();
            int countJump = 0;
            while (text != "Love!")
            {
                string[] jump = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                countJump += int.Parse(jump[1]);

                if (countJump > integers.Count - 1)
                {
                    countJump = 0;
                }

                if (integers[countJump] == 0)
                {
                    Console.WriteLine($"Place {countJump} already had Valentine's day.");
                }
                else
                {
                    integers[countJump] -= 2;
                    if (integers[countJump] == 0)
                    {
                        Console.WriteLine($"Place {countJump} has Valentine's day.");
                    }
                }
                


                text = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {countJump}.");

            bool isOkay = true;
            int badHouses = 0;
            foreach (var item in integers)
            {
                if (item > 0)
                {
                    isOkay = false;
                    badHouses++;
                }
            }

            if (isOkay)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {badHouses} places.");
            }
        }
    }
}
