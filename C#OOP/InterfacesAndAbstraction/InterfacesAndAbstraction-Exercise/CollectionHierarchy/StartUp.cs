using System;
using System.Linq;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int times = int.Parse(Console.ReadLine());

            var add = new AddElement();
            var addOrRemove = new AddOrRemove();
            var myList = new MyList();

            Console.WriteLine(string.Join(" ", add.Add(elements)));
            Console.WriteLine(string.Join(" ", addOrRemove.Add(elements)));
            Console.WriteLine(string.Join(" ", myList.Add(elements)));
            Console.WriteLine(string.Join(" ", addOrRemove.Remove(times)));
            Console.WriteLine(string.Join(" ", myList.Remove(times)));
        }
    }
}
