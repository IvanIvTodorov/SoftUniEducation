using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var list = new MyList<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                list.List.Add(input);

            }

            int[] indexs = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            list.SwapElements(indexs[0], indexs[1]);

            Console.WriteLine(list);

        }
    }
}
