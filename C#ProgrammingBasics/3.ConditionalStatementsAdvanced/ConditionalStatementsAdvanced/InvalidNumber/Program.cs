using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool valid = num >= 100 && num <= 200 || num == 0;

            if (!valid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
