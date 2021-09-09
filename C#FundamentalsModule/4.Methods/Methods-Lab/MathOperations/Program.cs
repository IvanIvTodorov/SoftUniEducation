using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            GetResult(firstNum, operation, secondNum);
        }

        static void GetResult(int firstNum, string operation, int secondNum)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case "-":
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case "*":
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case "/":
                    Console.WriteLine(firstNum / secondNum);
                    break;
            }
        }
    }
}
