using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.Write($"{numbers[i]} ");

                sum += numbers[i];                   
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
