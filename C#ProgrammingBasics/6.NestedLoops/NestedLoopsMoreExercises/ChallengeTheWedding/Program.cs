using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int k = 1; k <= women ; k++)
                {
                    count++;
                    if (count > tables)
                    {
                        Environment.Exit(0);
                    }
                    else if (count == tables)
                    {
                        Console.Write($"({i} <-> {k}) ");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write($"({i} <-> {k}) ");
                    }
                }
            }
        }
    }
}
