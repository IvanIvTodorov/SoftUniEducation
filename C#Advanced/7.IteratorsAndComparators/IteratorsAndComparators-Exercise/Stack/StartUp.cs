using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            MyStack<int> myStack = new MyStack<int>(input.Skip(1)
                .Select(int.Parse)
                .ToArray());

            string text = Console.ReadLine();
            while (text != "END")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    myStack.Push(int.Parse(command[1]));
                }
                else
                {
                    myStack.Pop();
                }

                text = Console.ReadLine();
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
