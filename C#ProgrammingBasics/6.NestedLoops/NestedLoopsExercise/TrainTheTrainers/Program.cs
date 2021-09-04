using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judge = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double countGrades = 0;
            double allGrades = 0;
            while (presentation != "Finish")
            {
                double currGrades = 0;
                for (int i = 0; i < judge; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currGrades += grade;
                    allGrades += grade;
                    countGrades++;
                }
                Console.WriteLine($"{presentation} - {currGrades / judge:F2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allGrades / countGrades:F2}.");
        }
    }
}
