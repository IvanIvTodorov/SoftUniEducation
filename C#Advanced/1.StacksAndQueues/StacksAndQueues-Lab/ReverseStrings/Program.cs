using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> output = new Stack<char>(input);

            while (output.Count > 0)
            {
                Console.Write(output.Pop());
            }
        }
    }
}
