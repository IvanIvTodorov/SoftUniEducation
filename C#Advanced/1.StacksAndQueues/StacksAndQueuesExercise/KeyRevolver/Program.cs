using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBulllet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int value = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksArr);
            Stack<int> bullets = new Stack<int>(bulletsArr);

            int sum = 0;
            int reload = sizeOfBarrel;

            while (bullets.Count != 0)
            {
                int currentLock = locks.Peek();
                int currentBullet = bullets.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                sum += priceOfBulllet;
                bullets.Pop();

                sizeOfBarrel--;
                if (sizeOfBarrel == 0)
                {
                    sizeOfBarrel = reload;
                    if (bullets.Count != 0)
                    {
                        Console.WriteLine("Reloading!");
                    }
                }
                
                if (locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${value - sum}");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
    }
}
