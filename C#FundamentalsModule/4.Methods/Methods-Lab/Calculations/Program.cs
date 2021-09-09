using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string toDo = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            PrintResult(toDo, first, second);
        }

        static void PrintResult(string toDo, int firstNum, int secondNum)
        {
            switch (toDo)
            {
                case "add":
                    Console.WriteLine(firstNum += secondNum);
                    break;
                case "substract":
                    Console.WriteLine(firstNum -= secondNum);
                    break;
                case "multiply":
                    Console.WriteLine(firstNum *= secondNum);
                    break;
                case "divide":
                    Console.WriteLine(firstNum /= secondNum);
                    break;
            }

        }
    }
}
