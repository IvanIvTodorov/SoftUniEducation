using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            NumToMatrix(number);
        }

        static void NumToMatrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
