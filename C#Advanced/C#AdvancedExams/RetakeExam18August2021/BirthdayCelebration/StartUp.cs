using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> food = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int wastedFood = 0;
            int currentGuest = 0;
            int currentFood = 0;

            while (guests.Count != 0 && food.Count != 0)
            {
                currentGuest = guests.Dequeue();
                currentFood = food.Pop();

                while (currentGuest > currentFood)
                {
                    currentGuest -= currentFood;
                    if (food.Count == 0)
                    {
                        break;
                    }
                    currentFood = food.Pop();
                }

                wastedFood += currentFood - currentGuest;
            }

            if (guests.Count == 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", food)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
