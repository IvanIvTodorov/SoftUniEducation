using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int count = 0;
            Stack<int> army = null;
            int plate = 0;
            int warrior = 0;

            for (int i = 0; i < waves; i++)
            {
                army = new Stack<int>(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());
                count++;

                if (count == 3)
                {
                    int add = int.Parse(Console.ReadLine());
                    plates.Enqueue(add);
                    count = 0;
                }                

                while (army.Count != 0 && plates.Count != 0)
                {
                    warrior = army.Pop();
                    plate = plates.Peek();

                    if (warrior > plate)
                    {
                        warrior -= plate;
                        army.Push(warrior);
                        plates.Dequeue();
                    }
                    else if (plate > warrior)
                    {
                        plate -= warrior;

                        List<int> result = plates.ToList();
                        result[0] = plate;
                        plates = new Queue<int>(result);
                    }
                    else if (plate == warrior)
                    {
                        plate = plates.Dequeue();
                    }

                }

                if (plates.Count == 0)
                {
                    break;
                }

            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", army)}");
            }
        }
    }
}
