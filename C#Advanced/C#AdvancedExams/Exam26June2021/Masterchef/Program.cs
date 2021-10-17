using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> freshLevel = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            SortedDictionary<string, int> meals = new SortedDictionary<string, int>();
            int ingredient = 0;
            int freshness = 0;
            
            while (ingredients.Count != 0 && freshLevel.Count != 0)
            {

                ingredient = ingredients.Peek();
                freshness = freshLevel.Peek();

                while(ingredient == 0)
                {
                    ingredients.Dequeue();
                    if (ingredients.Count == 0)
                    {
                        break;
                    }
                    ingredient = ingredients.Peek();
                }

                int total = ingredient * freshness;

                FindMeal(ref ingredients, meals, ref ingredient, total);

                ingredients.Dequeue();
                freshLevel.Pop();
            }

            if (meals.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var meal in meals)
            {
                Console.WriteLine($" # {meal.Key} --> {meal.Value}");
            }

        }

        private static void FindMeal(ref Queue<int> ingredients, SortedDictionary<string, int> meals, ref int ingredient, int total)
        {
            if (total == 150)
            {
                if (!meals.ContainsKey("Dipping sauce"))
                {
                    meals.Add("Dipping sauce", 1);
                }
                else
                {
                    meals["Dipping sauce"] += 1;
                }
            }
            else if (total == 250)
            {
                if (!meals.ContainsKey("Green salad"))
                {
                    meals.Add("Green salad", 1);
                }
                else
                {
                    meals["Green salad"] += 1;
                }
            }
            else if (total == 300)
            {
                if (!meals.ContainsKey("Chocolate cake"))
                {
                    meals.Add("Chocolate cake", 1);
                }
                else
                {
                    meals["Chocolate cake"] += 1;
                }
            }
            else if (total == 400)
            {
                if (!meals.ContainsKey("Lobster"))
                {
                    meals.Add("Lobster", 1);
                }
                else
                {
                    meals["Lobster"] += 1;
                }
            }
            else
            {
                ingredient += 5;
                ingredients.Enqueue(ingredient);
            }
        }
    }
}
