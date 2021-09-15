using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] places = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < places.Length; i++)
            {

                int add = 4 - places[i];
                if (add == 0)
                {
                    continue;
                }
                if (people < add)
                {
                    places[i] += people;
                    Console.WriteLine("The lift has empty spots!");
                    people = 0;
                    break;
                }
                else
                {
                    places[i] += add;
                    people -= add;
                }
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
           
            
            Console.WriteLine(string.Join(" ", places));
        }
    }
}
