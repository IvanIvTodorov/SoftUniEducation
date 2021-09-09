using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(WhatIsNumber(first, second, third));
        }

        static string WhatIsNumber(int first, int second, int third)
        {
            string output = string.Empty;
            if (first == 0 || second == 0 || third == 0)
            {
                output = "zero";
            }
            else if (first > 0 && second > 0 && third > 0)
            {
                output = "positive";
            }
            else if (first < 0 && second < 0 && third > 0)
            {
                output = "positive";
            }
            else if (first < 0 && second > 0 && third < 0)
            {
                output = "positive";
            }
            else if (first > 0 && second < 0 && third < 0)
            {
                output = "positive";
            }
            else
            {
                output = "negative";
            }
            
            return output;
        }
    }
}
