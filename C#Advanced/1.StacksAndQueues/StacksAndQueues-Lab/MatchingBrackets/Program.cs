using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<int> matches = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == "(")
                {
                    matches.Push(i);
                }
                else if (text[i].ToString() == ")")
                {
                    int index = matches.Pop();
                    Console.WriteLine(text.Substring(index , i - index + 1));
                }
            }
        }
    }
}
