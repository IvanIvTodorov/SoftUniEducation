using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> hats = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> scarfs = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            List<int> sets = new List<int>();
            

            while (scarfs.Count != 0 && hats.Count != 0)
            {
                int sum = 0;
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                while (scarf >= hat)
                {
                    
                    if (scarf == hat)
                    {
                        hat++;
                        scarfs.Dequeue();
                        if (scarfs.Count == 0 || hats.Count == 0)
                        {
                            Console.WriteLine($"The most expensive set is: {sets.Max()}");
                            Console.WriteLine(string.Join(" ", sets));
                            Environment.Exit(0);
                        }
                        scarf = scarfs.Peek();
                    }
                    else if (scarf > hat)
                    {
                        hats.Pop();
                        if (scarfs.Count == 0 || hats.Count == 0)
                        {
                            Console.WriteLine($"The most expensive set is: {sets.Max()}");
                            Console.WriteLine(string.Join(" ", sets));
                            Environment.Exit(0);
                        }
                        hat = hats.Peek();
                    }                    
                }
                

                sum = hat + scarf;
                sets.Add(sum);

                hats.Pop();
                scarfs.Dequeue();
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));

        }

    }
}
