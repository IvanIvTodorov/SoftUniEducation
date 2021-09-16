using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<int> indexs = new Queue<int>();
            Queue<int> distance = new Queue<int>();
            Queue<int> petrol = new Queue<int>();

            for (int i = 0; i < pumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                indexs.Enqueue(i);               
                petrol.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }

            string start = "0";
            int sumPetrol = 0;
            int currentIndex = 0;

            while (true)
            {
                int current = indexs.Dequeue();
                int diesel = petrol.Dequeue();
                int kilometers = distance.Dequeue();

                sumPetrol += diesel;

                if (sumPetrol < kilometers)
                {
                    sumPetrol = 0;
                    start = indexs.Peek().ToString();
                }
                else
                {
                    currentIndex = indexs.Peek();
                    sumPetrol -= kilometers;
                }

                petrol.Enqueue(diesel);
                distance.Enqueue(kilometers);
                indexs.Enqueue(current);
                

                if (start == currentIndex.ToString())
                {
                    break;
                }
                
            }

            Console.WriteLine(start);
            
        }
    }
}
