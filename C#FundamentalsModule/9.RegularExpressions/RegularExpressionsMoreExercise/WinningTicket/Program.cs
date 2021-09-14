using System;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitters = new string[] { ",", " " };

            string[] input = Console.ReadLine()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            string containsPattern = @"[\@\$\^\#]*";

            foreach (var text in input)
            {
                if (!Regex.IsMatch(text, containsPattern) && text.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    if (text.Length == 20)
                    {
                        if (Regex.IsMatch(text, containsPattern))
                        {
                            string jackpotPattern = @"[$]{20}|[#]{20}|[@]{20}|[\^]{20}";

                            if (Regex.IsMatch(text, jackpotPattern))
                            {
                                char symbol = text[0];
                                Console.WriteLine($"ticket \"{text}\" - 10{symbol} Jackpot!");
                                continue;
                            }
                            else
                            {
                                string fisrtHalf = string.Empty;
                                string secondHalf = string.Empty;

                                for (int i = 0; i < text.Length; i++)
                                {
                                    if (i <= 9)
                                    {
                                        fisrtHalf += text[i].ToString();
                                    }
                                    else
                                    {
                                        secondHalf += text[i].ToString();
                                    }
                                }
                                if (Regex.IsMatch(fisrtHalf, @"[$]{6}") && Regex.IsMatch(secondHalf, @"[$]{6}"))
                                {
                                    if (Regex.IsMatch(fisrtHalf, @"[$]{9}") && Regex.IsMatch(secondHalf, @"[$]{9}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 9$");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[$]{8}") && Regex.IsMatch(secondHalf, @"[$]{8}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 8$");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[$]{7}") && Regex.IsMatch(secondHalf, @"[$]{7}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 7$");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 6$");
                                    }
                                }
                                else if (Regex.IsMatch(fisrtHalf, @"[#]{6}") && Regex.IsMatch(secondHalf, @"[#]{6}"))
                                {
                                    if (Regex.IsMatch(fisrtHalf, @"[#]{9}") && Regex.IsMatch(secondHalf, @"[#]{9}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 9#");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[#]{8}") && Regex.IsMatch(secondHalf, @"[#]{8}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 8#");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[#]{7}") && Regex.IsMatch(secondHalf, @"[#]{7}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 7#");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 6#");
                                    }
                                }
                                else if (Regex.IsMatch(fisrtHalf, @"[@]{6}") && Regex.IsMatch(secondHalf, @"[@]{6}"))
                                {
                                    if (Regex.IsMatch(fisrtHalf, @"[@]{9}") && Regex.IsMatch(secondHalf, @"[@]{9}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 9@");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[@]{8}") && Regex.IsMatch(secondHalf, @"[@]{8}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 8@");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[@]{7}") && Regex.IsMatch(secondHalf, @"[@]{7}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 7@");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 6@");
                                    }
                                }
                                else if (Regex.IsMatch(fisrtHalf, @"[\^]{6}") && Regex.IsMatch(secondHalf, @"[\^]{6}"))
                                {
                                    if (Regex.IsMatch(fisrtHalf, @"[\^]{9}") && Regex.IsMatch(secondHalf, @"[\^]{9}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 9^");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[\^]{8}") && Regex.IsMatch(secondHalf, @"[\^]{8}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 8^");
                                        continue;
                                    }
                                    else if (Regex.IsMatch(fisrtHalf, @"[\^]{7}") && Regex.IsMatch(secondHalf, @"[\^]{7}"))
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 7^");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"ticket \"{text}\" - 6^");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{text}\" - no match");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{text}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid ticket");
                    }
                }
            }
        }
    }
}
