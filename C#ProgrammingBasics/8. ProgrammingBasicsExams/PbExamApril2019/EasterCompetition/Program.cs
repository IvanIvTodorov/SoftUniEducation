using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());

            int points = 0;
            int secondPoints = 0;
            int winPoints = 0;
            string nameWon = "";

            for (int i = 1; i <= bread; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine();

                while (command != "Stop")
                {
                    int grade = int.Parse(command);
                    points += grade;
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{name} has {points} points.");
                if (points > secondPoints)
                {
                    Console.WriteLine($"{name} is the new number 1!");
                    nameWon = name;
                    winPoints = points;
                }
                secondPoints = points;
                points = 0;
            }
            Console.WriteLine($"{nameWon} won competition with {winPoints} points!");
        }
    }
}
