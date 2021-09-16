using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(input);

            Stack<string> calculator = new Stack<string>(input);

            while (calculator.Count > 1)
            {
                int a = int.Parse(calculator.Pop());
                string sign = calculator.Pop();
                int b = int.Parse(calculator.Pop());

                if (sign == "+")
                {
                    calculator.Push((a + b).ToString());
                }
                else
                {
                    calculator.Push((a - b).ToString());
                }

            }

            Console.WriteLine(calculator.Pop());
                 
        }
    }
}
