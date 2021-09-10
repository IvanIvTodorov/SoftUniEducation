using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int remember = 0;
            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    sum += numbers[0];
                    remember = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);                   
                }
                else if (index > numbers.Count - 1)
                {
                    sum += numbers[numbers.Count - 1];
                    remember = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(numbers.Count, numbers[0]);
                }
                else
                {
                    sum += numbers[index];
                    remember = numbers[index];
                    numbers.RemoveAt(index);                    
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= remember)
                    {
                        numbers[i] = numbers[i] + remember;
                    }
                    else
                    {
                        numbers[i] = numbers[i] - remember;
                    }
                }
                                     
            }
            Console.WriteLine(sum);
        }
    }
}
