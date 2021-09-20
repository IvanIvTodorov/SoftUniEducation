using System;

namespace DefiningClasses
{
     public class StartUp
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            //Family family = new Family();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    Person person = new Person(input[0], int.Parse(input[1]));

            //    family.AddMemeber(person);
            //}

            string[] firstDate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondDate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            DateModifier dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(string.Join("", dateModifier.DayDifference()));
        }
    }
}
