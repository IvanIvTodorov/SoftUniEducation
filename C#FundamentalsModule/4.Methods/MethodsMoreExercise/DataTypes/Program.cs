using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string number = Console.ReadLine();

            if (text == "string")
            {
                Console.WriteLine(MultiplyInput(number));
            }
            else if (text == "int")
            {
                Console.WriteLine(MultiplyInput(int.Parse(number)));
            }
            else
            {
                Console.WriteLine($"{MultiplyInput(double.Parse(number)):f2}");
            }
            
        }

        static string MultiplyInput(string number)
        {
            string newString = $"${number}$";

            return newString;
        }
        static int MultiplyInput(int number )
        {
            int newInt = number * 2;

            return newInt;
        }
        static double MultiplyInput(double number)
        {
            double newInt = number * 1.5;

            return newInt;
        }
    }
}
