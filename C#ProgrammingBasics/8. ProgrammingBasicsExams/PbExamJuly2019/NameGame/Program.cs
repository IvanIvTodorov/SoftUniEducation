using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int count = 0;
            int points = 0;
            string winner = "";

            while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number == (int)Convert.ToChar(name[i]))
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (points >= count)
                {
                    count = points;
                    winner = name;
                }

                name = Console.ReadLine();
                points = 0;
                
            }
            Console.WriteLine($"The winner is {winner} with {count} points!");
        }
    }
}
