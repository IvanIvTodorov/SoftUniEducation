using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            char symbol = Convert.ToChar(letter);

            if (char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
