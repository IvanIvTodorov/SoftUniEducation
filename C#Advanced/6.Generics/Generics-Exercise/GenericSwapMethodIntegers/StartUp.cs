using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.list.Add(input);
            }

            int[] indexs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.SwapElements(indexs[0], indexs[1]);

            Console.WriteLine(box);
        }
    }
}
