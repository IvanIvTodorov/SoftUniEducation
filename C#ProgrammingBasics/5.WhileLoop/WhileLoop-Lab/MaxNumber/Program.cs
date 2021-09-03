using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int maxNumber = int.MinValue;

            while (number != "Stop")
            {
                int curNumber = int.Parse(number);
                if (curNumber >= maxNumber)
                {
                    maxNumber = curNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
