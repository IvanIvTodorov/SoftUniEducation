using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();
            string finalText = string.Empty;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                string currentList = numbers[i].ToString();
                int sum = 0;
                for (int j = 0; j < currentList.Length; j++)
                {
                    sum += int.Parse(currentList[j].ToString());
                }
                if (sum > text.Length)
                {
                    sum -= text.Length;
                }
                for (int c = 0; c < text.Length; c++)
                {
                    if (sum == c)
                    {
                        finalText +=(text[c].ToString());
                        text = text.Remove(c, 1);
                    }
                }
            }
            Console.WriteLine(finalText);
        }
    }
}
