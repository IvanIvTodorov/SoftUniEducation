using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            MyListyIterator<string> myIetarator = new MyListyIterator<string>(input.Skip(1).ToArray());

            string command = Console.ReadLine();

            while (command != "END")
            {               
                if (command == "Move")
                {
                    Console.WriteLine(myIetarator.Move());
                }
                else if (command == "Print")
                {
                    try
                    {
                        myIetarator.Print();
                    }
                    catch (InvalidOperationException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(myIetarator.HasNext());
                }

                command = Console.ReadLine();
            }
        }
    }
}
