using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = SplitInput();

            for (int i = 4; i < input.Length; i++)
            {
                input[3] += $" {input[i]}";
            }   

            var threeuple = new MyThreeuple<string, string, string>(($"{input[0]} {input[1]}"), input[2], input[3]);

            input = SplitInput();

            var second = new MyThreeuple<string, int, bool>(input[0], int.Parse(input[1]),
                input[2] == "drunk" ? true : false);

            input = SplitInput();

            var third = new MyThreeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);

            Console.WriteLine(threeuple);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }

        private static string[] SplitInput()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
