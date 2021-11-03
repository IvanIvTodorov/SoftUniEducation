using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MissionPrivateImpossible
{
    public class Spy
    {

        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            var methods = Type.GetType(className).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {Type.GetType(className).BaseType.Name}");
            foreach (var method in methods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().TrimEnd();
        }

    }
}
