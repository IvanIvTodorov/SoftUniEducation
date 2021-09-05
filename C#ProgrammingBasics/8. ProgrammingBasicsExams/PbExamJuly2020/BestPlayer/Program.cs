using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string best = "";
            int count = 0;

            while (name != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (count < goals )
                {
                    count = goals;
                    best = name;
                    if (count >= 10)
                    {
                        break;
                    }
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{best} is the best player!");
            if (count >= 3)
            {
                Console.WriteLine($"He has scored {count} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {count} goals.");
            }

        }
    }
}
