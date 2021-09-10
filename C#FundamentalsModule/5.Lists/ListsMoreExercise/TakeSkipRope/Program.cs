using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<int> numbers = new List<int>();

            string text = string.Empty;
            string final = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (char.IsDigit(command[i]))
                {
                    numbers.Add(int.Parse(command[i].ToString()));
                }
                else
                {
                    text += command[i].ToString();
                }
            }
            int count = 0;
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (index > numbers.Count - 1)
                {
                    break;
                }
                if (count == numbers[index])
                {
                    index++;                   
                    i += numbers[index];
                    index++;
                    i--;
                    count = 0;
                    continue;
                }
                final += text[i].ToString();
                count++;
            }
            Console.WriteLine(final);
            
        }
    }
}