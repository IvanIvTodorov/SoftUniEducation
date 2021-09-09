using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            while (text != "end")
            {

                string[] comand = text.Split().ToArray();
                switch (comand[0])
                {
                    case "exchange":
                        if (int.Parse(comand[1]) >= arr.Length || int.Parse(comand[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            PrintResult(comand, arr);
                        }                       
                        break;
                    case "max":
                        switch (comand[1])
                        {
                            case "even":
                                Console.WriteLine(PrintMaxEven(arr));
                                break;
                            case "odd":
                                Console.WriteLine(PrintMaxOdd(arr));
                                break;
                        }
                        break;
                    case "min":
                        switch (comand[1])
                        {
                            case "even":
                                Console.WriteLine(PrintMinEven(arr));
                                break;
                            case "odd":
                                Console.WriteLine(PrintMinOdd(arr));
                                break;
                        }
                        break;
                    case "first":
                        switch (comand[2])
                        {
                            case "even":
                                FirstEven(arr, comand);
                                break;
                            case "odd":
                                FirstOdd(arr, comand);
                                break;
                        }
                        break;
                    case "last":
                        switch (comand[2])
                        {
                            case "even":
                                LastEven(arr, comand);
                                break;
                            case "odd":
                                LastOdd(arr, comand);
                                break;
                        }
                        break;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static Array PrintResult(string[] comand, int[] arr)
        {

            List<int> first = new List<int>();
            List<int> second = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > int.Parse(comand[1]))
                {
                    first.Add(arr[i]);
                }
                else
                {
                    second.Add(arr[i]);
                }
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < first.Count)
                {
                    arr[i] = first[i];
                }
                else
                {
                    arr[i] = second[count];
                    count++;
                }
            }
            count = 0;
            return arr;
        }
        static string PrintMaxEven(int[] arr)
        {

            int maxEven = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] % 2 == 0)
                {
                    if ((int)arr[i] >= maxEven)
                    {
                        maxEven = (int)arr[i];
                        maxIndex = i;
                    }

                }

            }
            if (maxEven == int.MinValue)
            {
                string output = "No matches";
                return output;
            }
            return maxIndex.ToString();
        }
        static string PrintMaxOdd(int[] arr)
        {
            int maxOdd = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] % 2 != 0)
                {
                    if ((int)arr[i] >= maxOdd)
                    {
                        maxOdd = (int)arr[i];
                        maxIndex = i;
                    }
                }
            }
            if (maxOdd == int.MinValue)
            {
                string output = "No matches";
                return output;
            }
            return maxIndex.ToString();
        }
        static string PrintMinEven(int[] arr)
        {

            int minEven = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] % 2 == 0)
                {
                    if ((int)arr[i] <= minEven)
                    {
                        minEven = (int)arr[i];
                        minIndex = i;
                    }
                }
            }
            if (minEven == int.MaxValue)
            {
                string output = "No matches";

                return output;
            }
            return minIndex.ToString();
        }
        static string PrintMinOdd(int[] arr)
        {
            int minOdd = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] % 2 != 0)
                {
                    if ((int)arr[i] <= minOdd)
                    {
                        minOdd = (int)arr[i];
                        minIndex = i;
                    }
                }
            }
            if (minOdd == int.MaxValue)
            {
                string output = "No matches";
                return output;
            }
            return minIndex.ToString();
        }
        static void FirstEven(int[] arr, string[] comand)
        {
            List<string> firstEven = new List<string>();
            if (int.Parse(comand[1]) > arr.Length)
            {
                string output = "Invalid count";
                Console.WriteLine(output);
                return;
            }
            else
            {
                int countEven = 0;
                foreach (var num in arr)
                {
                    if (num % 2 == 0)
                    {
                        countEven++;
                        if (int.Parse(comand[1]) > firstEven.Count)
                        {
                            firstEven.Add(num.ToString());
                        }
                    }
                    
                }
                if (countEven == 0)
                {
                    string output = "[]";
                    Console.WriteLine(output);
                    return;
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstEven.ToArray())}]");
            return; 
        }
        static void FirstOdd(int[] arr, string[] comand)
        {
            List<string> firstOdd = new List<string>();
            if (int.Parse(comand[1]) > arr.Length)
            {
                string output = "Invalid count";
                Console.WriteLine(output);
                return;
            }
            else
            {
                int countOdd = 0;
                foreach (var num in arr)
                {
                    if (num % 2 != 0)
                    {
                        countOdd++;
                        if (int.Parse(comand[1]) > firstOdd.Count)
                        {
                            firstOdd.Add(num.ToString());
                        }
                    }
                    
                }
                if (countOdd == 0)
                {
                    string output = "[]";
                    Console.WriteLine(output);
                    return;
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstOdd.ToArray())}]"); 
            return;
        }
        static void LastEven(int[] arr, string[] comand)
        {
            List<string> lastEven = new List<string>();
            if (int.Parse(comand[1]) > arr.Length)
            {
                string output = "Invalid count";
                Console.WriteLine(output);
                return;
            }
            else
            {
                int count = 0;
                foreach (var num in arr)
                {
                    if (num % 2 == 0)
                    {
                        count++;
                        lastEven.Add(num.ToString());
                    }
                }
                if (count == 0)
                {
                    string output = "[]";
                    Console.WriteLine(output);
                    return;
                }
            }
            if (int.Parse(comand[1]) <= lastEven.Count)
            {
                int remove = lastEven.Count - int.Parse(comand[1]);
                lastEven.RemoveRange(0, remove);
            }
            

            Console.WriteLine($"[{string.Join(", ", lastEven.ToArray())}]");
            return;
        }
        static void LastOdd(int[] arr, string[] comand)
        {
            List<string> lastOdd = new List<string>();
            if (int.Parse(comand[1]) > arr.Length)
            {
                string output = "Invalid count";
                Console.WriteLine(output);
                return;
            }
            else
            {
                int count = 0;
                foreach (var num in arr)
                {
                    if (num % 2 != 0)
                    {
                        count++;
                        lastOdd.Add(num.ToString());
                    }
                }
                if (count == 0)
                {
                    string output = "[]";
                    Console.WriteLine(output);
                    return;
                }
            }

            if (int.Parse(comand[1]) <= lastOdd.Count)
            {
                int remove = lastOdd.Count - int.Parse(comand[1]);
                lastOdd.RemoveRange(0, remove);
            }
            
            Console.WriteLine($"[{string.Join(", ", lastOdd.ToArray())}]");
            return;
        }
    }
}