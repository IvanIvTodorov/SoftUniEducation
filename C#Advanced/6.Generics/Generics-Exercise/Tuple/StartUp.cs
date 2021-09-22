using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = SplitInput();

            MyTuple<string, string> tuple = new MyTuple<string, string>(($"{input[0]} {input[1]}"), input[2]);

            input = SplitInput();

            var secTuple = new MyTuple<string, int>(input[0], int.Parse(input[1]));

            input = SplitInput();

            var thirdTuple = new MyTuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine(tuple);
            Console.WriteLine(secTuple);
            Console.WriteLine(thirdTuple);
        }

        private static string[] SplitInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
