using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input == "Cat")
                {
                    try
                    {
                        Cat cat = new Cat(command[0], int.Parse(command[1]), command[2]);
                        Console.WriteLine(cat);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                }
                else if (input == "Kitten")
                {
                    try
                    {
                        Kitten kitten = new Kitten(command[0], int.Parse(command[1]));
                        Console.WriteLine(kitten);

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                }
                else if (input == "Tomcat")
                {
                    try
                    {
                        Tomcat tomcat = new Tomcat(command[0], int.Parse(command[1]));
                        Console.WriteLine(tomcat);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                }
                else if (input == "Dog")
                {
                    try
                    {
                        Dog dog = new Dog(command[0], int.Parse(command[1]), command[2]);
                        Console.WriteLine(dog);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                }
                else
                {
                    try
                    {
                        Frog frog = new Frog(command[0], int.Parse(command[1]), command[2]);
                        Console.WriteLine(frog);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e);
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
