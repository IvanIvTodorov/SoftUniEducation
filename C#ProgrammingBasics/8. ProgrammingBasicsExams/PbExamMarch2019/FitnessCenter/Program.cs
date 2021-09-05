using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shake = 0;
            int bar = 0;
            double train = 0;
            double buy = 0;

            for (int i = 1; i <= visitors; i++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {
                    case "Back":
                        back++;
                        train++;
                        break;
                    case "Chest":
                        chest++;
                        train++;
                        break;
                    case "Legs":
                        legs++;
                        train++;
                        break;
                    case "Abs":
                        abs++;
                        train++;
                        break;
                    case "Protein shake":
                        shake++;
                        buy++;
                        break;
                    case "Protein bar":
                        buy++;
                        bar++;
                        break;
                }
            }
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{shake} - protein shake");
            Console.WriteLine($"{bar} - protein bar");
            Console.WriteLine($"{train / (double)visitors * 100:f2}% - work out");
            Console.WriteLine($"{buy / (double)visitors * 100:F2}% - protein");
        }
    }
}
