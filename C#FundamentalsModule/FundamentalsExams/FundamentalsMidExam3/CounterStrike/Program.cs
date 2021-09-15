using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();
            int dayCount = 0;
            int battleWon = 0;

            while (text != "End of battle")
            {
                int takeOut = int.Parse(text);
                dayCount++;
                if (power - takeOut < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleWon} won battles and {power} energy");
                    Environment.Exit(0);
                }
                power -= takeOut;
                battleWon++;
                if (dayCount == 3)
                {
                    power += battleWon;
                    dayCount = 0;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {battleWon}. Energy left: {power}");
        }
    }
}
