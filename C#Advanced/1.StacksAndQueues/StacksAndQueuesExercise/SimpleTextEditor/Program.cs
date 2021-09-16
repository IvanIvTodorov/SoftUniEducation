using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> backup = new Stack<string>();
          
            string text = string.Empty;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "1")
                {
                    backup.Push(text);
                    text += command[1];
                }
                else if (command[0] == "2")
                {
                    backup.Push(text);

                    text = text.Remove(text.Length - int.Parse(command[1]), int.Parse(command[1]));
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text[(int.Parse(command[1]) - 1)] );                    
                }
                else if (command[0] == "4")
                {
                    text = backup.Pop().ToString();
                }

            }

        }
    }
}
