using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();


            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes()
                    .Where(ca => ca is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(property.GetValue(obj)) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}
