using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            string text = "";
            double average = 0;
            double exams = 0;
            double bad = 0;
            string last = "";

            while (text != "Enough")
            {
                text = Console.ReadLine();
                if (text != "Enough")
                {
                    double grade = double.Parse(Console.ReadLine());
                    if (grade <= 4)
                    {
                        bad += 1;
                        average += grade;
                        exams += 1;
                        last = text;
                        if (bad == badGrades)
                        {
                            Console.WriteLine($"You need a break, {badGrades} poor grades.");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        average += grade;
                        exams += 1;
                        last = text;
                    }
                }
            }
            double averageFinal = average / exams;

            Console.WriteLine($"Average score: {averageFinal:F2}");
            Console.WriteLine($"Number of problems: {exams}");
            Console.WriteLine($"Last problem: {last}");
        }
    }
}
