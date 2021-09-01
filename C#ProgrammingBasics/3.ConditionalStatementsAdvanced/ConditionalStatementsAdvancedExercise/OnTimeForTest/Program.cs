using System;

namespace OnTimeForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourE = int.Parse(Console.ReadLine());
            int minE = int.Parse(Console.ReadLine());
            int hourA = int.Parse(Console.ReadLine());
            int minA = int.Parse(Console.ReadLine());


            if (hourE == hourA && minE == minA)
            {
                Console.WriteLine("On time");
            }
            else if (hourE == hourA && minE - minA >= 0 && minE - minA <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{minA - minE} before the start");
            }
            else if (hourE - hourA == 1)
            {
                if (minE - minA <= -30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minA - minE} before after the start");
                }
            }
            else if (hourE == hourA && minE - minA < 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{minA - minE} minutes after the start");
            }
            else if (hourE - hourA < 0)
            {
                if (minE - minA == 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hourA - hourE}:{minE - minA} hours after the start");
                }
                else if (minE - minA < 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hourA - hourE}:{minA - minE} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hourE - hourA}:{minE - minA} hours after the start");
                }
            }
            else if (hourE == hourA && minE - minA > 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{minE - minA} minutes after the start");
            }
            else if (hourE - hourA > 0)
            {
                if (minE - minA >= 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hourA - hourE}:{minE - minA} hours after the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hourA - hourE}:{minA - minE} hours after the start");
                }

            }
        }
    }
}
