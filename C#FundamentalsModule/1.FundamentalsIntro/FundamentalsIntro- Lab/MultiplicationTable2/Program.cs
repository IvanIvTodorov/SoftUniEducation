using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplication = int.Parse(Console.ReadLine());

            if (multiplication > 10)
            {
                Console.WriteLine($"{input} X {multiplication} = {input * multiplication}");
            }
            else
            {
                for (int i = multiplication; i <= 10; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }
        }
    }
}
