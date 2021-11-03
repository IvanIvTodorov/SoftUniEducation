using System;

namespace MissionPrivateImpossible
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Spy spy = new Spy();
            string type = typeof(Hacker).FullName;
            string result = spy.RevealPrivateMethods(type);
            Console.WriteLine(result);


        }
    }
}
