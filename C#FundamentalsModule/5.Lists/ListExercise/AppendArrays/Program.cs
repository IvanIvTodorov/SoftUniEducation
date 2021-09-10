using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split("|");

            Array.Reverse(text);
            List<string> final = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string[] current = text[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < current.Length; j++)
                {
                    final.Add(current[j]);
                }
            }
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
