using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();

            char[] back = user.ToCharArray();
            Array.Reverse(back);

            string password = new string(back);
            string input = Console.ReadLine();
            int count = 0;

            while (password != input)
            {
                count++;
                if (count == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    Environment.Exit(0);
                }
                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
            }
            Console.WriteLine($"User {user} logged in.");
        }
    }
}
