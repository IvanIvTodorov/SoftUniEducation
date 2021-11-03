using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HighQualityMistakes
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            var fields = Type.GetType(className).GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            var methods = Type.GetType(className).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} must be public!");
            }

            methods = Type.GetType(className).GetMethods(BindingFlags.Instance | BindingFlags.Public);

            foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} must be private!");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
