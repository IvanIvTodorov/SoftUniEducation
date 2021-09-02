using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studetns = int.Parse(Console.ReadLine());

            decimal bad = 0.00m;
            decimal good = 0.00m;
            decimal veryG = 0.00m;
            decimal excelent = 0.00m;
            decimal students = 0.00m;
            decimal average = 0.00m;

            for (int i = 1; i <= studetns; i++)
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                if (grade >= 2 && grade <3)
                {
                    bad += 1;
                    students += 1;
                }
                else if (grade >= 3 && grade < 4)
                {
                    good += 1;
                    students += 1;
                }
                else if (grade >= 4 && grade < 5)
                {
                    veryG += 1;
                    students += 1;
                }
                else
                {
                    excelent += 1;
                    students += 1;
                }
                average += grade;
            }

            Console.WriteLine($"Top students: {excelent / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryG / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {good / students * 100:F2}%");
            Console.WriteLine($"Fail: {bad / students * 100:F2}%");
            Console.WriteLine($"Average: {average / students:F2}");
             
        }
    }
}
