using System;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AuthorProblem
{
    public  class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            StringBuilder sb = new StringBuilder();
            var methods = typeof(StartUp).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);

                    foreach (AuthorAttribute atr in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {atr.Name}");
                    }
                }
            }
        }
    }
}
