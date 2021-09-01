using System;

namespace NumbersOneToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <=10);
        }
    }
}
