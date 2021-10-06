using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> numbers = SplitInput();
            List<string> web = SplitInput();

            foreach (var number in numbers)
            {
                if (number.All(char.IsDigit))
                {
                    if (number.Length == 10)
                    {
                        ISmartPhone dial = new SmartPhone();
                        dial.CallPhone(number);
                    }
                    else
                    {
                        IDialing dial = new StationaryPhone();
                        dial.CallTelephone(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var website in web)
            {
                if (website.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    ISmartPhone dial = new SmartPhone();
                    dial.Browse(website);
                }
            }
        }

        private static List<string> SplitInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }
    }
}
