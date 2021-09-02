using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int yPeople = 0;
            int nPeople = 0;
            int noPeople = 0;
            int chekDay = 3;

            for (int i = 1; i <= period; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (chekDay == i)
                {
                    chekDay += 3;
                    if (noPeople >= yPeople)
                    {
                        doctors += 1;
                    }
                }
                if (people <= doctors)
                {
                    yPeople += people;
                }
                else
                {
                    yPeople += doctors;
                    nPeople = people - doctors;
                    noPeople += nPeople;
                }
            }
            Console.WriteLine($"Treated patients: {yPeople}.");
            Console.WriteLine($"Untreated patients: {noPeople}.");
        }
    }
}
