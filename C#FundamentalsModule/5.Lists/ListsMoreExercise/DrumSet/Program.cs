using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            List<int> sequnece = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> drumSet = new List<int>();
            foreach (var item in sequnece)
            {
                drumSet.Add(item);
            }

            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] = drumSet[i] - power;
                    if (drumSet[i] <= 0)
                    {
                        if (money >= sequnece[i] * 3)
                        {
                            drumSet[i] = sequnece[i];
                            money -= drumSet[i] * 3;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            sequnece.RemoveAt(i);
                            if (i < drumSet.Count)
                            {
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {money:F2}lv.");
        }
    }
}
