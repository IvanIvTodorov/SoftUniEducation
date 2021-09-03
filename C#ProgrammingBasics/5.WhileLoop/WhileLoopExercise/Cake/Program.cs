using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int size = width * length;
            int piece = 0;

            while (size > piece)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{size - piece} pieces are left.");
                    Environment.Exit(0);
                }

                piece += int.Parse(command);
            }
            Console.WriteLine($"No more cake left! You need {piece - size} pieces more.");
        }
    }
}
