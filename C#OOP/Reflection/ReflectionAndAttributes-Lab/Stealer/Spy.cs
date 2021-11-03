using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {

        public string StealFieldInfo(string name, params string[] parameters)
        {
            StringBuilder sb = new StringBuilder();

            var fields = Type.GetType(name).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var instance = Activator.CreateInstance(Type.GetType(name), new object[] { });

            sb.AppendLine($"Class under investigation: {name}");
            foreach (var field in fields.Where(f => parameters.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
               
            }

            return sb.ToString().TrimEnd();
        }
    }
}
