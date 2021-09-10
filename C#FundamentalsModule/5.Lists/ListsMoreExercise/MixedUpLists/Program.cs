using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> final = new List<int>();

            int numOne = 0;
            int numTwo = 0;
            int i = 0;
            while (true)
            {
                final.Add(first[0]);
                first.RemoveAt(0);
                final.Add(second[second.Count - 1]);
                second.RemoveAt(second.Count - 1);
                if (first.Count == 0)
                {
                    for (int b = second.Count - 1; b >= 0; b--)
                    {
                        final.Add(second[b]);
                    }
                    break;
                }
                else if (second.Count == 0)
                {
                    for (int j = 0; j < first.Count; j++)
                    {
                        final.Add(first[j]);
                    }
                    break;
                }
            }
            if (first.Count != 0)
            {
                numOne = final.IndexOf(first[i]);
                numTwo = final.IndexOf(first[++i]);
                numOne = final[numOne];
                numTwo = final[numTwo];
            }
            else
            {
                numOne = final.IndexOf(second[i]);
                numTwo = final.IndexOf(second[++i]);
                numOne = final[numOne];
                numTwo = final[numTwo];
            }

            if (numOne < numTwo)
            {
                int temp = numOne;
                numOne = numTwo;
                numTwo = temp;
            }

            List<int> last = final
                .Where(n => n > numTwo && n < numOne)
                .ToList();

            last.Sort();

            Console.WriteLine(string.Join(" ", last));        
        }
    }
}
