using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxvalue;

        public MyRangeAttribute(int minValue, int maxvalue)
        {
            this.minValue = minValue;
            this.maxvalue = maxvalue;
        }

        public override bool IsValid(object obj)
        {
            if (obj is int valueAsInt)
            {
                if (valueAsInt >= minValue && valueAsInt <= maxvalue)
                {
                    return true;
                }

                return false;
            }

            throw new ArgumentException("Invalid type!");

        }
    }
}
