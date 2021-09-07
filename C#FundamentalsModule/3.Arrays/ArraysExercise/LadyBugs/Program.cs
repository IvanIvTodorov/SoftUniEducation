using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            short size = short.Parse(Console.ReadLine());

            int[] ladyBugs = new int[size];

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < ladyBugs.Length; i++)
            {
                foreach (var num in numbers)
                {
                    if (i == num)
                    {
                        ladyBugs[i] = 1;
                    }
                }
            }

            string direction = Console.ReadLine();

            while (direction != "end")
            {

                string[] way = direction.Split(" ").ToArray();



                int index = 0;
                int bounce = 0;
                for (int i = 0; i < way.Length; i++)
                {
                    if (i == 0)
                    {
                        index = int.Parse(way[i]);
                    }
                    else if (i == 1)
                    {
                        direction = way[i].ToString();
                    }
                    else
                    {
                        bounce = int.Parse(way[i]);
                    }
                }
                if (index >= 0 && index < ladyBugs.Length)
                {
                    if (int.Parse(ladyBugs[index].ToString()) == 0)
                    {
                        direction = Console.ReadLine();
                        continue;
                    }
                    
                }
                if (direction == "right")
                {
                    if (index >= 0 && index < ladyBugs.Length)
                    {
                        if (bounce == 0)
                        {

                        }
                        else if (bounce < 0)
                        {
                            bounce = Math.Abs(bounce);
                            if (index - bounce >= 0)
                            {
                                for (int i = index - bounce; i >= 0; i -= bounce)
                                {
                                    if (ladyBugs[i] == 0)
                                    {
                                        ladyBugs[i] = 1;
                                        ladyBugs[index] = 0;
                                        break;
                                    }
                                    else
                                    {
                                        ladyBugs[index] = 0;
                                    }
                                }
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                            }

                        }
                        else
                        {
                            if (index + bounce < ladyBugs.Length)
                            {
                                for (int i = index + bounce; i < ladyBugs.Length; i += bounce)
                                {
                                    if (ladyBugs[i] == 0)
                                    {
                                        ladyBugs[i] = 1;
                                        ladyBugs[index] = 0;
                                        break;
                                    }
                                    else
                                    {
                                        ladyBugs[index] = 0;
                                    }
                                }
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                            }
                        }

                    }
                }
                else
                {
                    if (index >= 0 && index < ladyBugs.Length)
                    {
                        if (bounce == 0)
                        {

                        }
                        else if (bounce < 0)
                        {
                            bounce = Math.Abs(bounce);
                            if (index + bounce < ladyBugs.Length)
                            {
                                for (int i = index + bounce; i < ladyBugs.Length; i += bounce)
                                {
                                    if (ladyBugs[i] == 0)
                                    {
                                        ladyBugs[i] = 1;
                                        ladyBugs[index] = 0;
                                        break;
                                    }
                                    else
                                    {
                                        ladyBugs[index] = 0;
                                    }
                                }
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                            }

                        }
                        else
                        {
                            if (index - bounce >= 0)
                            {
                                for (int i = index - bounce; i >= 0; i -= bounce)
                                {
                                    if (ladyBugs[i] == 0)
                                    {
                                        ladyBugs[i] = 1;
                                        ladyBugs[index] = 0;
                                        break;
                                    }
                                    else
                                    {
                                        ladyBugs[index] = 0;
                                    }
                                }
                            }
                            else
                            {
                                ladyBugs[index] = 0;
                            }
                        }
                    }

                }
                direction = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
