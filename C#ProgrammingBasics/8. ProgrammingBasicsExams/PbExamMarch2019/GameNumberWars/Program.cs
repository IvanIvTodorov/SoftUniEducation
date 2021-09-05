using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int fCount = 0;
            int sCount = 0;

            string command = Console.ReadLine();

            while (command != "End of game")
            {
                int cardF = int.Parse(command);
                int cardS = int.Parse(Console.ReadLine());

                if (cardF == cardS)
                {
                    Console.WriteLine("Number wars!");
                    cardF = int.Parse(Console.ReadLine());
                    cardS = int.Parse(Console.ReadLine());

                    if (cardF > cardS)
                    {                        
                        Console.WriteLine($"{first} is winner with {Math.Abs(fCount)} points");
                        Environment.Exit(0);
                    }
                    else
                    {                        
                        Console.WriteLine($"{second} is winner with {Math.Abs(sCount)} points");
                        Environment.Exit(0);
                    }
                }
                else if (cardF > cardS)
                {
                    fCount += cardF - cardS;
                }
                else
                {
                    sCount += cardS - cardF;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{first} has {fCount} points");
            Console.WriteLine($"{second} has {sCount} points");
        }
    }
}
