using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split();
            string[] second = Console.ReadLine()
                .Split();

            foreach (var text in second)
            {               
                foreach (var textTwo in first)
                {
                    if (text == textTwo)
                    {
                        Console.Write($"{text} ");
                    }
                }
            }               
        }
    }
}
