using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceS = double.Parse(Console.ReadLine());
            double priceR = double.Parse(Console.ReadLine());
            double priceB = double.Parse(Console.ReadLine());

            double studentsP = Math.Ceiling((double)students * 1.1);
            double lightsaber = studentsP * priceS;
            double robes = priceR * (double)students;
            double belts = 0;

            int count = 0;

            for (int i = 1; i <= students; i++)
            {
                count++;
                if (count == 6)
                {
                    count = 0;
                }
                else
                {
                    belts += priceB;
                }
            }
            double finalP = lightsaber + robes + belts;
            if (budget >= finalP )
            {
                Console.WriteLine($"The money is enough - it would cost {finalP:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {finalP - budget:F2}lv more.");
            }
        }
    }
}
