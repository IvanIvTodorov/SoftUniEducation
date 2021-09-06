using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string secondN = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{name}{delimeter}{secondN}");
        }
    }
}
