using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> first = new Queue<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray());

            Stack<string> second = new Stack<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray());

            List<string> words = new List<string>();
            List<string> pearToFind = new List<string>();
            List<string> flourToFind = new List<string>();
            List<string> porkToFind = new List<string>();
            List<string> oliveToFind = new List<string>();

            string pear = "pear";
            int pearCount = 4;
            string flour = "flour";
            int flourCount = 5;
            string pork = "pork";
            int porkCount = 4;
            string olive = "olive";
            int oliveCount = 5;

            while (second.Count != 0)
            {
                string firstChar = first.Dequeue();
                string secondChar = second.Peek();

                if (pear.Contains(firstChar))
                {
                    if (!pearToFind.Contains(firstChar))
                    {
                        pearToFind.Add(firstChar);
                    }
                    if (pearCount == pearToFind.Count)
                    {
                        if (!words.Contains(pear))
                        {
                            words.Add(pear);
                        }
                    }
                }
                if (pear.Contains(secondChar))
                {
                    if (!pearToFind.Contains(secondChar))
                    {
                        pearToFind.Add(secondChar);
                    }
                    if (pearCount == pearToFind.Count)
                    {
                        if (!words.Contains(pear))
                        {
                            words.Add(pear);
                        }
                    }
                }


                if (flour.Contains(firstChar))
                {
                    if (!flourToFind.Contains(firstChar))
                    {
                        flourToFind.Add(firstChar);
                    }
                    if (flourCount == flourToFind.Count)
                    {
                        if (!words.Contains(flour))
                        {
                            words.Add(flour);
                        }
                    }
                }
                if (flour.Contains(secondChar))
                {
                    if (!flourToFind.Contains(secondChar))
                    {
                        flourToFind.Add(secondChar);
                    }
                    if (flourCount == flourToFind.Count)
                    {
                        if (!words.Contains(flour))
                        {
                            words.Add(flour);
                        }
                    }
                }

                if (pork.Contains(firstChar))
                {
                    if (!porkToFind.Contains(firstChar))
                    {
                        porkToFind.Add(firstChar);
                    }
                    if (porkCount == porkToFind.Count)
                    {
                        if (!words.Contains(pork))
                        {
                            words.Add(pork);
                        }
                    }
                }
                if (pork.Contains(secondChar))
                {
                    if (!porkToFind.Contains(secondChar))
                    {
                        porkToFind.Add(secondChar);
                    }
                    if (porkCount == porkToFind.Count)
                    {
                        if (!words.Contains(pork))
                        {
                            words.Add(pork);
                        }
                    }
                }
                if (olive.Contains(firstChar))
                {
                    if (!oliveToFind.Contains(firstChar))
                    {
                        oliveToFind.Add(firstChar);
                    }
                    if (oliveCount == oliveToFind.Count)
                    {
                        if (!words.Contains(olive))
                        {
                            words.Add(olive);
                        }
                    }
                }
                if (olive.Contains(secondChar))
                {
                    if (!oliveToFind.Contains(secondChar))
                    {
                        oliveToFind.Add(secondChar);
                    }
                    if (oliveCount == oliveToFind.Count)
                    {
                        if (!words.Contains(olive))
                        {
                            words.Add(olive);
                        }
                    }
                }
                first.Enqueue(firstChar);
                second.Pop();
            }

            Console.WriteLine($"Words found: {words.Count}");
            if (words.Contains(pear))
            {
                Console.WriteLine(pear);
            }
            if (words.Contains(flour))
            {
                Console.WriteLine(flour);
            }
            if (words.Contains(pork))
            {
                Console.WriteLine(pork);
            }
            if (words.Contains(olive))
            {
                Console.WriteLine(olive);
            }
        }
    }
}
