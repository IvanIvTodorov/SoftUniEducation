using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            int shootTargets = 0;
            string text = Console.ReadLine();

            while (text != "End")
            {
                int index = int.Parse(text);


                if (index >= 0 && index < targets.Count)
                {
                    if (targets[index] != -1)
                    {
                        int currentValue = targets[index];
                        targets[index] = -1;
                        shootTargets++;
                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > currentValue)
                                {
                                    targets[i] -= currentValue;
                                }
                                else
                                {
                                    targets[i] += currentValue;
                                }
                            }
                        }
                    }
                    
                }
                text = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootTargets} -> {string.Join(" ", targets)}");
        }
    }
}
