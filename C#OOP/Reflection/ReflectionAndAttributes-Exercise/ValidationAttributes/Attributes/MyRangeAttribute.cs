using System;

namespace ValidationAttributes.Attributes
{
    class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int min, int max)
        {
            minValue = min;
            maxValue = max;
        }

        public override bool IsValid(object obj)
        {
            var value = Convert.ToInt32(obj);

            if (value >= minValue && value <= maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
