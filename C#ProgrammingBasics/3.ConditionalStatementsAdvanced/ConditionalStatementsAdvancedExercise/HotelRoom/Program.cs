using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());


            if (month == "May" && nights <= 7 || month == "October" && nights <= 7)
            {
                Console.WriteLine($"Apartment: {nights * 65:f2} lv.");
                Console.WriteLine($"Studio: {nights * 50:F2} lv.");
            }
            else if (month == "May" && nights > 7 && nights <= 14 || month == "October" && nights >7 && nights <=14)
            {
                Console.WriteLine($"Apartment: {nights * 65:f2} lv.");
                Console.WriteLine($"Studio: {nights * 50 * 0.95:F2} lv.");
            }
            else if (month == "May" && nights > 14 || month == "October" && nights > 14)
            {
                Console.WriteLine($"Apartment: {nights * 65 * 0.90:f2} lv.");
                Console.WriteLine($"Studio: {nights * 50 * 0.70:F2} lv.");
            }
            else if (month == "June" && nights <=14 || month == "September" && nights <=14 )
            {
                Console.WriteLine($"Apartment: {nights * 68.70:f2} lv.");
                Console.WriteLine($"Studio: {nights * 75.20:F2} lv.");
            }
            else if (month == "June" && nights > 14 || month == "September" && nights > 14)
            {
                Console.WriteLine($"Apartment: {nights * 68.70 * 0.90:f2} lv.");
                Console.WriteLine($"Studio: {nights * 75.20 * 0.80:F2} lv.");
            }
            else if (month == "July" && nights <= 14 || month == "August" && nights <= 14)
            {
                Console.WriteLine($"Apartment: {nights * 77:f2} lv.");
                Console.WriteLine($"Studio: {nights * 76:F2} lv.");
            }
            else if (month == "July" && nights > 14 || month == "August" && nights > 14)
            {
                Console.WriteLine($"Apartment: {nights * 77 * 0.90:f2} lv.");
                Console.WriteLine($"Studio: {nights * 76:F2} lv.");
            }

        }
    }
}
