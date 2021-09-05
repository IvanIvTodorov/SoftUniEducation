using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            while (text != "End of battle")
            {
                if (text == "one")
                {
                    second--;
                    if (second == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {first} eggs left.");
                        Environment.Exit(0);
                    }   
                }
                else
                {
                    first--;
                    if (first == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {second} eggs left.");
                        Environment.Exit(0);
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"Player one has {first} eggs left.");
            Console.WriteLine($"Player two has {second} eggs left.");
        }
    }
}
