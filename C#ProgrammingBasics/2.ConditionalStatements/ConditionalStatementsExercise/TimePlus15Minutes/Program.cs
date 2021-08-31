using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes <= 44)
            {
                Console.WriteLine($"{hours}:{minutes + 15}");
            }
            else if (hours ==23 & minutes == 45)
            {
                Console.WriteLine($"{hours - hours}:{minutes - minutes}0");
            }
            else if (minutes == 45)
            {
                Console.WriteLine($"{hours + 1}:{minutes - minutes}0");
            }
            else if (hours == 23 & minutes >= 46 & minutes <= 54)
            {
                Console.WriteLine($"{hours - hours}:0{minutes + 15 - 60}");
            }
            else if (minutes >=46 & minutes<=54)
            {
                Console.WriteLine($"{hours + 1}:0{minutes + 15 -60}");
            }
            else if (hours == 23 & minutes >54)
            {
                Console.WriteLine($"{hours - hours}:{minutes + 15 - 60}");
            }
            else
            {
                Console.WriteLine($"{hours + 1}:{minutes + 15 - 60}");
            }

        }
    }
}
