using System;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double average = 0;
            double low = 0;
            double medium = 0;
            double good = 0;
            double excelent = 0;


            for (int i = 1; i <= number; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade < 3.00)
                {
                    low++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    medium++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    good++;
                }
                else
                {
                    excelent++;
                }
                average += grade;
            }
            Console.WriteLine($"Top students: {excelent / (double)number * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good / (double)number * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {medium / (double)number * 100:F2}%");
            Console.WriteLine($"Fail: {low / (double)number * 100:F2}%");
            Console.WriteLine($"Average: {average / (double)number:F2}");
        }
    }
}
