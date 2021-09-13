using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitter = new string[] { "\\",};
            string[] text = Console.ReadLine()
                .Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            string[] result = text.Last()
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");               
        }
    }
}
