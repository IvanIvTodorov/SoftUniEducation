using System;
using System.Reflection;

namespace HighQualityMistakes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string type = typeof(Hacker).FullName;
            string result = spy.AnalyzeAccessModifiers(type);
            Console.WriteLine(result);
        }
    }
}
