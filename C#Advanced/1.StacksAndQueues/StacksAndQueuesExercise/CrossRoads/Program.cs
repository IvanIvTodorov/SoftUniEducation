using System;
using System.Collections.Generic;

namespace CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int seconds = int.Parse(Console.ReadLine());
            int getOut = int.Parse(Console.ReadLine());
           
            int passed = 0;
            int greenLight = seconds;
            string text = Console.ReadLine();
            while (text != "END")
            {
                if (text == "green")
                {                    
                    while (cars.Count != 0)
                    {
                        string current = cars.Dequeue();
                        int sum = current.Length;

                        if (seconds > sum)
                        {
                            seconds -= sum;                            
                            passed++;
                        }
                        else
                        {
                            sum -= seconds;

                            if (getOut >= sum)
                            {
                                passed++;
                                break;
                            }
                            else
                            {
                                sum -= getOut;

                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{current} was hit at {current.Substring(current.Length - sum, 1)}.");
                                Environment.Exit(0);
                            }
                        }
                    }

                    seconds = greenLight;
                }
                else
                {
                    cars.Enqueue(text);
                }
                text = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passed} total cars passed the crossroads.");
        }
    }
}
