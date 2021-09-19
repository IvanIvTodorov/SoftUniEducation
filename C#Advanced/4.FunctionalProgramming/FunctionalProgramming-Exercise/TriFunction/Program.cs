using System;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            foreach (var name in names)
            {
                foreach (char symbol in name)
                {
                    sum += symbol;
                }
                if (sum >= length)
                {
                    Console.WriteLine(name);
                    break;
                }
                sum = 0;
            }
        }
    }
}
