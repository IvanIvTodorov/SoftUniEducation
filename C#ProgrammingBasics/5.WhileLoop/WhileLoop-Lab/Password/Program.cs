using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            
            while (true)
            {
                string inPass = Console.ReadLine();
                if (inPass == pass)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }
        }
    }
}
