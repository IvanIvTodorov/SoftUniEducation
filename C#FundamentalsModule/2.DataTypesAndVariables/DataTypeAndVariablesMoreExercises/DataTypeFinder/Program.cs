using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int integer = 0;
            double floatingPoint = 0;
            char character = ' ';
            bool boolean = true;

            while (input != "END")
            {

                if (int.TryParse(input, out integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out floatingPoint))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
