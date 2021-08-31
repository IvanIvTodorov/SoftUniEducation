using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int a = 3;

            int hoursPerProject = projects * a;

            Console.WriteLine($"The architect {name} will need {hoursPerProject} hours to complete {projects} project/s.");
        }
    }
}
