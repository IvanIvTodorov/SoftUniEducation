using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wage = int.Parse(Console.ReadLine());

            int wageLeft = 0;

            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        wageLeft = wage - 150;
                        wage = wage - 150;
                        break;
                    case "Instagram":
                        wageLeft = wage - 100;
                        wage = wage - 100;
                        break;
                    case "Reddit":
                        wageLeft = wage - 50;
                        wage = wage - 50;
                        break;
                }
                if (website != "Facebook" && website != "Instagram" && website != "Reddit")
                {
                    wageLeft = wage;
                }
                if (wage <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (wage > 0)
            {
                Console.WriteLine(wageLeft);
            }

        }
    }
}
