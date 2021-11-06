using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string ADD_TO_NAME = "Command";
        public string Read(string args)
        {
            string startWith = args.Split(" ",StringSplitOptions.RemoveEmptyEntries)[0] + ADD_TO_NAME;


            var types = Assembly.GetCallingAssembly().GetTypes();
            var type = types.Where(n => n.IsClass).First(n => n.Name == startWith);

            if (type == null)
            {
                throw new ArgumentException("Invalid command name!");
            }

            var instance = (ICommand)Activator.CreateInstance(type);
           
            return instance.Execute(args.Split().Skip(1).ToArray());
        }
    }
}
