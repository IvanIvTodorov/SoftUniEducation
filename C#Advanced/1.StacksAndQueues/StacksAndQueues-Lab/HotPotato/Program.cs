using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int nthPerson = int.Parse(Console.ReadLine());

            Queue<string> people = new Queue<string>(input);

            while (people.Count != 1)
            {
                for (int i = 1; i < nthPerson; i++)
                {
                    string personIn = people.Dequeue();
                    people.Enqueue(personIn);
                }
                Console.WriteLine($"Removed {people.Dequeue()}");
            }
            Console.WriteLine($"Last is {people.Dequeue()}");
        }
    }
}
