using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (number != "Stop")
            {
                int curNumber = int.Parse(number);
                if (curNumber <= minNumber)
                {
                    minNumber = curNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
