
using System;
using System.Linq;
using System.Reflection;

namespace Stealer
{
    public  class StartUp
    { 
        static void Main(string[] args)
        {

            Spy spy = new Spy();
            string className = typeof(Hacker).FullName;
            string result = spy.StealFieldInfo(className, "username" ,"password" );
            Console.WriteLine(result);

        }
    }
}
